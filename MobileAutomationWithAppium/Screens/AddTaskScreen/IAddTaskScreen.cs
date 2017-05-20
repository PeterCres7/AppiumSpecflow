using System;
using OpenQA.Selenium;

namespace MobileAutomationWithAppium
{
    public interface IAddTaskScreen
    {
        Func<IWebDriver, IWebElement> ConfirmBtn { get; }
        Func<IWebDriver, IWebElement> TitleTxt { get; }
    }
}
