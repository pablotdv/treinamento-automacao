using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

/*
new DriverManager().SetUpDriver(new ChromeConfig());
var driver = new ChromeDriver();

driver.Navigate().GoToUrl(@"file:///D:/Estudos/treinamento-automacao/exemplo02/race_condition.html");
IWebElement element = driver.FindElement(By.TagName("p"));
Console.WriteLine(element.Text);


*/

/*
new DriverManager().SetUpDriver(new ChromeConfig());
var options = new ChromeOptions();
options.AddArguments(@"--user-data-dir=C:\\temp\\chrome\\treinamento-automacao");
var driver = new ChromeDriver(options);
driver.Navigate().GoToUrl("https://web.whatsapp.com/send?phone=5551991094824&type=phone_number&app_absent=0&text=Ol%C3%A1%20Erick!");
WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0,1,0));
//var sendButton = driver.FindElement(By.XPath("""//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[2]/button/span"""));
var sendButton  = wait.Until(e=>e.FindElement(By.XPath("""//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[2]/button/span"""))); 
 sendButton.Click();
Console.ReadLine();
*/

new DriverManager().SetUpDriver(new ChromeConfig());
var options = new ChromeOptions();
options.AddArguments(@"--user-data-dir=C:\\temp\\chrome\\treinamento-automacao");
var driver = new ChromeDriver(options);
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
driver.Navigate().GoToUrl("https://web.whatsapp.com/send?phone=5551991094824&type=phone_number&app_absent=0");

driver.FindElement(By.XPath("""//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p""")).SendKeys($"Olá Erick {DateTime.Now}" + Keys.Enter);

//var sendButton = driver.FindElement(By.XPath("""//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[2]/button/span"""));
//var sendButton  = wait.Until(e=>e.FindElement(By.XPath("""//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[2]/button/span"""))); 
//sendButton.Click();
var elementsConversa = driver.FindElements(By.XPath("//span[contains(@class, 'copyable-text')]/span"));
foreach (var element in elementsConversa)
{
    Console.WriteLine(element.Text);
}
Console.ReadLine();

/*
new DriverManager().SetUpDriver(new ChromeConfig());
var driver = new ChromeDriver();
driver.Url = "https://www.google.com/ncr";
driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);

WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//a/h3")));

Console.WriteLine(firstResult.Text);
Console.ReadLine();
*/

driver.Quit();
