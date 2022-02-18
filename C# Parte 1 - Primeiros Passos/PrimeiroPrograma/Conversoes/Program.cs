using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversoes
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto CriandoVariaveis");

            // O long é uma variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            float pontoFlutuante = 3.14f;

            // O int é um tipo de variável que suporta valores ate 32 bits
            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}