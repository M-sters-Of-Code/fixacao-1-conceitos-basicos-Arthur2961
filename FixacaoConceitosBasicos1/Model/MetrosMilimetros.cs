using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class MetrosMilimetros
    {
        // Método para converter metros para milímetros
        public static double ConverterParaMilimetros(double metros)
        {
            return metros * 1000;
        }

        // Método Main para capturar entrada do usuário e exibir o resultado
        static void Main(string[] args)
        {
            // Solicitando a entrada do usuário
            Console.Write("Digite o valor em metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            // Chamando a função para converter metros para milímetros
            double milimetros = ConverterParaMilimetros(metros);

            // Exibindo o resultado
            Console.WriteLine($"{metros} metros equivalem a {milimetros} milímetros.");
        }
    }
}
