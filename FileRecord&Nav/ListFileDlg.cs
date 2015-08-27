//Copyright (c) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnvDTE;
using System.IO;
using System.Xml;

namespace FileModifyRecorder
{
    public partial class ListFileDlg : Form
    {

        EnvDTE80.DTE2 _dte;
        System.Collections.Generic.List<ProjectItemInfo> _fileNames;
        bool _manuallySettingSelection;
        Timer LogTimer = new Timer();
        DataTable RecordTable
        {
            get {
                return gridControl1.DataSource as DataTable;   
            }
            set {
                gridControl1.DataSource = value;
                gridControl1.RefreshDataSource();
            }
        }
        DevExpress.XtraEditors.LabelControl curLog;
        RecordHandler recHandler;

        public ListFileDlg(EnvDTE80.DTE2 dte,RecordHandler rec)
        {
            InitializeComponent();
            //配置文件地址
            txt_FilePath.Text = RecordHandler.GetValueFromRegistry();
            

            _manuallySettingSelection = false;
            _dte = dte;
            _fileNames = new System.Collections.Generic.List<ProjectItemInfo>();
            foreach (EnvDTE.Project project in _dte.Solution.Projects)
            {
                WalkProject(project.ProjectItems);
            }

            LogTimer.Interval = 2000;
            LogTimer.Tick += new EventHandler(LogTimer_Tick);

            RecordTable = initRecordTable();
            initProjectSelector();
            btn_ReadRecordCurProject_Click(null, null);

            de_begin.DateTime = DateTime.Today;
            de_end.DateTime = DateTime.Today;

            recHandler = rec;

            
        }


#region Control Events
		  void LogTimer_Tick(object sender, EventArgs e)
        {
            curLog.Visible = false;
            LogTimer.Stop();
        }
	
        private void Form1_Load(object sender, EventArgs e)
        {
            FillList(listView1, GetCurOpenFileInfo(), true);
        }

          private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_manuallySettingSelection == false)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    textBox1.Text = listView1.SelectedItems[0].Text.Split('.')[0];
                }
            }
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<ProjectItemInfo> list = new List<ProjectItemInfo>();
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                list.Add((listView1.SelectedItems[i].Tag as ProjectItemInfo));
            }
            FillList(listView2, list, false);
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
                listView2.SelectedItems[0].Remove();
        }

      #endregion

