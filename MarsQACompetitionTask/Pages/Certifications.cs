using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using MarsQACompetitionTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections;


namespace MarsQACompetitionTask.Pages 
{
    /*
   public class Certifications : CommonDriver
    {
        [Test]
        public void TestData()
        {
           driver.Navigate().GoToUrl(Utilities.ReadJsonData.GetData("Education[0].country"));
           Console.WriteLine(Utilities.ReadJsonData.GetData("Education[0].country"));
        }
       
    }*/
    public class Certification
    {
        private readonly IWebDriver driver;
        public Certification(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void CertificationTab()
        {
            IWebElement CertificationTab1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationTab1.Click();
            //Thread.Sleep(10000);
        }
        public void CreateCertification()
        {
            //Thread.Sleep(2000);

            IList certdetails;
            certdetails = Utilities.ReadJsonData.GetDataObject2("Certification[*]");
            int j = 0;
            j = certdetails.Count;

            Console.WriteLine("cert details '''''", j);


            for (int i = 0; i < j; i++)
            { 

                IWebElement AddNewBtn = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            AddNewBtn.Click();
            IWebElement CName = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            CName.Click();
            CName.Clear();
            //CName.SendKeys("CSM");
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));

            IWebElement CertifiedFrom = driver.FindElement(By.Name("certificationFrom"));
            CertifiedFrom.Click();
            //CertifiedFrom.SendKeys("JNTU");
            CertifiedFrom.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertifiedFrom"));

             IWebElement CYearDrpdown = driver.FindElement(By.Name("certificationYear"));
            CYearDrpdown.Click();
            //CYearDrpdown.SendKeys("2010");
                CYearDrpdown.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CyrDropdown"));


                IWebElement AddCertification = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddCertification.Click();
            Thread.Sleep(1000);
        }
           /* IWebElement AddCMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            if (AddCMessage.Text == "Certification has been Added")
            {
                Console.WriteLine("New Certification record has been added");
            }
            else
            {
                Console.WriteLine("Failed to Create Certification Record");
            }*/

        }
        public void CancelAddedCertification()
        {
            IWebElement CertificationTab1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));

            CertificationTab1.Click();

            int i = 0;

            IWebElement AddNewBtn = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            AddNewBtn.Click();

            IWebElement CName = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));

            IWebElement CertifiedFrom = driver.FindElement(By.Name("certificationFrom"));
            CertifiedFrom.Click();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertifiedFrom"));


            IWebElement CYearDrpdown = driver.FindElement(By.Name("certificationYear"));
            CYearDrpdown.Click();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CyrDropdown"));


            IWebElement CancelCertification = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            CancelCertification.Click();
        }

        public void EditCertification()
        {
            IWebElement EditCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            Thread.Sleep(2000);
            EditCertification.Click();
            int i = 0;

            IWebElement CName = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));


            IWebElement CUpdateBtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            CUpdateBtn.Click();

           /* IWebElement UpdateCMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            if (UpdateCMessage.Text == "Certification had been Updated")
            {
                Console.WriteLine("Certification Name has been Updated");
            }
            else
            {
                Console.WriteLine("Failed to Updated Certification Name");
            }*/
        }
        public void CancelEditCertification()
        {
            IWebElement EditCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            Thread.Sleep(2000);
            EditCertification.Click();

            int i = 0;

            IWebElement CName = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            CName.Click();
            CName.Clear();
            CName.SendKeys(Utilities.ReadJsonData.GetData("Certification[" + i + "].CertificationName"));

            IWebElement CancelCBtn1 = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            CancelCBtn1.Click();
        }
        public void DeleteCertification()
        { 
            IWebElement DeleteCertification = driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]/i[1]"));
            DeleteCertification.Click();

            IWebElement DelMessage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]"));
            if (DelMessage.Text == "Certification Entry Successfully Removed")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}
