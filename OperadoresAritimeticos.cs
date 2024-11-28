using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
        {
            public static void Executar()
                {
                    // Preço com desconto
                    var preco = 1000.0;
                    var imposto = 355;
                    var desconto = 0.1;

                    double total = preco + imposto;
                    var totalComDesconto = total - (total * desconto);
                    Console.WriteLine($"O preço final é {totalComDesconto}");

                    //IMC 
                    double peso = 79.2;
                    double altura = 1.61;
                    double imc = peso / Math.Pow(altura, 2); // Math.Pow(altura, 2) = altura * altura, ou seja, cálculo de potência
                    
                    if (imc < 18.5) 
                    {
                        Console.WriteLine("Abaixo do peso");
                    }
                    else if (imc >= 18.5 && imc < 25)
                    {
                        Console.WriteLine("Peso normal");
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        Console.WriteLine("Sobrepeso");
                    }
                    else if (imc >= 30 && imc < 35)
                    {
                        Console.WriteLine("Obesidade grau I");
                    }

                    //Número Par/Impar
                    int par = 24;
                    int impar = 55;
                    Console.WriteLine($"O número {par} é par? {par % 2 == 0}");

                }
        }
}            