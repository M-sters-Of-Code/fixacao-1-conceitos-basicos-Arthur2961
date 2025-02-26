using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class AluguelCarro
    {
        // Método para calcular o valor total a ser pago pelo aluguel do carro
        public static void CalcularAluguel(int diasAlugados, double kmInicial, double kmFinal)
        {
            double diaria = 95.00;
            double valorKm = 0.35;

            // Cálculos
            double totalDiarias = diasAlugados * diaria;
            double totalKm = (kmFinal - kmInicial) * valorKm;
            double totalPago = totalDiarias + totalKm;

            // Exibindo as informações
            Console.WriteLine($"\nValor da Diária: R${diaria:F2}");
            Console.WriteLine($"Total de Diárias: R${totalDiarias:F2}");
            Console.WriteLine($"Quilometragem Percorrida: {kmFinal - kmInicial} km");
            Console.WriteLine($"Valor Total por Quilometragem: R${totalKm:F2}");
            Console.WriteLine($"Valor Total a Pagar: R${totalPago:F2}");
        }

        static void Main(string[] args)
        {
            // Solicitar ao usuário os dados necessários
            Console.Write("Digite o número de dias alugados: ");
            int diasAlugados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            // Chamando o método para calcular e exibir os resultados
            CalcularAluguel(diasAlugados, kmInicial, kmFinal);
        }
    }
}
