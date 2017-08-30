using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {

    public class Exercicio04 {

        public void executarExercicio04() {
            Console.WriteLine("Exercício 04");
            Console.Write("Digite o valor de X: ");
            double x = double.Parse(Console.ReadLine());

            double resultado = 0;
            double sinal = 1;

            for (int i = 1; i <= 20; i++) {
                resultado += sinal * (x / i);
                sinal = sinal * (-1);
                Console.WriteLine(resultado);
            }
            Console.ReadKey();
        }
    }
}
