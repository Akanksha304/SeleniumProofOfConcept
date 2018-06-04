using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver("C:/Library");
        public static string SignInId = "login-submit";
        public static string UserNameId = "login-email";
        public static string PasswordId = "login-password";
        public static string UserNameIdText = "Akanksha304@gmail.com";
        public static string PasswordIdText = "Shri0908&";

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void LogIn()
        {
            var textUserName = webDriver.FindElement(By.Id(UserNameId));
            textUserName.SendKeys(UserNameIdText);

            var textPassword = webDriver.FindElement(By.Id(PasswordId));
            textPassword.SendKeys(PasswordIdText);

            var btnSignIn = webDriver.FindElement(By.Id(SignInId));
            btnSignIn.Click();


        }

    }
}