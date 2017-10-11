using System;
using TechTalk.SpecFlow;
using System.Diagnostics;
using SpecflowTests.PageObject;
namespace SpecflowTests.Steps
{ 

namespace SpecflowTests
{
    [Binding]
    public class LoginToGmailAndThenLogoutFromGmailSteps
    {
        [Given(@"Open the gmail login page")]
        public void GivenOpenTheGmailLoginPage()
        {
            Debug.WriteLine("Step 1: Open the sign in page");
            Gmail.NavigateToURL(Url: ConstantsUtils.signInUrl);
            System.Threading.Thread.Sleep(1500);

            }

        [When(@"I Login with valid Credential")]
        public void WhenILoginWithValidCredential()
        {
                Debug.WriteLine("Step 2: Login to Gmail");
                Gmail.EnterEmailOrPhone();
                Gmail.ClickNextButtonAfterEnterUserName();
                System.Threading.Thread.Sleep(1000);
                Gmail.EnterPassword();
                Gmail.ClickNextButtonAfterEnterPassword();
                System.Threading.Thread.Sleep(3000);

            }

        [Then(@"I should click on Sign out Button")]
        public void ThenIShoulClickOnSignOutButton()
        {
                Debug.WriteLine("Step 3: Log out from Gmail");
                Gmail.ClickOnGmailLogo();
                System.Threading.Thread.Sleep(1000);
                Gmail.ClickOnMyAccountLogo();
                Gmail.ClickOnSignOutButton();
                System.Threading.Thread.Sleep(2000);
            }

        [Then(@"I should be successfully logout from gmail")]
        public void ThenIShouldBeSuccessfullyLogoutFromGamil()
        {
                Debug.WriteLine("Step 4: Verify if you logged out");
                Gmail.AssertSignOut();
            }
    }
}   
}