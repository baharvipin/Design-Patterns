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
            settings.Set("singleton" ,"app_creator");
            System.Console.WriteLine(settings.Get("singleton1"));
           // 
        }
    }
}
