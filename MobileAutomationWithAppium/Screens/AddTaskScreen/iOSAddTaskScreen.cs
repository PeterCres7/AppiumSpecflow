using System;
using OpenQA.Selenium;

namespace MobileAutomationWithAppium
{
    public class iOSAddTaskScreen : IAddTaskScreen
    {
        public Func<IWebDriver, IWebElement> ConfirmBtn { get; }
        public Func<IWebDriver, IWebElement> TitleTxt { get; }
    }
}
