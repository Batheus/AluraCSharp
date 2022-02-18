using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoIF2
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o programa TrabalhandoIF2.");

            int idade = 18;
            // int quantidadePessoas = 3;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Seja bem vindo, pode entrar!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar");
            }

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}