using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos; 


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            // Dicionário de exercícios
            var exercicios = new Dictionary<string, Action> 
            {
                { "Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                { "Inferência - Fundamentos", Inferencia.Executar },
                { "Interpolação de String - Fundamentos", InterpolacaoDeString.Executar }
            };

            // Instanciando e executando a CentralDeExercicios
            var central = new CentralDeExercicios(exercicios);
            central.SelecionarEExecutar();
        }
    }
}

public class CentralDeExercicios {
    private Dictionary<string, Action> exerciciosList;

    public CentralDeExercicios(Dictionary<string, Action> exercicios) {
        exerciciosList = exercicios;    
    }

    public void SelecionarEExecutar() {
        int i = 1;

        foreach (var exercicio in exerciciosList) {
            Console.WriteLine("{0}) {1}", i++, exercicio.Key);
        }

        Console.Write("Digite o número (ou vazio para o último)? ");
        int.TryParse(Console.ReadLine(), out int num);
        bool numValido = num > 0 && num <= exerciciosList.Count;
        num = numValido ? num - 1 : exerciciosList.Count - 1;

        string nomeDoExercicio = exerciciosList.ElementAt(num).Key;

        Console.Write("\nExecutando exercício ");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(nomeDoExercicio);
        Console.ResetColor();

        Console.WriteLine(String.Concat(
            Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

        Action executar = exerciciosList.ElementAt(num).Value;
        try {
            executar();
        } catch(Exception e) {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ocorreu um erro: {0}", e.Message);
            Console.ResetColor();

            Console.WriteLine(e.StackTrace);
        }
    }
}
