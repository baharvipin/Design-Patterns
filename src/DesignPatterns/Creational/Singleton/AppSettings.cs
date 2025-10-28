using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.src.DesignPatterns.Creational.Singleton
{
    public class AppSettings
    {
        private static AppSettings _instance;
        private Dictionary<string, object> _settings = new Dictionary<string, object>();
         
        private AppSettings() { } // Constructor should be private so that it can not be created again and again as, Singleton design patterns restrict it
         
        // Since we have restricted to create new instance, so we have to write a method that return only one instance for global use purpose
        public static AppSettings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }

        public object Get(string key)
        {

            if (!_settings.ContainsKey(key))
                return null;

            return _settings[key];
        }

        public void Set(string key, object value)
        {
            _settings[key] = value;
        }
    }
}
