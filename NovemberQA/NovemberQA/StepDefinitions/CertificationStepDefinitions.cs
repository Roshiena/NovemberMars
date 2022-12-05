using NovemberQA.Pages;
using NovemberQA.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NovemberQA.StepDefinitions
{

    [Binding]
    public class CertificationStepDefinitions : Driver
    {
        LoginPage loginPageObj = new LoginPage();
        CertificationPage certificationPageObj = new CertificationPage();

        [Given(@"I logged to portal successfully")]
        public void GivenILoggedToPortalSuccessfully()
        {
        
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I add '([^']*)', '([^']*)' and '([^']*)' to profile")]
        public void WhenIAddAndToProfile(string certificate, string certified, string year)
        {
            certificationPageObj.AddCertification(driver, certificate, certified, year);
        }

        [Then(@"The '([^']*)', '([^']*)' and '([^']*)' should be added to the profile successfully")]
        public void ThenTheAndShouldBeAddedToTheProfileSuccessfully(string certificate, string certified, string year)
        {
            certificationPageObj.NewCertification(driver, certificate, certified, year);
        }
    }
}

    

