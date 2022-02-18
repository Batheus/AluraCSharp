using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto CriandoVariaveis");

            int idade = 37;
            Console.WriteLine(idade);
            Console.WriteLine("A idade é " + idade + ", parabéns!");

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}