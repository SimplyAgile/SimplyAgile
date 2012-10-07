using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SimplyAgile.Tests.Steps
{
    [Binding]
    public class UserAthenticationSteps
    {
        [Given(@"I have (allowed|not allowed) my openAuth provider to share my information with SimplyAgile")]
        public void GivenIHaveAllowedMyOpenAuthProviderToShareMyInformationWithSimplyAgile(string isAllowed)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have not completed the registration process")]
        public void GivenIHaveNotCompletedTheRegistrationProcess()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I visit a page that requires authorization")]
        public void WhenIVisitAPageThatRequiresAuthorization()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I must be sent back into the registration process")]
        public void ThenIMustBeSentBackIntoTheRegistrationProcess()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"My account is in good standing")]
        public void GivenMyAccountIsInGoodStanding()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be directed to the correct page")]
        public void ThenIShouldBeDirectedToTheCorrectPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"My account is not in good standing")]
        public void GivenMyAccountIsNotInGoodStanding()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I must be sent to the account support page")]
        public void ThenIMustBeSentToTheAccountSupportPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I must be sent to the login page")]
        public void ThenIMustBeSentToTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I login without requesting a page")]
        public void WhenILoginWithtoutRequestingAPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be directed to my dashboard")]
        public void ThenIShouldBeDirectedToMyDashboard()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have successfully logged in")]
        public void GivenIHaveSuccessfullyLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
