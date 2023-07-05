using Microsoft.Win32;
using System;
using System.Management;
using System.Security.Principal;

namespace Advanced_Cooling_Control_Software
{
    public class SysInfo
    {
        private string sysInformation = "";

        public string GetSystemInfo()
        {
            LogOSVersionInfo();
            LogUserInfo();
            //LogSQLServerInfo();
            return sysInformation;
        }

        private void LogOSVersionInfo()
        {
            sysInformation += "--------------Operating System Info--------------" + Environment.NewLine;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                    sysInformation += Environment.NewLine + "OS Name  :  " + managementObject["Caption"].ToString();   //Display operating system caption

                if (managementObject["OSArchitecture"] != null)
                    sysInformation += Environment.NewLine + "Architecture  :  " + managementObject["OSArchitecture"].ToString();   //Display operating system architecture.

                if (managementObject["CSDVersion"] != null)
                    sysInformation += Environment.NewLine + "Service Pack   :  " + managementObject["CSDVersion"].ToString();     //Display operating system version.
            }

            GetProcessorInfo();
            sysInformation += Environment.NewLine + "--------------Operating System Info--------------";
        }

        private void GetProcessorInfo()
        {
            sysInformation += Environment.NewLine + "Processor Name...." + Environment.NewLine;
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if ((processor_name != null) && (processor_name.GetValue("ProcessorNameString") != null))
                sysInformation += Environment.NewLine + "Processor " + processor_name.GetValue("ProcessorNameString");   //Display processor info.
        }

        private void LogUserInfo()
        {
            sysInformation += Environment.NewLine + Environment.NewLine + "user system information:-";
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool bIsAdministrator = principal.IsInRole(WindowsBuiltInRole.Administrator);
            sysInformation += Environment.NewLine + "User Name: " + WindowsIdentity.GetCurrent().Name;
            sysInformation += Environment.NewLine + "Is Administrator? : " + (bIsAdministrator ? "Yes" : "No");
            sysInformation += Environment.NewLine + "-------------------------------------------------";
        }
    }
}
