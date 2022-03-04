using Microsoft.Win32;

namespace VpnReconnector
{
    internal class RegistryClass
    {
        public static void RegWrite(string subKey, string key, string value)
        {
            RegistryKey currentUserKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey registryKey = currentUserKey.CreateSubKey(subKey);
            registryKey.SetValue(key, value);
            registryKey.Close();
        }

        public static string RegRead(string subKey, string key)
        {
            string value = String.Empty;
            RegistryKey currentUserKey = Registry.CurrentUser.OpenSubKey("Software", false);
            {
                if (currentUserKey != null)
                {
                    RegistryKey programKey = currentUserKey.OpenSubKey(subKey, false);
                    {
                        if (programKey != null)
                        {
                            var valueKey = programKey.GetValue(key);
                            if (valueKey != null)
                            {
                                value = valueKey.ToString();
                            }
                        }
                    }
                }
            }
            return value;
        }
    }    
}
