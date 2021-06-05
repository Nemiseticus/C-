using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA E SAÍDA DE DADOS
            //LENDO E ESCREVENDO NO CONSOLE

            Console.WriteLine("Olá Mundo/Usuário");

            string texto = "Qual o seu nome: ";
            //ESCREVER
            Console.Write(texto);
            //LER
            string nome = Console.ReadLine();

            string texto1 = "Qual o seu gênero: ";
            //ESCREVER
            Console.Write(texto1);
            string genero = Console.ReadLine();

            string texto2 = "Qual e sua idade: ";
            //ESCREVER
            Console.Write(texto2);
            string idade = Console.ReadLine();







            Console.WriteLine("Nome: "+nome+ " do gênero: "+ genero+ " e com "+ idade+ " anos de idade.");
            


            Console.ReadLine();
        }
    }
}
