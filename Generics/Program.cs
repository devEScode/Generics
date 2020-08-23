using Generics.Classes;
using Generics.Servicos;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma empresa de consultoria deseja avaliar a performance de produtos,
            funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
            o maior dentre um conjunto de elementos. Fazer um programa que leia um
            conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles.
            Criar um serviço de cálculo:
                Enter N: 3 
                Computer,890.50
                IPhone X,910.00
                Tablet,550.00
                Max:
                IPhone, 910.00
            */

            List<Produtos> list = new List<Produtos>();
            Console.Write("Entre Nº: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string nome = vet[0];
                double preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
                list.Add(new Produtos(nome, preco));
            }

            Console.Write("Maior: ");
            CalculaOrdem ordem = new CalculaOrdem();

            Produtos produto = ordem.Maior(list);
            Console.WriteLine(produto);
        }
    }
}
