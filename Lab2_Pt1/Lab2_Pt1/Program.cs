using System;
using System.Text;

namespace Lab2_Pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder r_text = new StringBuilder(256);

            string text = Console.ReadLine();

            string[] words = text.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                r_text.Append($"{words[i]} ");
            }

            Console.WriteLine(r_text);
        }
    }
}
