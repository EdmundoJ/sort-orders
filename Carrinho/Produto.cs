using System;
using System.Collections.Generic;
using System.Text;

namespace Carrinho
{
    public class Produto
    {
        public Produto() { }

        public string Nome { get; set; }
        public double? Valor { get; set; }


        public Produto(string pnome, double pvalor)
        {
            Nome = pnome;
            Valor = pvalor;
        }
    }
}
