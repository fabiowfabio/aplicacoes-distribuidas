using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {
    
    public class Exercicio10 {

        public void executarExercicio10() {
            Console.WriteLine("Exercício10");
            var salarios = new List<Double>();

            Boolean i = true;
            double salario;
            while(i) {
                Console.Write("Digite o salário: ");
                    salario = double.Parse(Console.ReadLine());
                if(salario == -1) {
                    i = false;
                }
                else {
                    salarios.Add(salario);
                }
            }

            Console.Write("Digite a porcentagem do reajuste: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine();
            foreach(double salarioDaVez in salarios){
                Console.WriteLine("Salário antigo: R$" + salarioDaVez.ToString("0.00") + " - Salário novo: R$" + (salarioDaVez + (salarioDaVez * (porcentagem / 100))).ToString("0.00"));
            }

            Console.ReadKey();
        }
    }

}