#region Functions

        private void initProjectSelector()
        {
            foreach (Project proj in _dte.Solution.Projects)
            {
                cb_projects.Properties.Items.Add(proj.Name);
            }
            cb_projects.SelectedIndex = 0;
        }

        private DataTable initRecordTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FileName");
            table.Columns.Add("SaveTime");
            table.Columns.Add("Project");
            return table;
        }
        void WalkProject(ProjectItems projectItems)
        {
            if (projectItems == null)
                return;

            foreach (ProjectItem projectItem in projectItems)
            {
                if (projectItem.Kind == EnvDTE.Constants.vsProjectItemKindPhysicalFile)
                {
                    _fileNames.Add(new ProjectItemInfo(projectItems.ContainingProject.Name, projectItem.get_FileNames(0)));
                }
                WalkProject(projectItem.ProjectItems);
            }
        }
            //获取文件列表
        void FillList(ListView listView1, List<ProjectItemInfo> _fileNames, bool DoClear)
        {
            if (DoClear)
                listView1.Items.Clear();
            foreach (ProjectItemInfo fileName in _fileNames)
            {


                ListViewItem item = listView1.Items.Add(System.IO.Path.GetFileName(fileName._filePath));
                item.SubItems.Add(fileName._projectUniqueName);
                item.Tag = fileName;

            }
            if (listView1.Items.Count > 0)
            {
                _manuallySettingSelection = true;
                listView1.Items[0].Selected = true;
                _manuallySettingSelection = false;
            }
            //textBox1.Select();
        }
		private void ShowLog(DevExpress.XtraEditors.LabelControl lb_Log, string text)
        {
            lb_Log.Text = text;
            lb_Log.Visible = true;
            curLog = lb_Log;
            LogTimer.Start();
        }

        //按过滤输入行内容过滤当前文件表
        private void FilterList(ListView listView)
        {
            List<ProjectItemInfo> list = new List<ProjectItemInfo>();
            foreach (ListViewItem item in listView.Items)
            {
                ProjectItemInfo info = item.Tag as ProjectItemInfo;
                if (System.IO.Path.GetFileName(info._filePath).ToLower().StartsWith(textBox1.Text.ToLower()))
                    list.Add(info);
            }
            FillList(listView, list, true);
        }

        //从一个ListView过滤项到ProjectItemInfo集
        private void FilterListToListItem(ListView view1,string filterStr,ref List<ProjectItemInfo> list)
        {
            foreach (ListViewItem item in view1.Items)
            {
                ProjectItemInfo info = item.Tag as ProjectItemInfo;
                if (System.IO.Path.GetFileName(info._filePath).ToLower().StartsWith(filterStr.ToLower()))
                    list.Add(info);
            }

        }

        //按字符串集过滤整个工程的文件
        private void FilterProjectList(List<string> filterStrList)
        {
            btn_AllProjectFiles_Click(null, null);
            List<ProjectItemInfo> list = new List<ProjectItemInfo>();
            foreach (string str in filterStrList)
            {
                FilterListToListItem(listView1,str,ref list);
            }
            FillList(listView2, list, true);
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }
        private void AddRecords(XmlNodeList list)
        {
            if (list == null || list.Count == 0)
                return;
            try 
	        {	        
                 
		         foreach (XmlNode node in list)
                 {
                     DataRow row = RecordTable.NewRow();

                     row["FileName"] =node.Attributes.GetNamedItem("FileName").Value;
                     row["Project"] = node.Attributes.GetNamedItem("Project").Value;
                     row["SaveTime"] = node.Attributes.GetNamedItem("Time").Value;
                     RecordTable.Rows.Add(row);

                  }
                  gridControl1.RefreshDataSource();
        	}
	        catch (Exception)
	        {
                ShowLog(lbl_ErrorLog2,"读取配置文件出错");  
	        	
	        }
        }

        //获取当前打开文件列表
        private List<ProjectItemInfo> GetCurOpenFileInfo()
        {
            try
            {
                List<ProjectItemInfo> infos = new List<ProjectItemInfo>();
                foreach (Document doc in _dte.ActiveDocument.Collection)
                {
                    ProjectItemInfo info = new ProjectItemInfo(doc.ProjectItem.ContainingProject.Name, doc.FullName);
                    infos.Add(info);
                }
                return infos;
            }
            catch (Exception)
            {
                //没打开文档就为空，有打开文档还获取不到则报错
                if (_dte.ActiveDocument != null)
                    ShowLog(lbl_Log, "获取文件列表出错");
                return new List<ProjectItemInfo>();
            }

        }
        #endregion
      
