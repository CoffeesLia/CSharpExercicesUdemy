using System;

namespace CursoCSharp.Fundamentos
    {
        class Conversoes
        {
            public static void Executar()
            {
                int inteiro = 10;
                double quebrado = inteiro; //conversão implícita
                Console.WriteLine(quebrado); 

                //conversão explícita - pode ter perda de dados
                double nota = 9.7;
                int notaTruncada = (int)nota; //convertendo de double para int
                Console.WriteLine("Nota truncada: {0}", notaTruncada);

                Console.WriteLine("Digite sua idade: ");
                string idadeString = Console.ReadLine();
                int idadeInteiro = int.Parse(idadeString);
                Console.WriteLine("Idade inserida: {0}", idadeInteiro);

                idadeInteiro = Convert.ToInt32(idadeString);
                Console.WriteLine("Resultado: {0}", idadeInteiro);

                Console.Write("Digite o primeiro número: ");
                string palavra = Console.ReadLine();
                int numero;
                int.TryParse(palavra, out numero); //tenta converter a string para int
                Console.WriteLine("Resultado 1 : {0}", numero);

                
                Console.Write("Digite o segundo número: ");
                int.TryParse(Console.ReadLine(), out int numero2); //tenta converter a string para int
                Console.WriteLine("Resultado 2 : {0}", numero2);
             }
         }
    }     