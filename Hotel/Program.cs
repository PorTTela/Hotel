using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospedes[] vect = new Hospedes[10];

            Console.WriteLine(" --- HOTEL PARA ALUNOS --- ")
            Console.Write("Quantos alunos são?");
            int alunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < alunos; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Hospedes { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Relátorio de Quartos Alugados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine("Quarto " + i + ": " + vect[i].Nome + ", " + vect[i].Email);
                }
            }



        }
    }
}
