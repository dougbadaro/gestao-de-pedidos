using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    internal class BancoDadosSimulado
    {

        public static List<Produto> Produtos { get; set; }
        public static BindingList<Pedido> Pedidos { get; set; }

        static BancoDadosSimulado()
        {

            Produto abobora = new Produto(1, "Abobora", 12.20m);
            Produto abacaxi = new Produto(2, "Abacaxi", 20.00m);
            Produto abacate = new Produto(3, "Abacate", 30.00m);
            Produto banana = new Produto(4, "Banana", 40.00m);
            Produto caju = new Produto(5, "Caju", 50.00m);
            Produto caja = new Produto(6, "Cajá", 60.00m);
            Produto damasco = new Produto(7, "Damasco", 70.00m);
            Produto ervilha = new Produto(8, "Caju", 80.00m);
            Produto framboesa = new Produto(9, "Caju", 90.00m);
            Produto goiaba = new Produto(10, "Goiaba", 100.00m);

            Produtos = new List<Produto>();
            Produtos.Add(abobora);
            Produtos.Add(abacaxi);
            Produtos.Add(abacate);
            Produtos.Add(banana);
            Produtos.Add(caju);
            Produtos.Add(caja);
            Produtos.Add(damasco);
            Produtos.Add(ervilha);
            Produtos.Add(framboesa);
            Produtos.Add(goiaba);

            Pedidos = new BindingList<Pedido>();
        }

        public static Produto LocalizarProdutoPorCodigo(Int64 codigo)
        {

            Produto produtoSearch = null;

            foreach (Produto produto in Produtos)
            {

                if (produto.Codigo == codigo)
                {

                    produtoSearch = produto;
                }
            }

            return produtoSearch;
        }

        public static List<Produto> LocalizarProdutoPorParteNome(String parte)
        {

            List<Produto> produtoSearch = new List<Produto>();

            foreach (Produto produto in Produtos)
            {

                if (produto.Nome.ToLower().Contains(parte.ToLower()))
                {

                    produtoSearch.Add(produto);
                }
            }

            return produtoSearch;
        }
    }
}
