using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoIF
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o programa TrabalhandoIF.");

            int idade = 20;
            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Você não tem 18, mas pode entrar, "
                  + "pois está acompanhado");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar");
                }

            }

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}