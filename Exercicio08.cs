using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {

    public class Exercicio08 {

        public void executarExercicio08() {
            Console.WriteLine("Exercício 08");
            Console.Write("Digite quantas notas deseja inserir: ");
            int x = int.Parse(Console.ReadLine());
            double acumulador = 0;
            double media;
            double[] vetorNotas = new double[x];

            for(int i = 0; i < vetorNotas.Length; i++) {
                Console.Write("Digite a " + (i + 1) + "ª nota: ");
                vetorNotas[i] = double.Parse(Console.ReadLine());
                acumulador += vetorNotas[i];
            }

            Console.WriteLine();
            media = acumulador / vetorNotas.Length;
            Console.WriteLine("Média: " + media.ToString("0.0"));

            Console.Write("Notas iguais ou acima da média: ");
            for(int i = 0; i < vetorNotas.Length; i++) {
                if(vetorNotas[i] >= media) {
                    Console.Write(vetorNotas[i].ToString("0.0") + "  ");
                }
            }

            Console.WriteLine();
            Console.Write("Notas abaixo da média: ");
            for(int i = 0; i < vetorNotas.Length; i++) {
                if(vetorNotas[i] < media) {
                    Console.Write(vetorNotas[i].ToString("0.0") + " ");        
                }
            }
            Console.ReadLine();
        }
    }
            
}