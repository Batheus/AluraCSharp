using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEncadeado
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o programa ForEncadeado.");

            Console.WriteLine("Primeira forma do programa, com BREAK:");
            // Escrevendo asteriscos com o BREAK
            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Segunda forma do programa, sem BREAK:");
            // Uma forma alternativa do programa acima
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}