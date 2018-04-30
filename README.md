# cs-windows-service-toolkit

Toolkit that provides convenient methods for .NET application to easily integrate background windows services 

# Install

```bash
Install-Package cs-windows-service-toolkit
```

# Usage

The sample code shows how to use this lib:

```cs
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

```
