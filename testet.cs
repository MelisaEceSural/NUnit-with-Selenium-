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
    [TestFixture]
    public class testet
    {
        [Test]

        public void start()
        {
            class1 ilk = new class1();
            ilk.startet();
            ilk.loginol();
            ilk.search();
            ilk.pages();
            ilk.follow();
            ilk.hesabım();
            ilk.unfollow();
            ilk.kapat();

        }

    }
}
