using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaAumento
    {
        // Método para calcular o aumento salarial
        public static void CalcularAumento(double salarioAtual, double percentualAumento)
        {
            double aumento = salarioAtual * (percentualAumento / 100);
            double novoSalario = salarioAtual + aumento;

            // Exibindo as informações
            Console.WriteLine($"\nSalário Inicial: R${salarioAtual:F2}");
            Console.WriteLine($"Percentual de Aumento: {percentualAumento}%");
            Console.WriteLine($"Valor do Aumento: R${aumento:F2}");
            Console.WriteLine($"Novo Salário: R${novoSalario:F2}");
        }

        static void Main(string[] args)
        {
            // Solicitar ao usuário o salário atual e o percentual de aumento
            Console.Write("Digite o valor do salário atual: R$");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de aumento: ");
            double percentualAumento = Convert.ToDouble(Console.ReadLine());

            // Chamando o método para calcular o aumento e exibir as informações
            CalcularAumento(salarioAtual, percentualAumento);
        }
    }
}
