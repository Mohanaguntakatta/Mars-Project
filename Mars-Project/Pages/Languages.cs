using Mars_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class Languages : CommonDriver
    {
        public void CreateLanguage(String language, string level)
        {
            // Identify Language button and click
               IWebElement LanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
               LanguageButton.Click();
               Thread.Sleep(1500);

            // Identify Add new button and click
               IWebElement LanguageAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
               LanguageAddButton.Click();
               Thread.Sleep(1500);

            // Identify Add Language textbox and enter valid input
               IWebElement LanguageTextbox = driver.FindElement(By.Name("name"));
               LanguageTextbox.SendKeys(language);
               Thread.Sleep(1000);

            // Identify Choose Language level dropdown box
            // IWebElement LanguageDropdownBox = driver.FindElement(By.Name("level"));
            // LanguageDropdownBox.Click(level);
            // Thread.Sleep(1000);

               SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
               SkilllevelDropdown.SelectByValue(level);
               Thread.Sleep(1000);

            // Choose basic level from dropdown
           // IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            //   LanguageLevel.Click();
            //   Thread.Sleep(1000);

            // Identify Add button and click
               IWebElement ClickAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
               ClickAddButton.Click();
               Thread.Sleep(1000);

        }
        public string GetLanguageTableDetails()
        {
            Thread.Sleep(1500);
            IWebElement newCertifications = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            return newCertifications.GetAttribute("outerText").ToString();
        }
        public void EditLanguage(string language, string level)
        {
            // Identify edit button and click 
               IWebElement LanguageEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
               LanguageEditButton.Click();
               Thread.Sleep(1000);

            // Identify language textbox and update to french
               IWebElement UpdateLanguage = driver.FindElement(By.Name("name"));
               UpdateLanguage.Clear();
               UpdateLanguage.SendKeys(language);
               Thread.Sleep(1000);

            // Identify language level dropdown and click
             //  IWebElement UpdateLanguageLevel = driver.FindElement(By.Name("level"));
            //   UpdateLanguageLevel.Click();
             //  Thread.Sleep(1000);

                SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
                SkilllevelDropdown.SelectByValue(level);
                Thread.Sleep(1000);

            // Select fluent from dropdown
           // IWebElement UpdateFluent = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            //   UpdateFluent.Click();
            //   Thread.Sleep(1000);

            // Identify update button and click
               IWebElement LanguageUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
               LanguageUpdate.Click();
               Thread.Sleep(1000);

            // Check if user is able to update the language succesfully 

        }public void DeleteLanguage() 
        {
            // Identify delete button and click
               IWebElement LanguageDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
               LanguageDeleteButton.Click();
               Thread.Sleep(1000);
            // Check if user is able to delete the language succesfully 
        }
    }
}
