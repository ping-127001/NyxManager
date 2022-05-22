using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NyxManagerCLI.ConsoleWndw;

namespace NyxManagerCLI.Handler.Plugins.Embedded
{
    internal class HelpPlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "help";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin shows all loaded plugins and their explanations";
            }
        }

        public void Run(string parameters)
        {
            foreach (IPlugin plugin in PluginLoader.Plugins)
            {
                Console.WriteLine("");
                Console.WriteLine("{0}: {1}", plugin.Name, plugin.Explanation);
            }
        }
    }
}
