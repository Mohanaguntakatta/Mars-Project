using Mars_Project.Utilities;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class Certifications : CommonDriver
    {
        public void CreateCertifications(string Certifications, string CertificateFrom, string Year)
        { 
            // Identify Certification button and click
               IWebElement CertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
               CertificationButton.Click();
               Thread.Sleep(1000);

            // Identify Add new button and click
               IWebElement CertificationAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
               CertificationAddNew.Click();
               Thread.Sleep(1000);

            // Identify ceritificate or award textbox and enter valid input
               IWebElement CertificateTextbox = driver.FindElement(By.Name("certificationName"));
               CertificateTextbox.SendKeys(Certifications);
               Thread.Sleep(1000);

            // Identify ceritified from textbox and enter valid input
            // IWebElement CertifiedFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            // CertifiedFromTextbox.SendKeys(CertificateFrom);
            // Thread.Sleep(1000);
               SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
               SkilllevelDropdown.SelectByValue(Year);
               Thread.Sleep(1000);

            // Identify year dropdown box
            // IWebElement YearDropdownBox = driver.FindElement(By.Name("certificationYear"));
            // YearDropdownBox.Click();
           //  Thread.Sleep(1000);

            // Choose valid year
               IWebElement ValidYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]"));
               ValidYear.Click();
               Thread.Sleep(1000);

            // Identify add button and click
               IWebElement CertificationAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
               CertificationAddButton.Click();
               Thread.Sleep(3000);
            // Check if user is able to add certifications succesfully 
        
        }
        public string GetCertificationsTableDetails()
        {
            Thread.Sleep(1500);
            IWebElement newCertifications = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));
            return newCertifications.GetAttribute("outerText").ToString();
        }
        public void EditCertifications(string Certifications, string Year)
        {
            // Identify Certification button and click
               IWebElement CertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
               CertificationButton.Click();
               Thread.Sleep(1000);

            // Identify Certification edit button and click
               IWebElement CertificationEditIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
               CertificationEditIcon.Click();
               Thread.Sleep(1000);

            // Identify ceritificate or award textbox and update valid input
               IWebElement UpdateCertificate = driver.FindElement(By.Name("certificationName"));
               UpdateCertificate.Clear();
               UpdateCertificate.SendKeys(Certifications);
               Thread.Sleep(1000);

            // Identify year dropdown box
            // IWebElement CertificationDropdown = driver.FindElement(By.Name("certificationYear"));
            // CertificationDropdown.Click();
            // Thread.Sleep(1000);
               SelectElement SkilllevelDropdown = new SelectElement(driver.FindElement(By.Name("level")));
               SkilllevelDropdown.SelectByValue(Year);
               Thread.Sleep(1000);
            // Update valid year
            // IWebElement CertificateUpdateYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[2]"));
            // CertificateUpdateYear.Click();
            // Thread.Sleep(1000);

            // Identify update button and click
               IWebElement CertificateUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
               CertificateUpdate.Click();
               Thread.Sleep(3000);
            // Check if user is able to update certifications succesfully
        }

        public void DeleteCertifications()
        {
            // Identify Certification button and click
               IWebElement CertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
               CertificationButton.Click();
               Thread.Sleep(1000);

            // Identify delete button and click
               IWebElement CerificateDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
               CerificateDelete.Click();
               Thread.Sleep(3000);
            // Check if user is able to delete the certification succesfully
               
        }

        public void ValidatingCertifications()
        {
            // Identify Certification button and click
               IWebElement CertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
               CertificationButton.Click();
               Thread.Sleep(1000);

            // Identify Add new button and click
               IWebElement CertificationAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
               CertificationAddNew.Click();
               Thread.Sleep(1000);

            // Identify ceritificate or award textbox leave empty
               IWebElement CertificateTextbox = driver.FindElement(By.Name("certificationName"));
               CertificateTextbox.SendKeys(string.Empty);
               Thread.Sleep(1000);
        }

        public string getErrorMessage()
        {
            // verifying error message is displayed or not
               IWebElement validatingErrorMessage = driver.FindElement(By.XPath("/div/div[contains(text(),Please enter Certification Name, Certification From and Certification Year')]"));
               return validatingErrorMessage.Text;
        }
    }
}

