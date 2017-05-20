using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using Platform = MobileAutomationWithAppium.Utility.Platform;

namespace MobileAutomationWithAppium
{
    class AppInitializer
    {

        public static IWebDriver StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                DesiredCapabilities capabilities = new DesiredCapabilities();
                capabilities.SetCapability("device", "Android");
                capabilities.SetCapability(CapabilityType.Platform, "Windows");
                capabilities.SetCapability("deviceName", "Galaxy S6 edge");
                capabilities.SetCapability("platformName", "Android");
                capabilities.SetCapability("platformVersion", "6.0.1");
                capabilities.SetCapability("appPackage", "test10.test10");
                capabilities.SetCapability("appActivity", "md57660886635b9898004fb0a662bff702b.SplashScreenActivity");
                
                return new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            }

            return null;
            // The same for iOS
        }

        public static void InitializeScreens(Platform platform)
        {
            if (platform == Platform.Android)
            {
                FeatureContext.Current.Add(ScreenNames.MainMenu, new AndroidMainMenuScreen());
                FeatureContext.Current.Add(ScreenNames.AddTask, new AndroidAddTaskScreen());
            }
            else if (platform == Platform.iOS)
            {
                FeatureContext.Current.Add(ScreenNames.MainMenu, new iOSMainMenuScreen());
                FeatureContext.Current.Add(ScreenNames.AddTask, new iOSAddTaskScreen());
            }
        }

    }
}
