using System;
using System.Globalization;
using System.Threading;

namespace Lab2_Pt2
{
    class Program
    {
        static void setLocale()
        {
            Console.Write("Выберите язык (ru/en/de/fr/it): ");
            switch(Console.ReadLine())
            {
                case "ru":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-ru");
                    break;
                case "en":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
                    break;
                case "de":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("de-de");
                    break;
                case "fr":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-fr");
                    break;
                case "it":
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("it-it");
                    break;
            }
        }
        static void Main(string[] args)
        {
            setLocale();
            DateTime date = new DateTime(2021, 1, 20);
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(date.AddMonths(i).ToString("MMMM"));
            }
        }
    }
}
