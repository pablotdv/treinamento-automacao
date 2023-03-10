using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

new DriverManager().SetUpDriver(new EdgeConfig());
var driver = new EdgeDriver();

Thread.Sleep(5000); 

driver.Navigate().GoToUrl("https://www.bing.com/");

var textInput = driver.FindElement(By.XPath("""//*[@id="sb_form_q"]"""));
textInput.SendKeys("Selenium");
textInput.SendKeys(Keys.Enter);

Thread.Sleep(5000);

//var submitInput = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[2]/div[2]/div[5]/center/input[1]"));
//submitInput.Click();


Thread.Sleep(5000); 
driver.Quit();