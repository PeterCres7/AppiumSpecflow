using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MobileAutomationWithAppium
{
    [Binding]
    public class MainMenuSteps : StepBase
    {

        [Given(@"I am in the main menu")]
        public void GivenIAmInTheMainMenu()
        {
            // Wait to see the button
            MainMenuScreen.AddButton(app);
        }

        [When(@"I tap the add button")]
        public void WhenITapTheAddButton()
        {
            MainMenuScreen.AddButton(app).Click();
        }

        [When(@"I add a task")]
        public void WhenIAddATask()
        {
            // Wait to see the button so you know you're on the page
            AddTaskScreen.ConfirmBtn(app);

            // We Inherit that from StepBase and we can use it in any step class 
            InputText(AddTaskScreen.ConfirmBtn, "My Task");

            AddTaskScreen.ConfirmBtn(app).Click();
        }

        [Then(@"I can see the task displayed")]
        public void ThenICanSeeTheTaskDisplayed()
        {
            // We can see that we have created a task
            MainMenuScreen.TaskTitle(app);
        }

    }
}
