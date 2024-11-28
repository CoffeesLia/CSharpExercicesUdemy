using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
    {
        class LendoDados
        {
            public static void Executar()
            {
                Console.Write("Qual é o seu nome? ");
                string nome = Console.ReadLine();

                //por padrão as inserções em 'Console.ReadLine' são lidas como strings
                Console.Write("Qual é sua idade?");
                int idade = int.Parse(Console.ReadLine()); // o 'int.Parse' converte a string em int

                Console.Write("Qual é o seu salário? ");
                double salario = double.Parse(Console.ReadLine()); // o 'double.Parse' converte a string em double

                Console.WriteLine($"{nome} {idade} R$ {salario}");
            }

        }
    }