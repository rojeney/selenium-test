using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_App
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("C:\\rojeney\\chromedriver_win32");
            // This will open up the URL 
            driver.Url = "https://www.geeksforgeeks.org/";//open url

            IWebElement searchBox = driver.FindElement(By.Id("gsc-i-id2"));
            searchBox.Clear();
            searchBox.SendKeys("search");// enter "search" in search box

            IWebElement button = driver.FindElement(By.XPath("//*[@id=\"___gcse_1\"]/div/div/form/table/tbody/tr/td[2]/button"));
            button.Click(); // click the search button
        }
    }
}
