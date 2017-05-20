using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MobileAutomationWithAppium
{
    public class StepBase
    {
        protected readonly IWebDriver app;
        protected readonly IMainMenuScreen MainMenuScreen;
        protected readonly IAddTaskScreen AddTaskScreen;


        public StepBase()
        {
            app = FeatureContext.Current.Get<IWebDriver>("App");
            MainMenuScreen = FeatureContext.Current.Get<IMainMenuScreen>(ScreenNames.MainMenu);
            AddTaskScreen = FeatureContext.Current.Get<IAddTaskScreen>(ScreenNames.AddTask);
        }

        // Convenience methods to reuse

        public void InputText(Func<IWebDriver, IWebElement> Element, string text)
        {
            Element(app).Click();
            Element(app).SendKeys(text);
        }

    }
}
