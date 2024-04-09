using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.PageModel;

namespace TraineeProgram.BaseTest
{
    public class UIBaseSeleniumTest : BaseSeleniumTest
    {
        public void CreateLoginBaseTest( string userN, string userPass )
        {
            String chromeRoute = @"C:\Users\E105269\Desktop\TraineeProgram\ChromeDriver\chromedriver.exe";
            IWebDriver driver = new ChromeDriver(chromeRoute);

            string url = "https://demo.guru99.com/test/newtours/index.php";
            driver.Navigate().GoToUrl(url);

            LoginPage page = new LoginPage();
            bool result = page.LoginPageNavigation(driver, userN, userPass);


            SoftAssert.Assert(() => Assert.IsTrue(result, "result not expected"));


            SoftAssert.FailTestIfAssertFailed();
            driver.Quit();
        }
    }
}
