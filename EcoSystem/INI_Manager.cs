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

        public INI_Manager()
        {
            GetINIPaths();
            LoadINIFiles();
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
                String line;
                StreamReader sr = new StreamReader("C:\\Sample.txt");

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
        }

        public string GetValueFromIndex(string Index)
        {
            return "";
        }
    }
}
