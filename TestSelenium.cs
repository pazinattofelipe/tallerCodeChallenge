
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class TestSelenium
{

    private IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

    [Test]
    public void FormSubmit()
    {
        driver.Navigate().GoToUrl("https://demoqa.com/text-box");

        driver.Manage().Window.Maximize();

        IWebElement FullName = driver.FindElement(By.Id("userName"));
        FullName.SendKeys("John Doe");

        IWebElement EmailUser = driver.FindElement(By.Id("userEmail"));
        EmailUser.SendKeys("john.doe@example.com");

        IWebElement CurrentAddress = driver.FindElement(By.Id("currentAddress"));
        CurrentAddress.SendKeys("123 Main St");

        IWebElement PermanentAddress = driver.FindElement(By.Id("permanentAddress"));
        PermanentAddress.SendKeys("456 Secondary St");

        IWebElement SubmitButton = driver.FindElement(By.Id("submit"));
        SubmitButton.Click();
    }


    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }

}
