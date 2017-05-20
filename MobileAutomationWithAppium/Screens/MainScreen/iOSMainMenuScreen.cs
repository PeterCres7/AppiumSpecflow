using System;
using OpenQA.Selenium;

namespace MobileAutomationWithAppium
{
    public class iOSMainMenuScreen : IMainMenuScreen
    {
        public Func<IWebDriver, IWebElement> AddButton { get; }
        public Func<IWebDriver, IWebElement> ConfirmBtn { get; }
        public Func<IWebDriver, IWebElement> TitleTxt { get; }
        public Func<IWebDriver, IWebElement> TaskTitle { get; }
    }
}
