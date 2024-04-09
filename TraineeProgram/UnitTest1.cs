using TraineeProgram.BaseTest;

namespace TraineeProgram
{
    [TestClass]
    public class UnitTest1 : UIBaseSeleniumTest
    {
        [TestMethod]
        public void VerifyWebPageLogin()
        {
           
            string username = "admin";
            string pass = "admin123";
            CreateLoginBaseTest(username, pass);
        }
    }
}