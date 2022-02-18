using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveisDouble
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto CriandoVariaveisDouble");

            double salario = 1250.70;
            Console.WriteLine(salario);
            Console.WriteLine("Meu salario é " + salario);
            int divisaoInt = 5 / 2;
            Console.WriteLine(divisaoInt);
            double divisaoDouble = 5.0 / 2;
            Console.WriteLine(divisaoDouble);

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}