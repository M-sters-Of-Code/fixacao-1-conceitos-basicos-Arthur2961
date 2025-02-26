using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
    {
        internal class CalculaDesconto
        {
            // Método para calcular o desconto e o valor final
            public static void CalcularDesconto(double valorMercadoria, double percentualDesconto)
            {
                double desconto = valorMercadoria * (percentualDesconto / 100);
                double valorFinal = valorMercadoria - desconto;

                // Exibindo as informações
                Console.WriteLine($"\nValor Atual da Mercadoria: R${valorMercadoria:F2}");
                Console.WriteLine($"Percentual de Desconto: {percentualDesconto}%");
                Console.WriteLine($"Valor do Desconto: R${desconto:F2}");
                Console.WriteLine($"Valor Final da Mercadoria: R${valorFinal:F2}");
            }

            static void Main(string[] args)
            {
                // Solicitar ao usuário o valor da mercadoria e o percentual de desconto
                Console.Write("Digite o valor atual da mercadoria: R$");
                double valorMercadoria = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o percentual de desconto: ");
                double percentualDesconto = Convert.ToDouble(Console.ReadLine());

                // Chamando o método para calcular o desconto e exibir as informações
                CalcularDesconto(valorMercadoria, percentualDesconto);
            }
        }
    }
