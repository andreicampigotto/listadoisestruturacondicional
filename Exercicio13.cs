﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciciosListadeEstruturaCondicional
{
    class Exercicio13
    {
        public Exercicio13()
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            if (n1 < n2)
            {
                Console.WriteLine("O primeiro número é menor");
            }

            else if (n2 < n1)
            {
                Console.WriteLine("O segundo número é menor");
            }
        }
    }
}
