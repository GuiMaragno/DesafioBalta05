using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "1";

            do
            {
                Console.Clear();

                Double val = TextView.GetValue();

                if (val <= 999.99d) 
                {
                    Console.WriteLine("\nResultado: ");
                    Console.WriteLine(ValuesInWords.GetValuesInWords(val.ToString("F2")) + "\n");
                } else
                {
                    Console.WriteLine("Sistema feito para valores até R$999,99!");
                }

                option = TextView.GetOption();
            } while (!option.Equals("0"));
        }
    }
}
