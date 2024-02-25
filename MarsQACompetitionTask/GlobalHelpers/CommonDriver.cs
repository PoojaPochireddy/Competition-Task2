using MarsQACompetitionTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQACompetitionTask.Utilities
{
    public class CommonDriver
    {
         public IWebDriver driver;
         public SignIn SignInObj;
         public Education EducationObj;
         public Certification CertificationObj;

        [SetUp]
         public void StartBrowser()
         {
             // driver = new ChromeDriver("C:\\Competition Task-MVP\\MarsQACompetitionTask\\bin\\Debug");
             driver = new ChromeDriver();
             driver.Url = "http://localhost:5000/";
             driver.Manage().Window.Maximize();
             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
             SignInObj = new SignIn(driver);
             EducationObj = new Education(driver);
             CertificationObj = new Certification(driver);
         }

        [TearDown]        
        public void StopBrowser()  
        {
            driver.Quit();
        }
    }
}
