using NovemberQA.Pages;
using NovemberQA.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NovemberQA.StepDefinitions
{

    [Binding]
    public class SkillsStepDefinition : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        SkillsPage skillsPageObj = new SkillsPage();

        [Given(@"I logged in portal successfully")]
        public void GivenILoggedInPortalSuccessfully()
        {
            
            loginPageObj.LoginSteps(driver);

        }


        [When(@"I add '([^']*)' and '([^']*)' to profile")]
        public void WhenIAddAndToProfile(string skills, string level)
        {
            skillsPageObj.AddSkills(driver, skills, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be added to the profile successfully")]
        public void ThenTheAndShouldBeAddedToTheProfileSuccessfully(string skills, string level)
        {
            skillsPageObj.NewSkills(driver, skills, level);
        }

        [When(@"I edit Skills and Level to profile")]
        public void WhenIEditSkillsAndLevelToProfile()
        {
            skillsPageObj.EditSkills(driver);
        }

        [Then(@"The Skills and Level should be edited to the profile successfully")]
        public void ThenTheSkillsAndLevelShouldBeEditedToTheProfileSuccessfully()
        {
            skillsPageObj.EditedSkills(driver);
        }

        [When(@"I delete Skills and Level from profile")]
        public void WhenIDeleteSkillsAndLevelFromProfile()
        {
           skillsPageObj.DeleteSkills(driver);
        }

        [Then(@"The Skills and Level should be deleted from the profile successfully")]
        public void ThenTheSkillsAndLevelShouldBeDeletedFromTheProfileSuccessfully()
        {
            skillsPageObj.DeletedSkills(driver);
        }

    }
}

    

