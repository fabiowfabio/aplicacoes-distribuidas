using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {
    
    public class Exercicio05 {

        public void executarExercicio05() {
            Console.WriteLine("Exercício 5 usando for: ");

            for (int i = 0; i <= 10; i++) {
                int resultado = 5 * i;
                Console.WriteLine("5 X " + i + " = " + resultado);
            }

            Console.WriteLine("Exercicio 5 usando while: ");
          
            int y = 0;
            while(y <= 10) {
                int resultado = 5 * y;
                Console.WriteLine("5 X " + y + " = " + resultado);
                y++; 
            }
            Console.ReadKey();
        }
    }
}
