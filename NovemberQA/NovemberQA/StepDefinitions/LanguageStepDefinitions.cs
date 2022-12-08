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
    public class LanguageStepDefinitions : CommonDriver
    {
        
        LanguagePage languagePageObj = new LanguagePage();


        [When(@"I add '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddAndToTheProfile(string languages, string level)
        {
            
            languagePageObj.AddLanguages(driver, languages, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be added successfully")]
        public void ThenTheAndShouldBeAddedSuccessfully(string languages, string level)
        {
            
            languagePageObj.NewLang(driver, languages, level);
            
        }

        [When(@"I edit Languages and Level to the profile")]
        public void WhenIEditLanguagesAndLevelToTheProfile()
        {
            languagePageObj.EditLanguages(driver);
        }

        [Then(@"The Languages and Level should be edited successfully")]
        public void ThenTheLanguagesAndLevelShouldBeEditedSuccessfully()
        {
            languagePageObj.EditedLang(driver);
        }

        [When(@"I delete Languages and Level from the profile")]
        public void WhenIDeleteLanguagesAndLevelFromTheProfile()
        {
            languagePageObj.DeleteLanguages(driver);
        }

        [Then(@"Languages and Level should be deleted successfully")]
        public void ThenLanguagesAndLevelShouldBeDeletedSuccessfully()
        {
            languagePageObj.DeletedLang(driver);
        }

    }
}