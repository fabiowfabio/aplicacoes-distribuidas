using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {
    
    public class Exercicio06 {

        public void executarExercicio06() {
            Console.WriteLine("Exercício 06");
            Console.Write("Digite o número do qual deseja a tabuada: ");
            int x = int.Parse(Console.ReadLine());
            
            while (x != -1) {
                for (int i = 0; i <= 10; i++) {
                    int resultado = x * i;
                    Console.WriteLine(x + " X " + i + " = " + resultado);
                }
                Console.Write("Digite o número do qual deseja a tabuada: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Fim!");
            Console.ReadKey();
        }
    }
}
