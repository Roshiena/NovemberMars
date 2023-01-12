using NovemberQA.Pages;
using NovemberQA.Utilities;
using NUnit.Framework;
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

        LanguagePage languagePageObj;

        public LanguageStepDefinitions()
        {
            languagePageObj= new LanguagePage();
        }


        [When(@"I add '([^']*)' and '([^']*)' to the profile")]
        public void WhenIAddAndToTheProfile(string languages, string level)
        {
            
            languagePageObj.AddLanguages(languages, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be added successfully")]
        public void ThenTheAndShouldBeAddedSuccessfully(string languages, string level)
        {

            string newLanguage = languagePageObj.GetLanguage();
            string newLevel = languagePageObj.GetLevel();

            Assert.That(newLanguage == languages, "Actual Language and expected language do not match");
            Assert.That(newLevel == level, "Actual Level and expected level do not match");

        }

        [When(@"I edit '([^']*)' and '([^']*)' to the profile")]
        public void WhenIEditAndToTheProfile(string languages, string level)
        {
            
            languagePageObj.EditLanguages(languages, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be edited successfully")]

        public void ThenTheAndShouldBeEditedSuccessfully(string languages, string level)
        {
            string updatedLanguage = languagePageObj.EditedLang();
            string updatedLevel = languagePageObj.EditedLevel();
            Assert.That(updatedLanguage == languages, "Actual Language and expected language do not match");
            Assert.That(updatedLevel == level, "Actual Level and expected level do not match");
        }

        [When(@"I delete Languages and Level from the profile")]
        public void WhenIDeleteLanguagesAndLevelFromTheProfile()
        {
            languagePageObj.DeleteLanguages();
        }

        [Then(@"Languages and Level should be deleted successfully")]
        public void ThenLanguagesAndLevelShouldBeDeletedSuccessfully()
        {
            string deletedLanguage = languagePageObj.DeletedLang();
            Assert.That(deletedLanguage != "Hindi", "Actual Language and expected language do not match");
        }   

    }
}


