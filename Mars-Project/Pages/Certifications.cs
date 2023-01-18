using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class Certifications
    {
        public void CreateCertifications(IWebDriver driver)
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
               CertificateTextbox.SendKeys("Istqb");
               Thread.Sleep(1000);

            // Identify ceritified from textbox and enter valid input
               IWebElement CertifiedFromTextbox = driver.FindElement(By.Name("certificationFrom"));
               CertifiedFromTextbox.SendKeys("ISTQB Foundation");
               Thread.Sleep(1000);

            // Identify year dropdown box
               IWebElement YearDropdownBox = driver.FindElement(By.Name("certificationYear"));
               YearDropdownBox.Click();
               Thread.Sleep(1000);

            // Choose valid year
               IWebElement ValidYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[3]"));
               ValidYear.Click();
               Thread.Sleep(1000);

            // Identify add button and click
               IWebElement CertificationAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
               CertificationAddButton.Click();
               Thread.Sleep(1000);
            // Check if user is able to add certifications succesfully 
        
        }
        public void EditCertifications(IWebDriver driver)
        {
            // Identify Certification edit button and click
               IWebElement CertificationEditIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
               CertificationEditIcon.Click();
               Thread.Sleep(1000);

            // Identify ceritificate or award textbox and update valid input
               IWebElement UpdateCertificate = driver.FindElement(By.Name("certificationName"));
               UpdateCertificate.Clear();
               UpdateCertificate.SendKeys("Istqb Advance");
               Thread.Sleep(1000);

            // Identify year dropdown box
               IWebElement CertificationDropdown = driver.FindElement(By.Name("certificationYear"));
               CertificationDropdown.Click();
               Thread.Sleep(1000);

            // Update valid year
               IWebElement CertificateUpdateYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[2]"));
               CertificateUpdateYear.Click();
               Thread.Sleep(1000);

            // Identify update button and click
               IWebElement CertificateUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
               CertificateUpdate.Click();
               Thread.Sleep(1000);
            // Check if user is able to update certifications succesfully
        }

        public void DeleteCertifications(IWebDriver driver)
        {
            // Identify delete button and click
               IWebElement CerificateDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
               CerificateDelete.Click();
               Thread.Sleep(1000);
            // Check if user is able to delete the certification succesfully

        }

    }
}

