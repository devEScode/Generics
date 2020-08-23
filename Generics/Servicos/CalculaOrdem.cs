using System;
using System.Collections.Generic;

namespace Generics.Servicos
{
    class CalculaOrdem
    {


        public Generic Maior<Generic>(List<Generic> list) where Generic : IComparable
        {
            Generic maior = list[0];
            if (list.Count == 0)
            {
                throw new ArgumentException("A lista não pode estar vazia!");
            }

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(maior) > 0)
                {
                    maior = list[i];
                }
            }

            return maior;
        }
    }
}
