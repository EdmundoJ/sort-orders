using System;

namespace Carrinho
{
    class Program
    {

        static void Main(string[] args)
        {
            CarrinhoDeCompra carrinho = new CarrinhoDeCompra();
            MaiorMenor util = new MaiorMenor();
            Produto p = new Produto();           

            int escolha = 10;

            while (escolha != 0)
            {
                Console.Clear();

                Console.WriteLine("Testes\n\n");

                Console.WriteLine("informe o numero da opcao desejada\n\n");

                Console.WriteLine("1- Adicionar item ao carrinho\n");

                Console.WriteLine("2- Um unico produto\n");

                Console.WriteLine("3- Carrinho não ordenado\n");

                Console.WriteLine("4- Carrinho em ordem crescente\n");

                Console.WriteLine("5- Carrinho em ordem decrescente\n");

                Console.WriteLine("6- Produtos de maior e menor valor\n");

                Console.WriteLine("0 - sair\n");
                try {                
                escolha = Int32.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:

                        //Recebe Itens na lista
                        Console.WriteLine("Digite o nome do produto para inserir no carrinho:");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o valor do produto:");
                        p.Valor = double.Parse(Console.ReadLine());
                        carrinho.Adicionar((p));


                        break;

                    case 2:
                        Console.WriteLine("Digite o nome do produto :");
                        p.Nome = Console.ReadLine();
                        carrinho.filtro(p);

                        break;

                    case 3:

                        carrinho.Exibir();

                        
                        break;
                    case 4:
                        carrinho.Produtos = util.Ordenar(carrinho.Produtos, asc: true);
                        carrinho.Exibir();
                        break;

                    case 5:
                        carrinho.Produtos = util.Ordenar(carrinho.Produtos, asc: false);
                        carrinho.Exibir();
                        break;
                    case 6:
                        for (int i = 0; i < carrinho.Produtos.Count; i++)
                            util.SetMaiorMenor(carrinho.Produtos[i]);
                        util.Exibir();
							break;

						default:
                        Console.WriteLine("Você deve escolher uma das opcoes descritas.");
                        break;
                }
                }
                catch
                {
                    Console.WriteLine("Informe um valor valido.\n\n "+"Pressione Enter para continuar");

                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
        
    }
}
