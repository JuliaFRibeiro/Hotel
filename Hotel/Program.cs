using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando a classe
            Estudante[] vect = new Estudante[10];

            //interação com usuario
            Console.WriteLine("Quartos à serem alugados:");
            //quantidade de quartos 
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                //informações dadas pelo usuario
                Console.WriteLine();
                Console.WriteLine($"Hospede #{i}");
                Console.WriteLine("Nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Email");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            //interação com usuario
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                //condiçao
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
