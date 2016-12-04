using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EcoSystem
{
    class INI_Manager
    {
        List<string> iniPathList = new List<string>();
        List<INIFile> iniFileList = new List<INIFile>();

        public INI_Manager()
        {
            GetINIPaths();
            LoadINIFiles();
        }

        public INIFile GetFile(string fileName)
        {
            foreach(INIFile tmpFile in iniFileList)
            {
                if (tmpFile.INIFileName == fileName)
                    return tmpFile;
            }

            return null;
        }

        private void GetINIPaths()
        {
            string exeFolderPath;
            //Get path to exe folder
            //exeFolderPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            exeFolderPath = AppDomain.CurrentDomain.BaseDirectory;

            //Get the full path to all ini files
            string[] iniFileList = Directory.GetFiles(exeFolderPath);
            foreach (string iniFilePath in iniFileList)
            {
                if (iniFilePath.EndsWith("ini"))
                {
                    iniPathList.Add(iniFilePath);
                }
            }

        }

        private void LoadINIFiles()
        {
            foreach (string iniFilePath in iniPathList)
            {
                INIFile loadFile = new INIFile();
                iniFileList.Add(loadFile.LoadINIFile(iniFilePath));
            }
        }

    }

    class INIFile
    {
        string iniFileName;
        List<string> nameList = new List<string>();
        List<string> valueList = new List<string>();

        public string INIFileName { get { return iniFileName; } set { iniFileName = value; } }

        public void AddNameValuePair(string Name, string Value)
        {
            nameList.Add(Name);
            valueList.Add(Value);
        }

        public string GetValueFromName(string Name, int Number)
        {
            int numberCounter = 0;
            for (int counter=0; counter < nameList.Count; counter++)
            {
                if (nameList[counter] == Name)
                    numberCounter += 1;
                if (numberCounter == Number)
                    return valueList[counter];
            }
            return null;
        }


        public INIFile LoadINIFile(string iniFilePath)
        {
            INIFile iniFile = new INIFile();
            iniFile.iniFileName = iniFilePath.Substring(iniFilePath.LastIndexOf("\\") + 1);

            String line;
            StreamReader sr = new StreamReader(iniFilePath);

            //Read the first line of text
            line = sr.ReadLine();

            //Continue to read until you reach end of file
            while (line != null)
            {
                iniFile.AddNameValuePair(NameVlaueFromLine("Name", line), NameVlaueFromLine("Value", line));
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();

            return iniFile;
            
        }

        private string NameVlaueFromLine(string NameValue, string Line)
        {
            string nameValue = "";

            if (NameValue == "Name")
            {
                nameValue = Line.Substring(0, Line.IndexOf("="));
            }
            else if (NameValue == "Value")
            {
                nameValue = Line.Substring(Line.IndexOf("=")+1);
            }

            return nameValue;
        }

    }
}
