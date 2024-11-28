using System;
using System.Collections.Generic;

class Program {
    static void Executar(string[] args) {
        while (true) {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Verificar se um número é primo");
            Console.WriteLine("2. Encontrar todos os números primos em uma faixa");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    VerificarNumeroPrimo();
                    break;
                case "2":
                    EncontrarPrimosNaFaixa();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void VerificarNumeroPrimo() {
        Console.Write("Digite um número: ");
        if (int.TryParse(Console.ReadLine(), out int numero)) {
            if (EhPrimo(numero)) {
                Console.WriteLine($"{numero} é um número primo.");
            } else {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        } else {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }

    static void EncontrarPrimosNaFaixa() {
        Console.Write("Digite o número inicial da faixa: ");
        if (int.TryParse(Console.ReadLine(), out int inicio) && inicio >= 0) {
            Console.Write("Digite o número final da faixa: ");
            if (int.TryParse(Console.ReadLine(), out int fim) && fim >= inicio) {
                List<int> primos = EncontrarPrimos(inicio, fim);
                Console.WriteLine($"Números primos entre {inicio} e {fim}: {string.Join(", ", primos)}");
            } else {
                Console.WriteLine("Entrada inválida. O número final deve ser maior ou igual ao número inicial.");
            }
        } else {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro não negativo.");
        }
    }

    static bool EhPrimo(int numero) {
        if (numero <= 1) return false;
        if (numero == 2) return true;

        for (int i = 2; i <= Math.Sqrt(numero); i++) {
            if (numero % i == 0) return false;
        }

        return true;
    }

    static List<int> EncontrarPrimos(int inicio, int fim) {
        List<int> primos = new List<int>();

        for (int i = inicio; i <= fim; i++) {
            if (EhPrimo(i)) {
                primos.Add(i);
            }
        }

        return primos;
    }
}