using System;
using OpenQA.Selenium;

namespace MobileAutomationWithAppium
{
    public class AndroidAddTaskScreen : IAddTaskScreen
    {
        public Func<IWebDriver, IWebElement> ConfirmBtn { get; } = c => c.FindElement(By.Id("AddItemPage_AddButton"));
        public Func<IWebDriver, IWebElement> TitleTxt { get; } = c => c.FindElement(By.Id("AddItemPage_TitleTxtField"));
    }
}
