using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {
    
    public class Exercicio03 {
        
        public void executarExercicio03() {
            Console.WriteLine("Exercício 03");
            
            for (int i = 0; i < 100; i++) {
                if (i % 4 == 0) {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }

}
