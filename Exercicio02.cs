using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {

    public class Exercicio02 {

        public void executarExercicio02() {
            Console.WriteLine("Exercício 02");

            for (int i = 0; i <= 200; i++) {
                if (i % 7 == 0) {
                    Console.WriteLine(i); 
                }
            }
            Console.ReadKey();
        }
    }

}
