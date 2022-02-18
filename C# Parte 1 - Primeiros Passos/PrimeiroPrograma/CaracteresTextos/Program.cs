using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresTextos
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando programa CaracteresTextos.");

            char letra = 'a';
            Console.WriteLine(letra);
            char valor = (char)65;  // Compila!
            Console.WriteLine(valor);
            valor = (char)(valor + 1);  // Compila!
            Console.WriteLine(valor);
            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.WriteLine("A execução acabou, pressione Enter para fechar essa janela...");
            Console.ReadLine();
        }
    }
}