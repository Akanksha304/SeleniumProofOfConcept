using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string URL = "https://www.linkedin.com/";
            private static string PageTitle = "LinkedIn";
            public static void Goto()
             {
                Browser.Goto(URL);
             }

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
            }

            public static void ClickSignIn()
            {   
                Browser.LogIn();
            }
        }
            
    }
}
