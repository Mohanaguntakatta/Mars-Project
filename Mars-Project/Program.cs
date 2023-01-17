
// Open Chrome Driver

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();


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
   AddskillTextbox.SendKeys("QA");
   Thread.Sleep(1000);

// Identify skill level dropdowm and click 
   IWebElement SkilllevelDropdown = driver.FindElement(By.Name("level"));
   SkilllevelDropdown.Click();
   Thread.Sleep(1000);

// Choose beginner level from dropdown
   IWebElement BeginnerLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
   BeginnerLevel.Click();                                   
   Thread.Sleep(1500);

// Identify Add button and click
   IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
   AddButton.Click();
   Thread.Sleep(1500);

// Check if user is able to added skill succesfully to the Profile page

// Identify skill edit button and click 
   IWebElement SkillEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
   SkillEditButton.Click();
   Thread.Sleep(1000);

// Identify skill textbox and update test analyst
   IWebElement UpdateSkill = driver.FindElement(By.Name("name"));
   UpdateSkill.Clear();
   UpdateSkill.SendKeys("Test Analyst");
   Thread.Sleep(1000);

// Identify skill level dropdown 
   IWebElement ClickSkillDropdown = driver.FindElement(By.Name("level"));
   ClickSkillDropdown.Click();
   Thread.Sleep(1500);

// Select expert from skill dropdown
   IWebElement SkillExpert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
   SkillExpert.Click();
   Thread.Sleep(1500);

// Identify update button and click
   IWebElement ClickSkillUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
   ClickSkillUpdate.Click();
   Thread.Sleep(1500);
// Check if user is able to update the skill succesfully 

// Identify delete button and click
   IWebElement SkillDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
   SkillDelete.Click();                                   
   Thread.Sleep(1500);
// Check if user is able to delete the skill succesfully 


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

// Identify delete button and click
   IWebElement CerificateDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
   CerificateDelete.Click();
   Thread.Sleep(1000);
// Check if user is able to delete the certification succesfully




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
LanguageTextbox.SendKeys("English");
Thread.Sleep(1000);

// Identify Choose Language level dropdown box

IWebElement LanguageDropdownBox = driver.FindElement(By.Name("level"));
LanguageDropdownBox.Click();
Thread.Sleep(1000);

//  Choose basic level from dropdown

IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
LanguageLevel.Click();                                    
Thread.Sleep(1000);

// Identify Add button and click

IWebElement ClickAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
ClickAddButton.Click();
Thread.Sleep(1000);

// Identify edit button and click 

IWebElement LanguageEditButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
LanguageEditButton.Click();
Thread.Sleep(1000);

// Identify language textbox and update to french
IWebElement UpdateLanguage = driver.FindElement(By.Name("name"));
UpdateLanguage.Clear();
UpdateLanguage.SendKeys("French");
Thread.Sleep(1000);

// Identify language level dropdown and click
IWebElement UpdateLanguageLevel = driver.FindElement(By.Name("level"));
UpdateLanguageLevel.Click();
Thread.Sleep(1000);

// Select fluent from dropdown
   IWebElement UpdateFluent = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
   UpdateFluent.Click();
   Thread.Sleep(1000);

// Identify update button and click
   IWebElement LanguageUpdate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
   LanguageUpdate.Click();
   Thread.Sleep(1000);

// Check if user is able to update the language succesfully 

// Identify delete button and click
   IWebElement LanguageDeleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
   LanguageDeleteButton.Click();
   Thread.Sleep(1000);
// Check if user is able to delete the language succesfully 