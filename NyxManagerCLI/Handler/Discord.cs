using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace NyxManagerCLI.Handler
{
    internal class Discord
    {
        public static DiscordRpcClient client;

        public static void Start()
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("Discord");
                if (processes.Length == 0)
                {

                    return;
                }
                else
                {
                    client = new DiscordRpcClient("978072526477459506");
                    client.Initialize();
                    client.SetPresence(new RichPresence()
                    {
                        Details = $"Nyx Manager",
                        State = $"Managing Nyx",
                        Assets = new Assets()
                        {
                            LargeImageKey = "nyx",
                            LargeImageText = "https://github.com/ping-127001/Nyx",
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured, Error:{ex.Message}");
            }
        }

        public static void Update(string details, string state)
        {
            try
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{details}",
                    State = $"{state}",
                    Assets = new Assets()
                    {
                        LargeImageKey = "nyx",
                        LargeImageText = "https://github.com/ping-127001/Nyx",
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured, Error:{ex.Message}");
            }
        }
    }
}
