using System;
using TechTalk.SpecFlow;
using System.Diagnostics;
using SpecflowTests.PageObject;

namespace SpecflowTests.Steps
{
    [Binding]
    public class SignUpWithInvalidEmailAddressSteps : Start
    {
        [Given(@"Open the gmail signup page")]
        public void GivenOpenTheGmailSignupPage()
        {
            Debug.WriteLine("Step 1: Gmail sign up page should be open");
        }
        
        [When(@"I enter valid first, last name and invalid email address")]
        public void WhenIEnterValidFirstLastNameAndInvalidEmailAddress()
        {
            Debug.WriteLine("Step 2: Enter valid first and last Name but invalid email");
            Gmail.TypeFirstName();
            Gmail.TypeLastName();
            Gmail.TypeInvalidGmailAddress();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Then(@"I click on Next Step button")]
        public void ThenIClickOnNextStepButton()
        {
            Debug.WriteLine("Step 3: Click on Next Steup button");
            Gmail.ClickNextStepButton();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Then(@"I should see inline validation message for email")]
        public void ThenIShouldSeeInlineValidationMessageForEmail()
        {
            Debug.WriteLine("Step 4: Assert the email error message");
            Gmail.AssertInvalidEmailErrorMsg();
        }


    }
}
