using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MobileAutomationWithAppium
{
    [Binding]
    public class CommonSteps
    {

        readonly IWebDriver app;
        readonly IMainMenuScreen MainMenu;


        readonly StepBase _stepBase;


        public CommonSteps()
        {
            app = FeatureContext.Current.Get<IWebDriver>("App");
            MainMenu = FeatureContext.Current.Get<IMainMenuScreen>(ScreenNames.MainMenu);

            _stepBase = new StepBase();
        }


        [Given(@"I have accessed the application")]
        public void GivenIHaveAccessedTheApplication()
        {

        }

    }
}
