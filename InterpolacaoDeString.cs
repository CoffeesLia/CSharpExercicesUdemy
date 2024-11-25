using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
    {
        class InterpolacaoDeString
        {
            public static void Executar()
            {
                string nome = "Notebook Gamer";
                string marca = "Dell";
                double preco = 5800.00;

                Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + "."); // formatação por concatenação que gruda um tipo ao outro
                Console.WriteLine("O {0} da marca {1} custa R$ {1}2.", nome, marca, preco); // formatação em que número substitui os números
                Console.WriteLine($"O {nome} da marca {marca} custa R$ {preco}."); // nome da variável é colocado entre chaves 
            }
        }
    }