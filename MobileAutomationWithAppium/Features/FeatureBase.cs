using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Platform = MobileAutomationWithAppium.Utility.Platform;

namespace MobileAutomationWithAppium
{
    // You can comment one out to test just a single platform
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class FeatureBase
    {

        protected static IWebDriver app;
        protected Platform platform;

        public FeatureBase(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {

            app = AppInitializer.StartApp(platform);

            if (!FeatureContext.Current.ContainsKey("App"))
            {
                FeatureContext.Current.Add("App", app);
                AppInitializer.InitializeScreens(platform);
            }


        }

        [TearDown]
        public void AfterEachTest()
        {
            app.Quit();
        }

    }
}
