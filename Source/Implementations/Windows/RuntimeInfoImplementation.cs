using Galifrei.Core;
using Galifrei.Core.Interfaces;
using Galifrei.Core.Platforming;
using Microsoft.Win32;
using System.Linq;

namespace Galifrei.Implementations.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class RuntimeInfoImplementation : IRuntimeInfo
    {
        public bool IsApplicationInstalled(Core.SetupContext context)
        {
            string displayName;
            string c_name = context.Properties[NamingConstants.AppName].ToString();

            var registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return true;
                    }
                }
                key.Close();
            }

            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return true;
                    }
                }
                key.Close();
            }
            return false;
        }
    }
}