#region Button Events
          private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tb_Path.Text))
            {
                ShowLog(lbl_Log, "目标目录不存在");
                return;

            }

            if (listView2.Items.Count > 0)
            {
                try
                {
                    foreach (ListViewItem item in listView2.Items)
                    {
                        ProjectItemInfo info = item.Tag as ProjectItemInfo;
                        if (File.Exists(info._filePath))
                        {
                            File.Copy(info._filePath, Path.Combine(tb_Path.Text, Path.GetFileName(info._filePath)));
                        }
                    }
                    ShowLog(lbl_Log, "复制完毕");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("复制文件失败\r\n" + ex.StackTrace);

                }

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btn_TrimRepeat_Click(object sender, EventArgs e)
        {
            DataView view = RecordTable.DefaultView;

            RecordTable = view.ToTable(true, "FileName", "Project");
            RecordTable.Columns.Add("SaveTime");
            gridControl1.RefreshDataSource();
        }

        private void btn_FilterByTime_Click(object sender, EventArgs e)
        {
            DateTime begin = de_begin.DateTime;
            DateTime end = de_end.DateTime;
            DateTime SaveTime;
            for(int i=RecordTable.Rows.Count-1;i>-1;i--)
            {
                DataRow row = RecordTable.Rows[i];
                SaveTime = DateTime.Parse(row["SaveTime"].ToString()).Date;
                if (SaveTime.CompareTo(begin.Date) >= 0 && SaveTime.CompareTo(end.Date) <= 0)
                {

                }
                else
                    RecordTable.Rows.Remove(row);

            }
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                tb_Path.Text = dialog.SelectedPath;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            _dte.ItemOperations.OpenFile(((ProjectItemInfo)listView1.SelectedItems[0].Tag)._filePath, EnvDTE.Constants.vsViewKindPrimary);
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            string path = (listView1.SelectedItems[0].Tag as ProjectItemInfo)._filePath;
            path = path.Substring(0, path.LastIndexOf('\\'));
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            listView1_MouseDoubleClick(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void btn_AllProjectFiles_Click(object sender, EventArgs e)
        {

            _fileNames.Clear();
            foreach (EnvDTE.Project project in _dte.Solution.Projects)
            {
                WalkProject(project.ProjectItems);
            }
            FillList(listView1, _fileNames, true);
        }

        private void btn_AddAll_Click(object sender, EventArgs e)
        {
            List<ProjectItemInfo> list = new List<ProjectItemInfo>();
            foreach (ListViewItem item in listView1.Items)
            {
                list.Add(item.Tag as ProjectItemInfo);
            }
            FillList(listView2, list, true);
        }

        private void btn_CurFiles_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            FillList(listView1, GetCurOpenFileInfo(), true);
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            FilterList(listView1);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void btn_TargetFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tb_Path.Text))
            {
                System.Diagnostics.Process.Start("explorer.exe", tb_Path.Text);
            }
            else
                ShowLog(lbl_Log, "目标目录不存在");

        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xml|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = dialog.FileName;
                RecordHandler.SetValueToRegistry(txt_FilePath.Text);
            }
        }

        private void btn_ReadRecordCurProject_Click(object sender, EventArgs e)
        {
            try
            {
                RecordTable.Rows.Clear();
                if (!File.Exists(txt_FilePath.Text))
                {
                    ShowLog(lbl_ErrorLog2, "记录文件不存在");
                    return;
                }
                else
                {
                    string str = cb_projects.Text;
                    if (_dte.Solution.Projects.Count == 0)
                        return;

                  
                    XmlDocument doc = new XmlDocument();
                    doc.Load(txt_FilePath.Text);
                    
                        if (doc.DocumentElement.GetElementsByTagName(str).Count != 0)
                            AddRecords(doc.DocumentElement.GetElementsByTagName(str)[0].ChildNodes);
                    
                    ShowLog(lbl_ErrorLog2, "读取记录完成");
                }
            }
            catch
            {
                ShowLog(lbl_ErrorLog2, "读取记录文件出错");
            }
        }

        private void btn_LookUpInProject_Click(object sender, EventArgs e)
        {
            int[] selection = gridView1.GetSelectedRows();
            List<string> list = new  List<string>();
            for (int i = 0; i < selection.Length; i++)
            {
                list.Add((gridView1.GetRow(selection[i]) as DataRowView).Row["FileName"].ToString());
            }
            FilterProjectList(list);

        }

        private void btn_ClearRecords_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清除当前工程的记录？","", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               ShowLog(lbl_ErrorLog2, recHandler.ClearRecord(cb_projects.Text));
               btn_ReadRecordCurProject_Click(null, null);
            }
        }

#endregion

       

    }



    }

    class ProjectItemInfo
    {
        internal ProjectItemInfo(string projectUniqueName, string filePath)
        {
            _projectUniqueName = projectUniqueName;
            _filePath = filePath;
        }
        internal string _projectUniqueName;
        internal string _filePath;
    }
    
