using Mars_Project.Pages;
using Mars_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
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

            Login loginobj = new Login();

        }

        [When(@"I navigate to profile page")]
        public void WhenINavigateToProfilePage()
        {
            Login loginobj = new Login();
        }

        [Given(@"Add new '([^']*)' and '([^']*)' to the profile")]
        public void GivenAddNewAndToTheProfile(string language, string level)
        {
            Languages languagesobj = new Languages();
        }

        [Then(@"'([^']*)'and '([^']*)' should be added successfully")]
        public void ThenAndShouldBeAddedSuccessfully(string language, string level)
        {
            throw new PendingStepException();
        }

        [Then(@"'([^']*)'and '([^']*)' should be updated successfully")]
        public void ThenAndShouldBeUpdatedSuccessfully(string language, string level)
        {
            throw new PendingStepException();
        }

        [Given(@"Delete the existing Language deatails")]
        public void GivenDeleteTheExistingLanguageDeatails()
        {
            Languages languagesobj = new Languages();
        }

        [Then(@"Language deatails should be deleted successfully")]
        public void ThenLanguageDeatailsShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given(@"Added new '([^']*)' and '([^']*)' to the profile")]
        public void GivenAddedNewAndToTheProfile(string qA, string beginner)
        {
            Skills skillobj = new Skills();
        }

        [Then(@"The '([^']*)' and '([^']*)' should be updated successfully")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string p0, string skillLevel)
        {
            throw new PendingStepException();
        }

        [Given(@"Edit existing '([^']*)' and '([^']*)' on profile")]
        public void GivenEditExistingAndOnProfile(string p0, string expert)
        {
            Skills skillobj = new Skills();
        }

        [Then(@"'([^']*)','([^']*)' and '([^']*)' details should be added successfully")]
        public void ThenAndDetailsShouldBeAddedSuccessfully(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"Delete existing Skills")]
        public void GivenDeleteExistingSkills()
        {
            Skills skillobj = new Skills();
        }

        [Then(@"Skills should be deleted successfully")]
        public void ThenSkillsShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given(@"Add new '([^']*)','([^']*)' and '([^']*)' to profile")]
        public void GivenAddNewAndToProfile(string istqb, string p1, string p2)
        {
            Certifications certificationsobj = new Certifications();
        }

        [Then(@"The '([^']*)','([^']*)' and '([^']*)'details should be added successfully")]
        public void ThenTheAndDetailsShouldBeAddedSuccessfully(string istqb, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"Edit existing '([^']*)','([^']*)' and '([^']*)' to profile")]
        public void GivenEditExistingAndToProfile(string p0, string p1, string p2)
        {
            Certifications certificationsobj = new Certifications();
        }

        [Then(@"'([^']*)','([^']*)' and '([^']*)' details should be updated successfully")]
        public void ThenAndDetailsShouldBeUpdatedSuccessfully(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Given(@"Delete Certifications details")]
        public void GivenDeleteCertificationsDetails()
        {
            Certifications certificationsobj = new Certifications();
        }

        [Then(@"Certifications details should be deleted successfully")]
        public void ThenCertificationsDetailsShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
