using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {
    
    public class Exercicio09 {
        
        public void executarExercicio09() {
            Console.WriteLine("Exercício 09");
            Console.Write("Digite a quantidade de alunos que deseja inserir: ");
            int x = int.Parse(Console.ReadLine());
            string[] vetorNome = new string[x];
            double[] vetorNota = new double[x];
            double acumulador = 0;

            for(int i = 0; i < vetorNome.Length; i++) {
                Console.Write("Digite o nome do " + (i + 1) + "º aluno: ");
                vetorNome[i] = (Console.ReadLine());
                Console.Write("Digite a nota do " + (i + 1) + "º aluno: ");
                vetorNota[i] = double.Parse(Console.ReadLine());
                acumulador += vetorNota[i]; 
            }

            Console.WriteLine();
            double media = acumulador / vetorNota.Length;
            Console.WriteLine("Média: " + media.ToString("0.0"));

            Console.WriteLine("Nome e nota dos alunos com nota igual ou maior do que a média da turma: ");
            for(int i = 0; i < vetorNota.Length; i++) {
                if (vetorNota[i] >= media) {
                    Console.WriteLine(vetorNome[i] + " - " + vetorNota[i].ToString("0.0"));
                }
            }
            Console.ReadLine();
        }
    }

}