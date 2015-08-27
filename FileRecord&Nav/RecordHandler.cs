using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace FileModifyRecorder
{
    public class RecordHandler
    {
        string path;
        public string recordPath
        {
            get 
            {
                return path;
            }
            set 
            {
                path = value;
            }
        }

        XmlDocument recordDoc = new XmlDocument();
        XmlElement root;
        public RecordHandler(string xmlpath)
        {
            recordPath = xmlpath;
            if (File.Exists(xmlpath))
            {
                recordDoc.Load(xmlpath);
                root = recordDoc.DocumentElement;
                if (root == null)
                    NewRecord();
            }
            else
            {
                NewRecord();
            }
        }

        public void NewRecord()
        {
            

            if (File.Exists(path))
            {
                File.Copy(path, path + ".bak");
                File.Delete(path);
            }
            recordDoc = new XmlDocument();
            root = recordDoc.CreateElement("Record");
            recordDoc.AppendChild(root);

            recordDoc.Save(path);

        } 

        public bool SaveRecord(string Filename,DateTime time,string project)
        {
            XmlNodeList projectRecords = recordDoc.DocumentElement.GetElementsByTagName(project);
            XmlNode projectElement;
            if (projectRecords == null || projectRecords.Count == 0)
            {
                projectElement = recordDoc.CreateElement(project);
                recordDoc.DocumentElement.AppendChild(projectElement);
            }
            else
            {
                projectElement = projectRecords[0];
            }

            if (root != null)
            {
                XmlElement item = recordDoc.CreateElement("SavingFile");

                item.SetAttribute("FileName", Filename);
                item.SetAttribute("Time", time.ToString());
                item.SetAttribute("Project", project);
                projectElement.AppendChild(item);
                recordDoc.Save(path);
                return true;
            }
            return false;
                
        }

        public static string GetValueFromRegistry()
        {
            Microsoft.Win32.RegistryKey registryKey;
            string registryValue;

            registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\8.0", false);
            registryValue = (string)registryKey.GetValue("RecordFileSavePath", "");
           
            return registryValue;
        }

        public static void SetValueToRegistry(string value)
        {
            Microsoft.Win32.RegistryKey registryKey;
            string registryValue;

            registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\VisualStudio\8.0", true);
            registryValue = value;
            registryKey.SetValue("RecordFileSavePath", registryValue, Microsoft.Win32.RegistryValueKind.String);
        }

        public string ClearRecord(string project)
        {
            XmlNodeList projectRecords = recordDoc.DocumentElement.GetElementsByTagName(project);
            XmlNode projectElement;
            if (projectRecords == null || projectRecords.Count == 0)
            {
                return "找不到工程记录";
            }
            else
            {
                projectElement = projectRecords[0];
            }

            projectElement.RemoveAll();
            recordDoc.Save(path);
            return "成功清除工程记录";
        }
    }
}
