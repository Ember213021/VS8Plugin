//Copyright (c) Microsoft Corporation.  All rights reserved.

namespace FileModifyRecorder
{
	partial class ListFileDlg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lbl_Log = new DevExpress.XtraEditors.LabelControl();
            this.btn_TargetFolder = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_AddAll = new System.Windows.Forms.Button();
            this.btn_AllProjectFiles = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_CurFiles = new System.Windows.Forms.Button();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btn_LookUpInProject = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_FilterByTime = new DevExpress.XtraEditors.SimpleButton();
            this.de_end = new DevExpress.XtraEditors.DateEdit();
            this.de_begin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lc3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ClearRecords = new DevExpress.XtraEditors.SimpleButton();
            this.btn_TrimRepeat = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_ErrorLog2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ReadRecordCurProject = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Path = new DevExpress.XtraEditors.SimpleButton();
            this.txt_FilePath = new DevExpress.XtraEditors.TextEdit();
            this.cb_projects = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_projects.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1108, 482);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lbl_Log);
            this.xtraTabPage1.Controls.Add(this.btn_TargetFolder);
            this.xtraTabPage1.Controls.Add(this.btn_Clear);
            this.xtraTabPage1.Controls.Add(this.btn_Filter);
            this.xtraTabPage1.Controls.Add(this.btn_AddAll);
            this.xtraTabPage1.Controls.Add(this.btn_AllProjectFiles);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btn_CurFiles);
            this.xtraTabPage1.Controls.Add(this.btn_OpenFolder);
            this.xtraTabPage1.Controls.Add(this.btn_Open);
            this.xtraTabPage1.Controls.Add(this.btn_Add);
            this.xtraTabPage1.Controls.Add(this.btn_Browse);
            this.xtraTabPage1.Controls.Add(this.tb_Path);
            this.xtraTabPage1.Controls.Add(this.listView2);
            this.xtraTabPage1.Controls.Add(this.button2);
            this.xtraTabPage1.Controls.Add(this.button1);
            this.xtraTabPage1.Controls.Add(this.textBox1);
            this.xtraTabPage1.Controls.Add(this.listView1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1099, 450);
            this.xtraTabPage1.Text = "项目文件浏览";
            // 
            // lbl_Log
            // 
            this.lbl_Log.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_Log.Appearance.Options.UseForeColor = true;
            this.lbl_Log.Location = new System.Drawing.Point(627, 426);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(0, 14);
            this.lbl_Log.TabIndex = 35;
            this.lbl_Log.Visible = false;
            // 
            // btn_TargetFolder
            // 
            this.btn_TargetFolder.Location = new System.Drawing.Point(627, 309);
            this.btn_TargetFolder.Name = "btn_TargetFolder";
            this.btn_TargetFolder.Size = new System.Drawing.Size(75, 21);
            this.btn_TargetFolder.TabIndex = 34;
            this.btn_TargetFolder.Text = "目标目录";
            this.btn_TargetFolder.Click += new System.EventHandler(this.btn_TargetFolder_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(627, 195);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 21);
            this.btn_Clear.TabIndex = 33;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(533, 6);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 21);
            this.btn_Filter.TabIndex = 32;
            this.btn_Filter.Text = "过滤";
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_AddAll
            // 
            this.btn_AddAll.Location = new System.Drawing.Point(627, 168);
            this.btn_AddAll.Name = "btn_AddAll";
            this.btn_AddAll.Size = new System.Drawing.Size(75, 21);
            this.btn_AddAll.TabIndex = 31;
            this.btn_AddAll.Text = "ALL->";
            this.btn_AddAll.Click += new System.EventHandler(this.btn_AddAll_Click);
            // 
            // btn_AllProjectFiles
            // 
            this.btn_AllProjectFiles.Location = new System.Drawing.Point(627, 78);
            this.btn_AllProjectFiles.Name = "btn_AllProjectFiles";
            this.btn_AllProjectFiles.Size = new System.Drawing.Size(75, 21);
            this.btn_AllProjectFiles.TabIndex = 30;
            this.btn_AllProjectFiles.Text = "所有文档";
            this.btn_AllProjectFiles.Click += new System.EventHandler(this.btn_AllProjectFiles_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(722, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "待保存的项目";
            // 
            // btn_CurFiles
            // 
            this.btn_CurFiles.Location = new System.Drawing.Point(627, 51);
            this.btn_CurFiles.Name = "btn_CurFiles";
            this.btn_CurFiles.Size = new System.Drawing.Size(75, 21);
            this.btn_CurFiles.TabIndex = 28;
            this.btn_CurFiles.Text = "当前文档";
            this.btn_CurFiles.Click += new System.EventHandler(this.btn_CurFiles_Click);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.Location = new System.Drawing.Point(627, 282);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(75, 21);
            this.btn_OpenFolder.TabIndex = 27;
            this.btn_OpenFolder.Text = "文件目录";
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(627, 243);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 21);
            this.btn_Open.TabIndex = 26;
            this.btn_Open.Text = "打开";
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(627, 141);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 21);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "->";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(490, 425);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 21);
            this.btn_Browse.TabIndex = 24;
            this.btn_Browse.Text = "浏览";
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(6, 425);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(464, 21);
            this.tb_Path.TabIndex = 23;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(722, 31);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(352, 387);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件名";
            this.columnHeader3.Width = 201;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "项目";
            this.columnHeader4.Width = 230;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(1020, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 21;
            this.button2.Text = "关闭";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(939, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "复制";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 21);
            this.textBox1.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 387);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 373;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "项目";
            this.columnHeader2.Width = 230;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.cb_projects);
            this.xtraTabPage2.Controls.Add(this.btn_LookUpInProject);
            this.xtraTabPage2.Controls.Add(this.btn_Cancel);
            this.xtraTabPage2.Controls.Add(this.btn_FilterByTime);
            this.xtraTabPage2.Controls.Add(this.de_end);
            this.xtraTabPage2.Controls.Add(this.de_begin);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.lc3);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Controls.Add(this.btn_ClearRecords);
            this.xtraTabPage2.Controls.Add(this.btn_TrimRepeat);
            this.xtraTabPage2.Controls.Add(this.lbl_ErrorLog2);
            this.xtraTabPage2.Controls.Add(this.btn_ReadRecordCurProject);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.btn_Path);
            this.xtraTabPage2.Controls.Add(this.txt_FilePath);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1099, 450);
            this.xtraTabPage2.Text = "文件保存记录";
            // 
            // btn_LookUpInProject
            // 
            this.btn_LookUpInProject.Location = new System.Drawing.Point(949, 166);
            this.btn_LookUpInProject.Name = "btn_LookUpInProject";
            this.btn_LookUpInProject.Size = new System.Drawing.Size(144, 23);
            this.btn_LookUpInProject.TabIndex = 51;
            this.btn_LookUpInProject.Text = "在工程中查找选中项";
            this.btn_LookUpInProject.Click += new System.EventHandler(this.btn_LookUpInProject_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1018, 424);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 50;
            this.btn_Cancel.Text = "关闭";
            this.btn_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_FilterByTime
            // 
            this.btn_FilterByTime.Location = new System.Drawing.Point(949, 123);
            this.btn_FilterByTime.Name = "btn_FilterByTime";
            this.btn_FilterByTime.Size = new System.Drawing.Size(144, 23);
            this.btn_FilterByTime.TabIndex = 49;
            this.btn_FilterByTime.Text = "按时间过滤";
            this.btn_FilterByTime.Click += new System.EventHandler(this.btn_FilterByTime_Click);
            // 
            // de_end
            // 
            this.de_end.EditValue = new System.DateTime(2015, 8, 26, 17, 12, 23, 235);
            this.de_end.Location = new System.Drawing.Point(843, 426);
            this.de_end.Name = "de_end";
            this.de_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_end.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_end.Size = new System.Drawing.Size(100, 21);
            this.de_end.TabIndex = 48;
            // 
            // de_begin
            // 
            this.de_begin.EditValue = new System.DateTime(2015, 8, 26, 17, 12, 8, 841);
            this.de_begin.Location = new System.Drawing.Point(665, 426);
            this.de_begin.Name = "de_begin";
            this.de_begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_begin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_begin.Size = new System.Drawing.Size(100, 21);
            this.de_begin.TabIndex = 47;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(789, 430);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "终止时间";
            // 
            // lc3
            // 
            this.lc3.Location = new System.Drawing.Point(610, 430);
            this.lc3.Name = "lc3";
            this.lc3.Size = new System.Drawing.Size(48, 14);
            this.lc3.TabIndex = 45;
            this.lc3.Text = "起始时间";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(-3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(946, 415);
            this.gridControl1.TabIndex = 42;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "文件名";
            this.gridColumn1.FieldName = "FileName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 308;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "项目";
            this.gridColumn2.FieldName = "Project";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 174;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "修改时间";
            this.gridColumn3.FieldName = "SaveTime";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 443;
            // 
            // btn_ClearRecords
            // 
            this.btn_ClearRecords.Location = new System.Drawing.Point(949, 365);
            this.btn_ClearRecords.Name = "btn_ClearRecords";
            this.btn_ClearRecords.Size = new System.Drawing.Size(144, 23);
            this.btn_ClearRecords.TabIndex = 41;
            this.btn_ClearRecords.Text = "清除记录";
            this.btn_ClearRecords.Click += new System.EventHandler(this.btn_ClearRecords_Click);
            // 
            // btn_TrimRepeat
            // 
            this.btn_TrimRepeat.Location = new System.Drawing.Point(949, 77);
            this.btn_TrimRepeat.Name = "btn_TrimRepeat";
            this.btn_TrimRepeat.Size = new System.Drawing.Size(144, 23);
            this.btn_TrimRepeat.TabIndex = 40;
            this.btn_TrimRepeat.Text = "去除重复";
            this.btn_TrimRepeat.Click += new System.EventHandler(this.btn_TrimRepeat_Click);
            // 
            // lbl_ErrorLog2
            // 
            this.lbl_ErrorLog2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorLog2.Appearance.Options.UseForeColor = true;
            this.lbl_ErrorLog2.Location = new System.Drawing.Point(949, 404);
            this.lbl_ErrorLog2.Name = "lbl_ErrorLog2";
            this.lbl_ErrorLog2.Size = new System.Drawing.Size(0, 14);
            this.lbl_ErrorLog2.TabIndex = 39;
            this.lbl_ErrorLog2.Visible = false;
            // 
            // btn_ReadRecordCurProject
            // 
            this.btn_ReadRecordCurProject.Location = new System.Drawing.Point(949, 36);
            this.btn_ReadRecordCurProject.Name = "btn_ReadRecordCurProject";
            this.btn_ReadRecordCurProject.Size = new System.Drawing.Size(144, 23);
            this.btn_ReadRecordCurProject.TabIndex = 38;
            this.btn_ReadRecordCurProject.Text = "读取记录";
            this.btn_ReadRecordCurProject.Click += new System.EventHandler(this.btn_ReadRecordCurProject_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 429);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "记录文件地址";
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(487, 424);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(88, 23);
            this.btn_Path.TabIndex = 3;
            this.btn_Path.Text = "浏览";
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Enabled = false;
            this.txt_FilePath.Location = new System.Drawing.Point(91, 426);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(379, 21);
            this.txt_FilePath.TabIndex = 2;
            // 
            // cb_projects
            // 
            this.cb_projects.Location = new System.Drawing.Point(949, 3);
            this.cb_projects.Name = "cb_projects";
            this.cb_projects.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_projects.Size = new System.Drawing.Size(147, 21);
            this.cb_projects.TabIndex = 52;
            // 
            // ListFileDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 482);
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ListFileDlg";
            this.Text = "文件复制";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_projects.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl lbl_Log;
        private System.Windows.Forms.Button btn_TargetFolder;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_AddAll;
        private System.Windows.Forms.Button btn_AllProjectFiles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btn_CurFiles;
        private System.Windows.Forms.Button btn_OpenFolder;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Path;
        private DevExpress.XtraEditors.TextEdit txt_FilePath;
        private DevExpress.XtraEditors.SimpleButton btn_ReadRecordCurProject;
        private DevExpress.XtraEditors.LabelControl lbl_ErrorLog2;
        private DevExpress.XtraEditors.SimpleButton btn_TrimRepeat;
        private DevExpress.XtraEditors.SimpleButton btn_ClearRecords;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lc3;
        private DevExpress.XtraEditors.DateEdit de_end;
        private DevExpress.XtraEditors.DateEdit de_begin;
        private DevExpress.XtraEditors.SimpleButton btn_FilterByTime;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_LookUpInProject;
        private DevExpress.XtraEditors.ComboBoxEdit cb_projects;


    }
}

