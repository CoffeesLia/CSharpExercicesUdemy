using System.Globalization;

namespace CursoCSharp.Fundamentos
    {
        class FormatandoNumero
        {
            public static void Executar()
            {
                double valor = 15.175;
                Console.WriteLine(valor.ToString("F1")); //converte o valor numéreico para uma string
                Console.WriteLine(valor.ToString("C")); // número como valor monetário de acordo com o sistema operacional
                Console.WriteLine(valor.ToString("P")); //número transformado para porcentagem (ainda em decimal)
                Console.WriteLine(valor.ToString("#.##")); //número com duas casa decimais

                CultureInfo cultura = new CultureInfo("en-US");
                Console.WriteLine(valor.ToString("C0", cultura));// 'C0' é o formato de moeda sem casas decimais

                int inteiro = 256;
                Console.WriteLine(inteiro.ToString("D10")); //número com 10 dígitos
                
            }
        }
    }