using System;
using OpenQA.Selenium;

namespace MobileAutomationWithAppium
{
    public interface IMainMenuScreen
    {
        Func<IWebDriver, IWebElement> AddButton { get; }
        Func<IWebDriver, IWebElement> TaskTitle { get; }
    }
}
