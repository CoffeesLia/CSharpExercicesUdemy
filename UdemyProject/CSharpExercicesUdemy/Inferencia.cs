using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
    {
        class Inferencia
        {
            public static void Executar()
            {
                var nome = "Leonardo"; // a declaração de uma variável pode se assemelhar a linguagens que não tem um tipo forte
                Console.WriteLine(nome); //a inferência  não pode ter o tipo trocado, por exemplo, uma variável string não pode ser alterada para uma variável int. 

                // int idade; /n idade = 32;
                var Idade = 32;//uma variável de tipo implícito deve ser inicializada. ex.: var = idade; /n idade = 35; não será computada
                Console.WriteLine(Idade);

                int a; // não tem problema declarar uma variável com tipo explícito e atribuir valor a ela em outra linha
                a = 3; // a variável já foi atribuída no programa, por isso não precisa declarar seu tipo.
                
                int b = 2;

                Console.WriteLine (a + b);
            }
        }
    }