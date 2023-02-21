using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta05
{
    public static class TextView
    {
        public static string GetOption()
        {
            Console.Write("Deseja refazer? (0 para Não / 1 para Sim): ");
            return Console.ReadLine();
        }

        public static double GetValue()
        {
            Console.Write("Informe o Valor (em R$): ");
            string val = Console.ReadLine().Replace('.', ',');

            return Convert.ToDouble(val);
        }
    }
}
