using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o programa TrabalhandoIF2.");

            int idade = 18;
            int quantidadePessoas = 3;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;
            string mensagemAdicional;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                acompanhado = false;
                mensagemAdicional = "João não está acompanhado!";
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo, pode entrar!");
                Console.WriteLine(mensagemAdicional);
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