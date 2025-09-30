using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.Singleton
{
    public class SingletonExecute
    {
        public void Run()
        {
            var settings = AppSettings.GetInstance();
            System.Console.WriteLine(settings.Get("app_creator"));
        }
    }
}
