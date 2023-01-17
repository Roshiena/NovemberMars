using NovemberQA.Pages;
using NovemberQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NovemberQA.StepDefinitions
{

    [Binding]

    public class CertificationStepDefinitions : CommonDriver

    {
        CertificationPage certificationPageObj;

        public CertificationStepDefinitions()
        {
            certificationPageObj = new CertificationPage();
        }

        [Given(@"I have navigated to Certification Page")]
        public void GivenIHaveNavigatedToCertificationPage()
        {
            certificationPageObj.NavigateToCertificationPage();
        }



        [When(@"I add '([^']*)', '([^']*)' and '([^']*)' to profile")]
        public void WhenIAddAndToProfile(string certificate, string certified, string year)
        {
            certificationPageObj.AddCertification(certificate, certified, year);
        }

        [Then(@"The '([^']*)', '([^']*)' and '([^']*)' should be added to the profile successfully")]
        public void ThenTheAndShouldBeAddedToTheProfileSuccessfully(string certificate, string certified, string year)
        {
            string newCertificate = certificationPageObj.GetCertificate();
            string newCertified = certificationPageObj.GetCertified();
            string newYear = certificationPageObj.GetYear();

            Assert.That(newCertificate == certificate, "Actual Certification and expected certification do not match");
            Assert.That(newCertified == certified, "Actual Certified and expected certified do not match");
            Assert.That(newYear  == year, "Actual year and expected year do not match");
        }

        [When(@"I edit '([^']*)', '([^']*)' and '([^']*)' to profile")]
        public void WhenIEditAndToProfile(string certificate, string certified, string year)
        {
            certificationPageObj.EditCertification(certificate, certified, year);
        }


        [Then(@"The '([^']*)', '([^']*)' and '([^']*)' should be edited to the profile successfully")]
        public void ThenTheAndShouldBeEditedToTheProfileSuccessfully(string certificate, string certified, string year)
        {
            string updatedCertificate = certificationPageObj.EditedCertificate();
            string updatedCertified = certificationPageObj.EditedCertified();
            string updatedYear = certificationPageObj.EditedYear();
            Assert.That(updatedCertificate == certificate, "Actual Cetification and expected certification do not match");
            Assert.That(updatedCertified == certified , "Actual Certified and expected certified do not match");
            Assert.That(updatedYear == year, "Actual year and expected year do not match");
        }


        [When(@"I delete Certification from the profile")]
        public void WhenIDeleteCertificationFromTheProfile()
        {
            certificationPageObj.DeleteCertification();
        }

        [Then(@"The Certification should be deleted from the profile successfully")]
        public void ThenTheCertificationShouldBeDeletedFromTheProfileSuccessfully()
        {
            string deletedCertification = certificationPageObj.DeletedCertificate();
            Assert.That(deletedCertification != "Certificate in Computer Applications", "Actual title and expected title do not match");

        }



    }
}












