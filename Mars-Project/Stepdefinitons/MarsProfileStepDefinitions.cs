using Mars_Project.Pages;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace Mars_Project.Stepdefinitons
{
    [Binding]
    public class MarsProfileStepDefinitions : CommonDriver
    {   
        Login loginobj = new Login();
        Languages languagesobj = new Languages();
        Skills skillobj = new Skills();
        Certifications certificationsobj = new Certifications();


        [Given(@"I logged in to Mars portal successfully")]
        public void GivenILoggedInToMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();

            loginobj.CreateLogin();

        }

        [When(@"I navigate to profile page")]
        public void WhenINavigateToProfilePage()
        {
            loginobj.goToProfilePage();
        }

        [Given(@"Add new '([^']*)' and '([^']*)' to the profile")]
        public void GivenAddNewAndToTheProfile(string language, string level)
        {
            languagesobj.CreateLanguage(language,level);
        }

        [Then(@"'([^']*)'and '([^']*)' should be added successfully")]
        public void ThenAndShouldBeAddedSuccessfully(string language, string level)
        {
            string newLanguage = languagesobj.GetLanguageTableDetails();
            string newLevel = languagesobj.GetLanguageTableDetails();

            Assert.That(newLanguage.Contains(language), "Actual langauge and Expected langauge do not match");
            Assert.That(newLevel.Contains(level), "Actual langauge and Expected langauge do not match");


            driver.Quit();
        }

        [Given(@"Add new '([^']*)' and '([^']*)' language to the profile")]
        public void GivenAddNewAndLanguageToTheProfile(string language, string level)
        {
            languagesobj.EditLanguage(language, level);
        }

        [Then(@"'([^']*)'and '([^']*)' should be updated successfully")]
        public void ThenAndShouldBeUpdatedSuccessfully(string language, string level)
        {
            string editLanguage = languagesobj.GetLanguageTableDetails();
            string editLevel = languagesobj.GetLanguageTableDetails();

            Assert.That(editLanguage.Contains(language), "Edited langauge and Expected langauge do not match");
            Assert.That(editLevel.Contains(level), "Edited langauge and Expected langauge do not match");


            driver.Quit();
        }

        [Given(@"Delete the existing Language deatails")]
        public void GivenDeleteTheExistingLanguageDeatails()
        {
            languagesobj.DeleteLanguage();
        }

        [Then(@"Language deatails should be deleted successfully")]
        public void ThenLanguageDeatailsShouldBeDeletedSuccessfully()
        {
            string deleteLanguage = languagesobj.GetLanguageTableDetails();

            Assert.That(deleteLanguage != "language", "Deleted langauge and Expected langauge do not match");

            driver.Quit();
        }

        [Given(@"Left Language Field blank")]
        public void GivenLeftLanguageFieldBlank()
        {
            languagesobj.ValidatingLanguage();
          
        }

        [Then(@"Error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            string errorMessage = languagesobj.getErrorMessage();

            Assert.That(errorMessage == "Please enter language and level", "Actual message and Expected message do not match");

            driver.Quit();
        }


        [Given(@"Added new '([^']*)' and '([^']*)' to the profile")]
        public void GivenAddedNewAndToTheProfile(string qA, string beginner)
        {
            skillobj.CreateSkills(qA, beginner);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be updated successfully")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string p0, string skillLevel)
        {
            string newSkill = skillobj.GetSkillTableDetails();
            string newLevel = skillobj.GetSkillTableDetails();

            Assert.That(newSkill.Contains(p0), "Actual skill and Expected skill do not match");
            Assert.That(newLevel.Contains(skillLevel), "Actual skill and Expected skill do not match");


            driver.Quit();
        }

        [Given(@"Edit existing '([^']*)' and '([^']*)' on profile")]
        public void GivenEditExistingAndOnProfile(string p0, string expert)
        {
            skillobj.EditSkills(p0, expert);
        }


        [Then(@"The '([^']*)' and '([^']*)'skill edit should be updated successfully")]
        public void ThenTheAndSkillEditShouldBeUpdatedSuccessfully(string p0, string skillLevel)
        {
            string editSkill = skillobj.GetSkillTableDetails();
            string newLevel = skillobj.GetSkillTableDetails();

            Assert.That(editSkill.Contains(p0), "Edited skill and Expected skill do not match");
            Assert.That(newLevel.Contains(skillLevel), "Edited skill and Expected skill do not match");


            driver.Quit();
        }


        [Given(@"Delete existing Skills")]
        public void GivenDeleteExistingSkills()
        {
            skillobj.DeleteSkills();
        }

        [Then(@"Skills should be deleted successfully")]
        public void ThenSkillsShouldBeDeletedSuccessfully()
        {
            string deleteSkills = skillobj.GetSkillTableDetails();

            Assert.That(deleteSkills != "p0", "Deleted skill and Expected skill do not match");

            driver.Quit();
        }

        [Given(@"Left Skills field as blank")]
        public void GivenLeftSkillsFieldAsBlank()
        {
            skillobj.ValidatingSkills();
        }

        [Then(@"Error message should be displayed for skills")]
        public void ThenErrorMessageShouldBeDisplayedForSkills()
        {
            string errorMessage = skillobj.getErrorMessage();

            Assert.That(errorMessage == "Please enter skill and experience level", "Actual message and Expected message do not match");

            driver.Quit();
        }


        [Given(@"Add new '([^']*)','([^']*)' and '([^']*)' to profile")]
        public void GivenAddNewAndToProfile(string istqb, string p1, string p2)
        {
            certificationsobj.CreateCertifications(istqb, p1, p2);
        }

        [Then(@"The '([^']*)','([^']*)' and '([^']*)'details should be added successfully")]
        public void ThenTheAndDetailsShouldBeAddedSuccessfully(string istqb, string p1, string p2)
        {
            string newCertifications = certificationsobj.GetCertificationsTableDetails();
            string newCertificationsFrom = certificationsobj.GetCertificationsTableDetails();
            string newYear = certificationsobj.GetCertificationsTableDetails();

            Assert.That(newCertifications.Contains(istqb), "Actual Certifications and Expected Certifications do not match");
            Assert.That(newCertificationsFrom.Contains(p1), "Actual Certifications and Expected Certifications do not match");
            Assert.That(newYear.Contains(p2), "Actual Certifications and Expected Certifications do not match");

            driver.Quit();
        }

        [Given(@"Edit existing '([^']*)','([^']*)' and '([^']*)' to profile")]
        public void GivenEditExistingAndToProfile(string p0, string p1, string p2)
        {
            certificationsobj.EditCertifications(p0, p2);
        }

        [Then(@"'([^']*)','([^']*)' and '([^']*)' details should be updated successfully")]
        public void ThenAndDetailsShouldBeUpdatedSuccessfully(string p0, string p1, string p2)
        {

            string editCertifications = certificationsobj.GetCertificationsTableDetails();
            string editCertificationsFrom = certificationsobj.GetCertificationsTableDetails();
            string editYear = certificationsobj.GetCertificationsTableDetails();

            Assert.That(editCertifications.Contains(p0), "Edited Certifications and Expected Certifications do not match");
            Assert.That(editCertificationsFrom.Contains(p1), "Edited Certifications and Expected Certifications do not match");
            Assert.That(editYear.Contains(p2), "Edited Certifications and Expected Certifications do not match");

            driver.Quit();
        }

        [Given(@"Delete Certifications details")]
        public void GivenDeleteCertificationsDetails()
        {
            certificationsobj.DeleteCertifications();
        }

        [Then(@"Certifications details should be deleted successfully")]
        public void ThenCertificationsDetailsShouldBeDeletedSuccessfully()
        {
            string deleteCertifications = certificationsobj.GetCertificationsTableDetails();

            Assert.That(deleteCertifications != "p0", "Deleted Certifications and Expected Certifications do not match");

            driver.Quit();
        }

        [Given(@"Left Certifications field as blank")]
        public void GivenLeftCertificationsFieldAsBlank()
        {
            certificationsobj.ValidatingCertifications();
        }

        [Then(@"Following error message should be displayed")]
        public void ThenFollowingErrorMessageShouldBeDisplayed()
        {
            string errorMessage = certificationsobj.getErrorMessage();

            Assert.That(errorMessage == "Please enter Certification Name, Certification From and Certification Year", "Actual message and Expected message do not match");

            driver.Quit();
        }

    }


}
