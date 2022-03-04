using System;
using System.Management;

namespace VpnReconnector
{
    internal class MachineId
    {
        // Add NuGet "System.Management"

        public static string GetId()
        {
            //Win32_Processor ProcessorId
            //Win32_MotherboardDevice
            //Win32_BaseBoard SerialNumber
            //Win32_BIOS SerialNumber
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard");
            string mbInfo = String.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                mbInfo = mo["SerialNumber"].ToString();
                if (mbInfo == "Default string")
                    mbInfo = mo["Product"].ToString();
                //mbInfo = mo.Properties["SerialNumber"].Value.ToString();
            }
            return mbInfo;
        }
    }
}
