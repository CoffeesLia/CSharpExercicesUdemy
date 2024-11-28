using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
    {
        class NotacaoPonto
        {
            public static void Executar()
            {
                // o ponto ajuda a acessar as funcionalidades acometidas dentro da string
                var saudacao = "olá".ToUpper().Insert(3, "World!").Replace("World!", " Mundo!"); //pode se encadear uma notação a outra em c#
                Console.WriteLine(saudacao);

                Console.WriteLine("Teste".Length); 

                string? valorImportante = null;
                Console.WriteLine(valorImportante?.Length); // o ponto de interrogação ajuda a verificar se a variável é nula
            }
        }
    }