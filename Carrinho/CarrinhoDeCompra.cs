using System;
using System.Collections.Generic;
using System.Text;

namespace Carrinho
{
    public class CarrinhoDeCompra
    {
        public List<Produto> Produtos { get; set; }

        public CarrinhoDeCompra()
        {
            Produtos = new List<Produto>();
        }

        //ADICIONA O PRODUTO NA LISTA
        public void Adicionar(Produto p)
        {
            Produtos.Add(new Produto(p.Nome, (double)p.Valor));
        }

        //EXIBA OS PRODUTOS INSERIDOS
        public void Exibir()
        {
            foreach (Produto p in Produtos)
            {
                Console.WriteLine(p.Nome + " " + p.Valor);
            }
            Console.ReadLine();
        }

        //CONFIRMA SE EXISTE NA LISTA E TRAZ VALOR DIGITADO
        public void filtro(Produto p)
        {

            List<Produto> f = Produtos.FindAll(x => x.Nome == p.Nome);
            foreach (Produto obj in f)
            {
                Console.WriteLine("O solicitado é:" + p.Nome);
            }
            Console.ReadLine();

        }

    }
}
