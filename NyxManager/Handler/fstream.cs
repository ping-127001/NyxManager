using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxManager.Handler
{
    internal class fstream
    {
        public static bool FolderExists;
        public static bool FileExists;

        public static void CheckFolderExist(string path)
        {
            try
            {
                bool exists = Directory.Exists(path);
                if (!exists)
                {
                    //the user could now do a check like
                    /*
                     * if (FolderExists)
                     * {
                     *   code here
                     *  }
                     *  else
                     *  {
                     *  
                     *  }
                    */
                    FolderExists = false;
                }
                else if (exists)
                {
                    FolderExists = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void CheckFileExist(string path)
        {
            try
            {
                bool exists = File.Exists(path);
                if (!exists)
                {
                    FileExists = false;
                }
                else if (exists)
                {
                    FileExists = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void OpenFile(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void WriteFile(string path, string data)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter writer = File.CreateText(path))
                    {
                        writer.WriteLine(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing {data} to {path}, {ex.Message}", Application.ProductName);
            }
        }

        public static void RenameFile(string currentname, string newname)
        {
            try
            {
                System.IO.File.Move($"{currentname}", $"{newname}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
