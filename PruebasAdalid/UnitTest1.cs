using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace PruebasAdalid
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"D:\03.PROYECTOS\01.BNBPUNTOS\PROYECTO REST\DesarrolloBNB");


            driver.Navigate().GoToUrl("http://apps.supernet.bo/ic/Autentication.aspx");
            Thread.Sleep(500);
            driver.FindElement(By.Id("IFMainContent_txtLogin")).Click();
            driver.FindElement(By.Id("IFMainContent_txtLogin")).Clear();
            driver.FindElement(By.Id("IFMainContent_txtLogin")).SendKeys("dmanzano@bnb.com.bo");
            driver.FindElement(By.Id("IFMainContent_txtPasswd")).Click();
            driver.FindElement(By.Id("IFMainContent_txtPasswd")).Clear();
            driver.FindElement(By.Id("IFMainContent_txtPasswd")).SendKeys("Daniela123*");
            driver.FindElement(By.Id("IFMainContent_btnEntrar")).Click();
            Thread.Sleep(1000);

            driver.Close();
        

        }
    }
}
