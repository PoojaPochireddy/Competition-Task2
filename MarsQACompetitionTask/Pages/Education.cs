using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Collections;
using Microsoft.SqlServer.Server;

namespace MarsQACompetitionTask.Pages
{

    public class Education
    {
        private readonly IWebDriver driver;
        public Education(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EducationTab()
        {
            IWebElement EducationTab1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            //IWebElement EducationTab1 = driver.FindElement(By.XPath("(//a[@data-tab='third'])[1]"));
            EducationTab1.Click();
            //Thread.Sleep(10000);
        }
        public void CreateEducation()
        {
            Thread.Sleep(2000);
            
            /*
            IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.Click();
            CollegeName.Clear();
            CollegeName.SendKeys("Merits");
            
          /*  IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.Click();
            CollegeName.SendKeys(Utilities.ReadJsonData.GetData("Education.CollegeUniversityName"));*/


            /*IWebElement CountryNameDropdown = driver.FindElement(By.Name("country"));
            CountryNameDropdown.Click();
            CountryNameDropdown.SendKeys("Australia");

            /*IWebElement CountryNameDropdown = driver.FindElement(By.Name("country"));
            CountryNameDropdown.Click();
            CountryNameDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education.country"));*/

            /* IWebElement TitleDropdown = driver.FindElement(By.Name("title"));
             TitleDropdown.Click();
             TitleDropdown.SendKeys("B.Tech");

             /*IWebElement TitleDropdown = driver.FindElement(By.Name("title"));
             TitleDropdown.Click();
             TitleDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education.title"));*/

            /*IWebElement Degree = driver.FindElement(By.Name("degree"));
             Degree.Click();
             Degree.Clear();
             Degree.SendKeys("Graduate");
            
           /* IWebElement Degree = driver.FindElement(By.Name("degree"));
            Degree.Click();
            Degree.Clear();
            Degree.SendKeys(Utilities.ReadJsonData.GetData("Education.degree"));*/

            /*IWebElement YearOfGraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            YearOfGraduationDropdown.Click();
            YearOfGraduationDropdown.SendKeys("2009");
            */
            IList edudetails;
            edudetails = Utilities.ReadJsonData.GetDataObject2("Education[*]");
            int j = 0;
            j=  edudetails.Count;
           
            Console.WriteLine("edu details '''''", j);


            for (int i = 0 ; i < j; i++)
            {

                IWebElement AddNew = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']"));
                AddNew.Click();

                // Console.WriteLine(eduDetails.ToList());
                IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
                CollegeName.Click();
                CollegeName.SendKeys(Utilities.ReadJsonData.GetData("Education["+i+"].CollegeUniversityName")); 



                IWebElement CountryNameDropdown = driver.FindElement(By.Name("country"));
                CountryNameDropdown.Click();
                
                CountryNameDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education["+i+"].country"));


                IWebElement TitleDropdown = driver.FindElement(By.Name("title"));
                TitleDropdown.Click();
                TitleDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education["+i+"].title")); 

                IWebElement Degree = driver.FindElement(By.Name("degree"));
                Degree.Click();
                Degree.Clear();
                Degree.SendKeys(Utilities.ReadJsonData.GetData("Education["+i+ "].Degree")); 



              IWebElement YearOfGraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
                YearOfGraduationDropdown.Click();
                YearOfGraduationDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education["+i+"].yearOfGraduation"));


                IWebElement AddEducation = driver.FindElement(By.XPath("//input[@value='Add']"));
                AddEducation.Click();

                IWebElement AddMessagechk = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

                if (AddMessagechk.Text == "Education had been Added")
                {
                    Console.WriteLine("New Education record has been added");
                }
                else
                {
                    Console.WriteLine("Failed to Create Education Record");
                }

                //YearOfGraduationDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education[i].yearOfGraduation"));
            }
            
            /* IWebElement YearOfGraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
             YearOfGraduationDropdown.Click();
            var education= Utilities.ReadJsonData.GetData("Education");
                JSONArray usersList = (JSONArray) (Utilities.ReadJsonData.GetData("Education"));
            System.out.println("Users List-> "+usersList);
            
            
            YearOfGraduationDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education.yearOfGraduation"))




             ;*/

            //List edulist = (Utilities.ReadJsonData.GetData("Education"));
            
            //System.out.println("Users List-> " + usersList);


           IWebElement AddMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            
            if (AddMessage.Text == "Education had been Added")
            {
                Console.WriteLine("New Education record has been added");
            }
            else
            {
                Console.WriteLine("Failed to Create Education Record");
            }

        }
        public void CancelAddedEducation()
        {
            IWebElement EducationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));

            EducationTab.Click();
            int i = 0;
            IWebElement AddNew = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']"));
            AddNew.Click();

            IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.Click();
            CollegeName.Clear();
            CollegeName.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].CollegeUniversityName"));

            IWebElement CountryNameDropdown = driver.FindElement(By.Name("country"));
            CountryNameDropdown.Click();
            CountryNameDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].country"));


            IWebElement TitleDropdown = driver.FindElement(By.Name("title"));
            TitleDropdown.Click();
            TitleDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].title"));


            IWebElement Degree = driver.FindElement(By.Name("degree"));
            Degree.Click();
            Degree.Clear();
            Degree.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].Degree"));


            IWebElement YearOfGraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            YearOfGraduationDropdown.Click();
            YearOfGraduationDropdown.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].yearOfGraduation"));


            IWebElement CancelEducation = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            CancelEducation.Click();
        }
        public void EditEducation()
        {
            //IWebElement EditEducation = driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            IWebElement EditEducation = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[1]/i[1]"));
            Thread.Sleep(2000);
            EditEducation.Click();

            int i = 0;
 
            IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.Click();
            CollegeName.Clear();
            CollegeName.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].updateTitle"));


            IWebElement UpdateBtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateBtn.Click();

            IWebElement UpdateMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            if (UpdateMessage.Text == "Education had been Added")
            {
                Console.WriteLine("New Education record has been Updated");
            }
            else
            {
                Console.WriteLine("Failed to Updated Education Record");
            }
        }

        public void CancelEditEducation()
        {
            IWebElement EditEducation = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[1]/i[1]"));
            Thread.Sleep(2000);
            EditEducation.Click();

            int i = 0;

            IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.Click();
            CollegeName.Clear();
            CollegeName.SendKeys(Utilities.ReadJsonData.GetData("Education[" + i + "].CollegeUniversityName"));


            //IWebElement CancelEditEducation = driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            //CancelEditEducation.Click();

            IWebElement CancelBtn1 = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            CancelBtn1.Click();
        }
        public void DeleteEducation()
        {
            //IWebElement DeleteButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[6]/span[2]/i[1]"));
            IWebElement DeleteButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            DeleteButton.Click();

            IWebElement DeleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            if(DeleteMessage.Text == "Education Entry Successfully Removed")
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
