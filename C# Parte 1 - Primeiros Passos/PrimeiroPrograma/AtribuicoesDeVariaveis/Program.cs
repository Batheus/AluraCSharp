using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuicoesDeVariaveis
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando programa AtribuicoesDeVariaveis");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;
            
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}