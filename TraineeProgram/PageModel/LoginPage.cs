using Magenic.Maqs.BaseSeleniumTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram.PageModel
{
    public class LoginPage 
    {
        public bool LoginPageNavigation(IWebDriver driver, string userN, string userP)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            IWebElement userName = wait.Until(EC.ElementIsVisible(By.XPath("//*[@name=\"userName\"]")));
            IWebElement userPass = wait.Until(EC.ElementIsVisible(By.XPath("//*[@name=\"password\"]")));
            IWebElement loginBtn = wait.Until(EC.ElementIsVisible(By.XPath("//*[@name=\"submit\"]")));

            userName.SendKeys(userN);
            //Thread.Sleep(3000); recordar
            userPass.SendKeys(userP);
        
            loginBtn.Click();

            IWebElement confirmMessage = wait.Until(EC.ElementIsVisible(By.XPath("//*[contains(text(),'Login Successfully12121212')]")));

            bool flag = false;

            if (confirmMessage != null)
            {

                return flag = true;
            }
            else
            {

                return false;

            }

            return flag;
        }
    }
}
