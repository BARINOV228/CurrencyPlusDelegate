using System;
using System.Diagnostics;

namespace Translator
{
    public delegate double MyDelegate(string x, string y);

    public class TranslatorClass
    {
        MyDelegate[] delegates = new MyDelegate[] { Yena, Dollar, Euro };

        static double Yena(string yen, string value)
        {
            double DollarCost = 0.0071;
            double EuroCost = 0.0065;

            if (value == "Dollar" || value == "$")
            {
                double yenAmount = double.Parse(yen);
                double dollars = yenAmount * DollarCost;
                Console.WriteLine(yenAmount + " yen is equal to " + dollars + " dollars.");
                return dollars;
            }
            else if (value == "Euro" || value == "€")
            {
                double yenAmount = double.Parse(yen);
                double euros = yenAmount * EuroCost;
                Console.WriteLine(yenAmount + " yen is equal to " + euros + " euros.");
                return euros;
            }
            else
            {
                Console.WriteLine("Unsupported currency.");
                return 0;
            }
        }

        static double Dollar(string dol, string value)
        {
            double YenasCost = 141.78;
            double EoroCost = 0.92;

            if (value == "Yena" || value == "¥")
            {
                double dolAmount = double.Parse(dol);
                double yenas = dolAmount * YenasCost;
                Console.WriteLine(dolAmount + " dollars is equal to " + yenas + " yen.");
                return yenas;
            }
            else if (value == "Euro" || value == "€")
            {
                double dolAmount = double.Parse(dol);
                double euro = dolAmount * EoroCost;
                Console.WriteLine(dolAmount + " dollars is equal to " + euro + " euros.");
                return euro;
            }
            else
            {
                Console.WriteLine("Unsupported currency.");
                return 0;
            }
        }

        static double Euro(string eu, string value)
        {
            double DollarCost = 1.09;
            double YenaCost = 154.68;

            if (value == "Yena" || value == "¥")
            {
                double euroAMount = double.Parse(eu);
                double yena = euroAMount * YenaCost;
                Console.WriteLine(euroAMount + " euros is equal to " + yena + " yen.");
                return yena;
            }
            else if (value == "Dollar" || value == "$")
            {
                double euroAmount = double.Parse(eu);
                double dollar = euroAmount * DollarCost;
                Console.WriteLine(euroAmount + " euros is equal to " + dollar + " dollars.");
                return dollar;
            }
            else
            {
                Console.WriteLine("Unsupported currency.");
                return 0;
            }
        }

        public static void RunExample(string x, string y, string z)
        {
            TranslatorClass translator = new TranslatorClass();



            switch (z)
            {
                case "Yena":
                    translator.delegates[0](x, y);
                    break;

                case "¥":
                    translator.delegates[0](x, y);
                    break;

                case "Dollar":
                    translator.delegates[1](x, y);
                    break;

                case "$":
                    translator.delegates[1](x, y);
                    break;

                case "Euro":
                    translator.delegates[2](x, y);
                    break;
                case "€":
                    translator.delegates[2](x, y);
                    break;
                default:
                    throw new ArgumentException("Unsupported currency.");
            }

        }
    }
}