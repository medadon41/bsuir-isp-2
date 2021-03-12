using System;
using System.Globalization;
using System.Threading;

namespace Lab2_Pt2
{
    class Program
    {
        static bool setLocale(string lang)
        {
            switch(lang)
            {
                case "ru":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-ru");
                    return true;
                case "en":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
                    return true;
                case "de":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("de-de");
                    return true;
                case "fr":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-fr");
                    return true;
                case "it":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("it-it");
                    return true;
                default:
                    return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Выберите язык (ru/en/de/fr/it): ");
            string lang = Console.ReadLine();
            while (!setLocale(lang)) {
                Console.Write("Язык не поддерживается, выберите из основных (ru/en/de/fr/it): ");
                lang = Console.ReadLine();
            };
            DateTime date = new DateTime(2021, 1, 20);
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(date.AddMonths(i).ToString("MMMM"));
            }
        }
    }
}
