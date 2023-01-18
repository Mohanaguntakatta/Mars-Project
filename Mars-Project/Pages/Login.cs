using Mars_Project.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class Login : CommonDriver
    {
        public void CreateLogin()
        {

            // Launch Mars portal
               driver.Navigate().GoToUrl("http://localhost:5000/Home");
               driver.Manage().Window.Maximize();
               Thread.Sleep(1500);
         
            // Identify signin button and click 
               IWebElement SigninButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
               SigninButton.Click();
               Thread.Sleep(1000);

            // Identify Username textbox and enter valid username
               IWebElement UsernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
               UsernameTextbox.SendKeys("moni.snigdha@gmail.com");
               Thread.Sleep(1000);

            // Identify Password textbox and enter valid password
               IWebElement PasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
               PasswordTextbox.SendKeys("password");
               Thread.Sleep(1000);

            // Click login button
               IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
               LoginButton.Click();
               Thread.Sleep(2000);

            // Check if user is able to logged in succesfully to the Profile page
        }
    }
}
