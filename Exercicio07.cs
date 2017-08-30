using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula02 {

    public class Exercicio07 {

        public void executarExercicio07() {
            Console.WriteLine("Exercício 07");

            string opcao;
            double totalVista = 0;
            double totalPrazo = 0;
            double totalGeral = 0;

            for(int i = 0; i < 25; i++) {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("v - à vista");
                Console.WriteLine("p - à prazo");
                opcao = Console.ReadLine();
                Console.Write("Digite o valor da compra: ");
                double valor = double.Parse(Console.ReadLine());

                if(opcao == "v") {
                    totalVista += valor;
                }
                else {
                    totalPrazo += valor;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Valor total de compras à vista: R$" + totalVista.ToString("0.00"));
            Console.WriteLine("Valor total de compras à prazo: R$" + totalPrazo.ToString("0.00"));
            Console.WriteLine("Valor da primeira parcela das compras à prazo: R$" + (totalPrazo / 3).ToString("0.00"));
            Console.WriteLine("Valor total de compras: R$" + (totalGeral = totalVista + totalPrazo).ToString("0.00"));
            Console.ReadKey();
        }
    }

}