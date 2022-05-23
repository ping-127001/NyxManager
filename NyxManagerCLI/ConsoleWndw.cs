using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NyxManagerCLI.Handler;
using NyxManagerCLI.Handler.Plugins;

namespace NyxManagerCLI
{
    public static class ConsoleWndw
    {
        static void Main(string[] args)
        {
            Startup();
            Options();
        }

        public static void Startup()
        {
            Discord.Start();
            Console.Title = $"Nyx Manager CLI | {Application.ProductVersion}";
            Console.BufferWidth = Console.WindowWidth = 110;
            Console.BufferHeight = Console.WindowHeight = 28;
            WindowUtility.MoveWindowToCenter();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }

        public static void Options()
        {
            Console.Clear();
            ascii();
            Console.WriteLine();
            Writer.optionsWriter("Download");
            Writer.optionsWriter("Repair");
            Writer.optionsWriter("Plugins");
            Writer.optionsWriter("Exit");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();

                Console.WriteLine("Please select a folder to download Nyx to");
                var dir = Console.ReadLine();
                fstream.CheckFolderExist(dir);
                if (fstream.FolderExists)
                {
                    Net.DownloadFile("https://raw.githubusercontent.com/ping-127001/NyxManager/main/NyxManagerCLI/App/App.config", dir + $"Nyx.zip");

                    Console.WriteLine();
                    Console.WriteLine("Downloading Nyx in the background");
                    Writer.resetOptions();
                    Console.WriteLine("");
                    Writer.optionsWriter("Menu");

                    Writer.resetOptions();
                    input = Console.ReadLine();
                    Options();
                }
                else if (!fstream.FolderExists)
                {
                    Console.Clear();
                    Console.WriteLine($"Download failed, {dir} does not exist");

                    Writer.resetOptions();
                    Console.WriteLine("");
                    Writer.optionsWriter("Menu");

                    Writer.resetOptions();
                    input = Console.ReadLine();
                    Options();
                }
            }

            if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("Nyx Folder Location");
                Writer.resetOptions();

                var dir = Console.ReadLine();

                fstream.CheckFolderExist(dir);
                if (fstream.FolderExists)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Reparing Nyx");
                    Console.WriteLine("");
                    Writer.optionsWriter("Menu");
                    Writer.resetOptions();
                    input = Console.ReadLine();
                    Options();
                }
                else
                {

                    Console.WriteLine("Folder path does not exist");
                    Writer.optionsWriter("Menu");
                    Writer.resetOptions();
                    input = Console.ReadLine();
                    Options();
                }
            }

            if (input == "3")
            {
                LoadPlugins();
            }

            if (input == "4")
            {
                Environment.Exit(0);
            }

            if (input != "1" | input != "2" | input != "3" | input != "4")
            {
                Writer.resetOptions();
                Options();
            }
        }

        public static void LoadPlugins()
        {
            try
            {
                Console.Clear();
                PluginLoader loader = new PluginLoader();
                loader.LoadPlugins();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            while (true)
            {
                try
                {
                    //let the user fill in an plugin name
                    Console.WriteLine("input the name of the plugin you would like to load");
                    string line = System.Console.ReadLine();
                    string name = line.Split(new char[] { ' ' }).FirstOrDefault();
                    if (line == "exit")
                    {
                        Environment.Exit(0);
                    }
                    IPlugin plugin = PluginLoader.Plugins.Where(p => p.Name == name).FirstOrDefault();
                    if (plugin != null)
                    {
                        //If the plugin is found, execute it
                        string parameters = line.Replace(string.Format("{0} ", name), string.Empty);
                        plugin.Run(parameters);
                    }
                    else
                    {
                        Console.WriteLine(string.Format("No plugin found with name '{0}'", name));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("Caught exception: {0}", e.Message));
                }
            }
        }

        public static void ascii()
        {
            Console.WriteLine("           ▄▀▀▄ ▀▄  ▄▀▀▄ ▀▀▄  ▄▀▀▄  ▄▀▄      ▄▀▀▄ ▄▀▄  ▄▀▀█▄   ▄▀▀▄ ▀▄  ▄▀▀█▄   ▄▀▀▀▀▄   ▄▀▀█▄▄▄▄  ▄▀▀▄▀▀▀▄");
            Console.WriteLine("          █  █ █ █ █   ▀▄ ▄▀ █    █   █     █  █ ▀  █ ▐ ▄▀ ▀▄ █  █ █ █ ▐ ▄▀ ▀▄ █        ▐  ▄▀   ▐ █   █   █");
            Console.WriteLine("          ▐  █  ▀█ ▐     █   ▐     ▀▄▀      ▐  █    █   █▄▄▄█ ▐  █  ▀█   █▄▄▄█ █    ▀▄▄   █▄▄▄▄▄  ▐  █▀▀█▀");
            Console.WriteLine("            █   █        █        ▄▀ █        █    █   ▄▀   █   █   █   ▄▀   █ █     █ █  █    ▌   ▄▀    █ ");
            Console.WriteLine("          ▄▀   █       ▄▀        █  ▄▀      ▄▀   ▄▀   █   ▄▀  ▄▀   █   █   ▄▀  ▐▀▄▄▄▄▀ ▐ ▄▀▄▄▄▄   █     █");
            Console.WriteLine("          █    ▐       █       ▄▀  ▄▀       █    █    ▐   ▐   █    ▐   ▐   ▐   ▐         █    ▐   ▐     ▐ ");
            Console.WriteLine("          ▐            ▐      █    ▐        ▐    ▐            ▐                          ▐                  ");
        }

        public interface IPlugin
        {
            string Name { get; }
            string Explanation { get; }
            void Run(string parameters);
        }
    }
}
