using System;
using System.Globalization;

namespace Generics.Classes
{
    class Produtos : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Produtos))
            {
                throw new ArgumentException("Erro na comparação: O argumento não é um produto!");
            }

            Produtos outros = obj as Produtos;
            return Preco.CompareTo(outros.Preco);
        }

        public override string ToString()
        {
            return $"{Nome}, {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
