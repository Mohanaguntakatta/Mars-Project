using Mars_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class Skills : CommonDriver
    {
        public void CreateSkills(string Skills, string SkillLevel)
        {
            // Identify skill button and click
               IWebElement SkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
               SkillButton.Click();
               Thread.Sleep(1500);

            // Identify Add new button and click
               IWebElement AddnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
               AddnewButton.Click();
               Thread.Sleep(1000);

            // Identify Add skill textbox and enter valid input
               IWebElement AddskillTextbox = driver.FindElement(By.Name("name"));
               AddskillTextbox.SendKeys(Skills);
               Thread.Sleep(1000);

            // Identify skill level dropdowm and click 
            //  IWebElement SkilllevelDropdown = driver.FindElement(By.Name("level"));
            // SkilllevelDropdown.Click();
            // 
               SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
               SkilllevelDropdown.SelectByValue(SkillLevel);
               Thread.Sleep(1000);

            // Choose beginner level from dropdown
            //IWebElement BeginnerLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            //  BeginnerLevel.Click();
            //  Thread.Sleep(1500);

            // Identify Add button and click
               IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
               AddButton.Click();
               Thread.Sleep(3000);

            // Check if user is able to added skill succesfully to the Profile page
        }
        public string GetSkillTableDetails()
        {
            Thread.Sleep(1500);

            // Getting skill table details for assertion.
               IWebElement newSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
               return newSkills.GetAttribute("outerText").ToString();
        }
     
        public void EditSkills(string Skills, string SkillLevel)
        {
            // Identify skill button and click
               IWebElement SkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
               SkillButton.Click();
               Thread.Sleep(1500);

            // Identify skill edit button and click 
               IWebElement SkillEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
               SkillEditButton.Click();
               Thread.Sleep(1000);

            // Identify skill textbox and update test analyst
               IWebElement UpdateSkill = driver.FindElement(By.Name("name"));
               UpdateSkill.Clear();
               UpdateSkill.SendKeys(Skills);
               Thread.Sleep(1000);

            // Identify skill level dropdown 
            //   IWebElement ClickSkillDropdown = driver.FindElement(By.Name("level"));
            //  ClickSkillDropdown.Click();
            // Thread.Sleep(1500);
               SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
               SkilllevelDropdown.SelectByValue(SkillLevel);
               Thread.Sleep(1000);

            // Select expert from skill dropdown
           // IWebElement SkillExpert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
           //   SkillExpert.Click();
           //  Thread.Sleep(1500);

            // Identify update button and click
               IWebElement ClickSkillUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
               ClickSkillUpdate.Click();
               Thread.Sleep(3000);
            // Check if user is able to update the skill succesfully 


        }

        public void DeleteSkills() 
        {
            // Identify skill button and click
               IWebElement SkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
               SkillButton.Click();
               Thread.Sleep(1500);

            // Identify delete button and click
               IWebElement SkillDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
               SkillDelete.Click();
               Thread.Sleep(3000);
            // Check if user is able to delete the skill succesfully 

        }

        public void ValidatingSkills()
        {
            // Identify skill button and click
               IWebElement SkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
               SkillButton.Click();
               Thread.Sleep(1500);

            // Identify Add new button and click
               IWebElement AddnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
               AddnewButton.Click();
               Thread.Sleep(1000);

            // Identify Add skill textbox leave empty
               IWebElement AddskillTextbox = driver.FindElement(By.Name("name"));
               AddskillTextbox.SendKeys(string.Empty);
               Thread.Sleep(3000);
        }

        public string getErrorMessage()
        {
            // verifying error message is displayed or not
               IWebElement validatingErrorMessage = driver.FindElement(By.XPath("/div/div[contains(text(),'Please enter skill and experience level')]"));
               return validatingErrorMessage.Text;
        }
    }
}
