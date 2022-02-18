using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPoupanca2
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o programa CalculoPoupanca2.");

            double valorInvestido = 1000;
            for(int contadorMes = 1; contadorMes <= 10; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + Math.Round(valorInvestido, 2));
            }

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}