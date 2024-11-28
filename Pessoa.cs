using System;
using System.Collections.Generic;
using System.Text;

namespace CentralProject
    {
        public class Pessoa
        {

                public string ?Nome { get; set;}
                public int Idade; // int = valor padrão 0

                public string Apresentar()
                {
                    return string.Format($"Olá, me chamo {Nome} e tenho {Idade} anos.");
                }

                  //
                public void ApresentarNoConsole()
                {
                    Console.WriteLine(Apresentar());
                }

        }
    }