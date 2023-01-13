
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
Thread.Sleep(1000);

// Identify Add button and click

IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
AddButton.Click();
Thread.Sleep(1500);

// Check if user is able to added skill succesfully to the Profile page

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

//  Choose beginner level from dropdown

IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
LanguageLevel.Click();
Thread.Sleep(1000);

// Identify Add button and click

IWebElement ClickAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
ClickAddButton.Click();
Thread.Sleep(1000);