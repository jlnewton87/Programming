using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComputer
{
    public class Computer{
        public string ComputerName;
        public string Architecture;
        public string UserName;
        public Computer(){
            ComputerName = Environment.GetEnvironmentVariable("computername");
            Architecture = Environment.GetEnvironmentVariable("processor_architecture");
            UserName = Environment.GetEnvironmentVariable("username");
        }
        public string OSVersion()
        {
            // Get OperatingSystem information from the system namespace.
            System.OperatingSystem osInfo = System.Environment.OSVersion;

            // Determine the platform.
            switch (osInfo.Platform)
            {
                // Platform is Windows 95, Windows 98, 
                // Windows 98 Second Edition, or Windows Me.
                case System.PlatformID.Win32Windows:

                    switch (osInfo.Version.Minor)
                    {
                        case 0:
                            return "Windows 95";
                            break;
                        case 10:
                            if (osInfo.Version.Revision.ToString() == "2222A")
                                return "Windows 98 Second Edition";
                            else
                                return "Windows 98";
                            break;
                        case 90:
                            return "Windows Me";
                            break;
                    }
                    break;

                // Platform is Windows NT 3.51, Windows NT 4.0, Windows 2000,
                // or Windows XP.
                case System.PlatformID.Win32NT:

                    switch (osInfo.Version.Major)
                    {
                        case 3:
                            return "Windows NT 3.51";
                            break;
                        case 4:
                            return "Windows NT 4.0";
                            break;
                        case 5:
                            if (osInfo.Version.Minor == 0)
                                return "Windows 2000";
                            else
                                return "Windows XP";
                            break;
                    } 
                default: return "Windows 7";
            }
        }
    }
}
