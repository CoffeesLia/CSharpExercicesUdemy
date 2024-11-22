using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
         //area da circunferência
         double raio = 4.5;
         const double PI = 3.14;

         raio = 5.5;
         // A constante PI não pode ser alterada

         double area = PI * raio * raio;
         Console.WriteLine(area);
         Console.WriteLine("Área é " + area); //Concatenação

         //tipos internos - inteiros
         bool estaChovendo = true;
         Console.WriteLine("Esta Chovendo " + estaChovendo);

         byte idade = 45;
         Console.WriteLine("Idade " + idade);

         sbyte saldoDeGols = sbyte.MinValue; //-128 até 127 - byte com sinal
         Console.WriteLine("Saldo de Gols " + saldoDeGols);

         short salario = short.MaxValue; //32000
         Console.WriteLine("Salário " + salario);

         int menorValorInt = int.MinValue; // mais usado dos inteiros 
         Console.WriteLine("Menor Valor Int " + menorValorInt);

         uint populacaoBrasileira = 207_600_000; //inteiro sem sinal
         Console.WriteLine("População Brasileira " + populacaoBrasileira);

         long menorValorLong = long.MinValue; 
         Console.WriteLine("Menor Valor Long " + menorValorLong);

         ulong populacaoMundial = 7_600_000_000; //long sem sinal
         Console.WriteLine("População Mundial " + populacaoMundial);

         // tipos reais

        }
    }
}