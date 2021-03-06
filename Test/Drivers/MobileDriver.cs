﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using Test.Driver;
using static Test.Driver.DriverSelector;

namespace Test.Drivers
{
    public class MobileDriver
    {
        private AndroidDriver<IWebElement> _unique_instance;

        public static AndroidDriver<IWebElement> CreateAndriodDriver(string andriodType)
        {
            AndroidDriver<IWebElement> driver = null;

            //{"platform":"LINUX","webStorageEnabled":false,"takesScreenshot":true,"javascriptEnabled":true,"databaseEnabled":false,"networkConnectionEnabled":true,"locationContextEnabled":false,"warnings":{},
            //"desired":{"platformName":"Android","browserName":"Chrome","automationName":"UiAutomator2","deviceName":"x86_Pie_9_API_28"},
            //"platformName":"Android","browserName":"Chrome","automationName":"UiAutomator2","deviceName":"emulator-5554",
            //"appPackage":"com.android.chrome","appActivity":"com.google.android.apps.chrome.Main",
            //"deviceUDID":"emulator-5554","deviceApiLevel":28,"platformVersion":"9","deviceScreenSize":"1080x1920"
            //,"deviceScreenDensity":420,"deviceModel":"Android SDK built for x86","deviceManufacturer":"Google",
            //"pixelRatio":2.625,"statBarHeight":63,"viewportRect":{"left":0,"top":63,"width":1080,"height":1731}}}

            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("browserName", "Chrome");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");

            //AppiumLocalService appiumLocalService = AppiumLocalService.BuildDefaultService();
            //if (!appiumLocalService.IsRunning)
            //{
            //    appiumLocalService.Start();
            //}

            //AppiumLocalService _appiumLocalService = new AppiumServiceBuilder()
            //    .UsingAnyFreePort()
            //    .UsingDriverExecutable(new FileInfo("C:/Program Files/Appium/node.exe"))
            //    .WithAppiumJS(new FileInfo("C:/Program Files/Appium/node_modules/appium/bin/appium.js"))
            //    .Build();

            //_appiumLocalService.Start();

            switch (Enum.Parse<AndriodType>(andriodType))
            {
                case AndriodType.x86_Oreo_8_API_27:

                    appiumOptions.AddAdditionalCapability("deviceName", nameof(AndriodType.x86_Oreo_8_API_27));
                    break;

                case AndriodType.x86_Pie_9_API_28:

                    appiumOptions.AddAdditionalCapability("deviceName", nameof(AndriodType.x86_Pie_9_API_28));
                    break;
            }

            try
            {
                driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), appiumOptions);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return driver;
        }

        public AndroidDriver<IWebElement> Inst
        {
            get
            {
                if (_unique_instance == null)
                {
                    _unique_instance = DriverSelector.CreateAndriodDriver();
                }

                return _unique_instance;
            }
        }

        public AndroidDriver<IWebElement> Quit()
        {
            _unique_instance.Quit();

            return _unique_instance;
        }
    }
}
