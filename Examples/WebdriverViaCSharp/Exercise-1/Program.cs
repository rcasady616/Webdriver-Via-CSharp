using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            cDriver.Navigate().GoToUrl("http://RickCasady.com");
            System.Threading.Thread.Sleep(7000);
            cDriver.Dispose();
        }
    }
}
