using System;
using OpenQA.Selenium;

namespace MobileAutomationWithAppium
{
    public class AndroidMainMenuScreen : IMainMenuScreen
    {
        public Func<IWebDriver, IWebElement> AddButton { get; } = c => c.FindElement(By.Id("AddItemButton"));
        public Func<IWebDriver, IWebElement> TaskTitle { get; } = c => c.FindElement(By.Id("TaskTitle"));
    }
}
