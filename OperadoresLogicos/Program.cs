﻿using System;

namespace OperadoresLogicos
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança!");
            }
            else if (idade >= 12 && idade <= 20)
            {
                Console.WriteLine("Você é um adolescente!");
            }
            else if (idade >= 21 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto!");
            }
            else
            {
                Console.WriteLine("Você é um idoso!");
            }







            Console.ReadLine();
        }
    }
}