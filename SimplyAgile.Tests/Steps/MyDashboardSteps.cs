using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SimplyAgile.Tests.Steps
{
    [Binding]
    public class MyDashboardSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"I do not have any projects")]
        public void GivenIDoNotHaveAnyProjects()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I view my dashboard")]
        public void WhenIViewMyDashboard()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see directions on how to add a project instead of a any projects")]
        public void ThenIShouldSeeDirectionsOnHowToAddAProjectInsteadOfAAnyProjects()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
