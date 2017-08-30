using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {
    
    public class Exercicio01 {

        public void executarExercicio01() {
            Console.WriteLine("Exercício 01");
            int acum = 0;

            for (int i = 1; i <= 100; i++) {
                acum += i;
            }
            Console.WriteLine(acum);
            Console.ReadKey();
        }
    }
    
}
