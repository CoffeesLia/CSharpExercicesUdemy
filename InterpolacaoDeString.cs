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

                Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");
            }
        }
    }