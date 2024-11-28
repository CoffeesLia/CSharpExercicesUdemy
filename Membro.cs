using System;
using CursoCSharp;
using CentralProject.ClassesEMetodos;//+


namespace CentralProject.ClassesEMetodos
    {
        class Membro
        {
            public static void Executar()
            {
                Pessoa sicrano = new Pessoa(); // instanciando a classe Pessoa]
                sicrano.Nome = "Renato";
                sicrano.Idade = 21;

                sicrano.ApresentarNoConsole(); // dados serão obrigatoriamente retornados ao console de acordo com o encapsulamento das funcionalidades do método definido 

                {
                    var fulano = new Pessoa();
                    fulano.Nome = "Beto";
                    fulano.Idade = 25;

                    Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos.");

                    var apresentaçãoDoFulano = fulano.Apresentar(); //tem uma variedade de possibilidades, já que o método presente na variável tem apenas propriedades da instância 'Pessoa'

                }
            }
        }
    }