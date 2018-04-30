using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceToolkit
{
    class Program
    {
        static void Main(string[] args)
        {
            string serviceName = "notepad";
            int timeoutMilliseconds = 1000;
            WinServiceUtil.StartService(serviceName, timeoutMilliseconds);
            WinServiceUtil.IsServiceInstalled(serviceName);
            WinServiceUtil.StopService(serviceName, timeoutMilliseconds);
            WinServiceUtil.RestartService(serviceName, timeoutMilliseconds);
        }
    }
}
