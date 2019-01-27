using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Remote;
using TestClass;



namespace ClassLibrary1
{
  
    
    public class class1
    {
        IWebDriver driver;
        
        public void startet() //Site açıldı.
        {

            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.n11.com/");

            driver.FindElement(By.ClassName("btnSignIn")).Click();
        }
        

        public void loginol() //Siteye eposta ile giriş yapıldı.
        {

            driver.FindElement(By.Id("email")).SendKeys("m.ecesural@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("8794ece");
            driver.FindElement(By.Id("loginButton")).Click();

        }
        public void search() //Arama kısmına samsung yazılıp tıklandı.

        {
            driver.FindElement(By.Id("searchData")).SendKeys("samsung");
            driver.FindElement(By.ClassName("searchBtn")).Click();

        }


        public void pages() //2.sayfaya geçildi.

        {

            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[2]")).Click();
        }

        public void follow() //2.sayfadaki 3.ürün follow edildi.Buradaki kodda bazen hata verdi.Çünkü ikinci sayfadaki istenen üçüncü ürün sürekli başka sayfalara geçmiş oluyor (Bilgisayar baştan açılınca.). Bundan dolayı ürünü bulamıyor.Siz de kodda değişiklik yapıp ürünün idsini değiştirip , 3.ürünün idsini seçebilirsiniz.
        {
            driver.FindElement(By.CssSelector("#p-302393149 span.textImg.followBtn")).Click();
        }

        public void hesabım() //Sayfanın sağ üst tarafındaki hesabıma tıklandı.
        { 
            driver.FindElement(By.XPath(".//*[@class='myAccount']/a[1]")).Click();
            driver.FindElement(By.LinkText("İstek Listelerim")).Click();

            driver.FindElement(By.LinkText("Favorilerim (1)")).Click();

        }

        public void unfollow() //Takip edilen cihaz takipten çıkarıldı ve  çıkarıldı bigisi onaylandı.

        {

            driver.FindElement(By.XPath(".//*[@id='p-302393149']/div[3]/span")).Click();

            driver.FindElement(By.XPath(".//*[@class='lightBox']/div/div/span")).Click();

          
        }

        public void kapat() //Son olarak program kapatıldı.
        {
            driver.Close();
        }
    }


}



