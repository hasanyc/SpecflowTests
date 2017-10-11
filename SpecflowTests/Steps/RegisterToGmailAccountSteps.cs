using System;
using TechTalk.SpecFlow;
using System.Diagnostics;
using SpecflowTests.PageObject;
namespace SpecflowTests.Steps
{
    [Binding]
    public class RegisterToGmailAccountSteps
    {
        [Given(@"Open the gmail sign up page")]
        public void GivenOpenTheGmailSignUpPage()
        {
            Debug.WriteLine("Step 1: Gmail sign up page should be open");

        }

        [When(@"I sign up with valid details")]
        public void WhenISignUpWithValidDetails()
        {
            Debug.WriteLine("Step 2: Fill out the entire form and click on Next Step button");
            Gmail.TypeFirstName();
            Gmail.TypeLastName();
            Gmail.TypeGmailAddress("hb"+ DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss"));
            Gmail.TypePassword();
            Gmail.TypePasswordAgain();
            Gmail.EnterDD();
            Gmail.EnterMM();
            Gmail.EnterYYYY();
            Gmail.EnterGender();
            Gmail.EnterPhoneNum();
            System.Threading.Thread.Sleep(1000);
            Gmail.ClickNextStepButton();
            System.Threading.Thread.Sleep(2000);


        }

        [Then(@"I agree the Privacy and Terms")]
        public void ThenIAgreeThePrivacyAndTerms()
        {
            Debug.WriteLine("Step 3: Agree the Tearms and Condition");
            Gmail.ScrollDown();
            System.Threading.Thread.Sleep(1000);
            Gmail.ClickOnIagreeButton();
        }

        [Then(@"I should see a peronalized greeting message")]
        public void ThenIShouldSeeAPeronalizedGreetingMessage()
        {
            Debug.WriteLine("Step 4: Assert the greeting message");
            // Sorry could not finish the sign up due to mobile verification

        }
    }
}