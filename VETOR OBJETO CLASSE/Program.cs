using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETOR_OBJETO_CLASSE {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            Product[] Vetor = new Product[N];
            for (int i = 0; i < N; i++) {

                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Vetor[i] = new Product { Name = nome, Price = preco };

            }
            double soma = 0.0;

            for (int i = 0; i < N; i++) {

                soma += Vetor[i].Price;

            }
            double mediaFinal = soma / N;
            Console.WriteLine("Preço Medio = " + mediaFinal.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        } 
    }
}
