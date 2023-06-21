using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator;

namespace AmountPlusDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first_income;
            string start_currency, money;
            string converting_currency;

            do
            {
                Console.WriteLine("Add the value like that ---> 50 Yena");
                first_income = Console.ReadLine().Split(' ');
                start_currency = first_income[1];
                money = first_income[0];
                if (start_currency == "$" || start_currency == "Dollar" || start_currency == "Dollars")
                {
                    Console.WriteLine("To which currency you want conver the money \"Euro € \",\"Yena ¥\"");
                }
                else if (start_currency == "€" || start_currency == "Euro" || start_currency == "Euros")
                {
                    Console.WriteLine("To which currency you want conver the money \"Dollar $ \",\"Yena ¥\"");
                } else
                {
                    Console.WriteLine("To which currency you want conver the money \"Dollar $ \",\"Euro € \"");
                }
                converting_currency = Console.ReadLine();


                TranslatorClass.RunExample(money, converting_currency, start_currency);

                Console.WriteLine("If you want to close the prog press 0");
            } while (Console.ReadLine() != "0");

        }
    }
}