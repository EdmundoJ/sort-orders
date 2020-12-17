using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Carrinho
{
    public class MaiorMenor
    {
        public MaiorMenor()
        {
            maior = new Produto();
            menor = new Produto();
        }

        private Produto maior;
        private Produto menor;

        public void SetMaiorMenor(Produto produto)
        {
            if (!menor.Valor.HasValue || produto.Valor < menor.Valor) menor = produto;
            if (!maior.Valor.HasValue || produto.Valor > maior.Valor) maior = produto;
        }

        public void Exibir()
        {
            Console.WriteLine($"MAIOR\n" +
                $"Produto: {maior.Nome}\n"  /*+
               $"Valor: {maior.Valor}"*/);

            Console.WriteLine($"MENOR\n" +
                $"Produto: {menor.Nome}\n" /*++
                $"Valor: {menor.Valor}"*/);
            Console.ReadLine();
        }

        public List<Produto> Ordenar(List<Produto> produtos, bool asc) =>
             asc ? produtos.OrderBy(i => i.Valor).ToList() : produtos.OrderByDescending(i => i.Valor).ToList();

        
    }
}
