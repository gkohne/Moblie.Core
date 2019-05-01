using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Drivers
{
    public static class DisposeDriverService
    {
        private static readonly List<string> _processesToCheck =
            new List<string>
            {
                "chrome",
                "firefox",
                "ie",
                "gecko",
                "edge"
            };

        public static DateTime? TestRunStartTime { get; set; }

        public static void KillAllBrowsers(IWebDriver driver)
        {
            driver?.Dispose();

            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    if (process.StartTime > TestRunStartTime)
                    {
                        var shouldKill = false;
                        foreach (var processName in _processesToCheck)
                        {
                            if (process.ProcessName.ToLower().Contains(processName))
                            {
                                shouldKill = true;
                                break;
                            }
                        }
                        if (shouldKill)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
