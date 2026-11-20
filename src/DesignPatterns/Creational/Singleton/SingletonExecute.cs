namespace ConsoleApp.src.DesignPatterns.Creational.Singleton
{
    public class SingletonExecute
    {
        public void Run()
        {
            var settings = AppSettings.GetInstance();
            settings.Set("singleton", "app_creator");
            System.Console.WriteLine(settings.Get("singleton1"));
        }
    }
}
