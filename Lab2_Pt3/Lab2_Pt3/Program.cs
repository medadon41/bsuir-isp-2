using System;
using System.Text;

namespace Lab2_Pt3
{
    class Program
    {
        static bool vowCheck(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'y' || ch == 'u')
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder(256);

            string str_temp;

            str_temp = Console.ReadLine();

            str.Append(str_temp);

            int currentCode;

            for (int i = 1; i < str.Length; i++)
            {
                if (vowCheck(str[i - 1])) {
                    currentCode = (int)str[i];
                    switch (str[i])
                    {
                        case 'z':
                            str[i] = (char)97;
                            break;
                        default:
                            str[i] = (char)(currentCode + 1);
                            break;
                    }
                }
            }

            Console.WriteLine(str);
        }
    }
}
