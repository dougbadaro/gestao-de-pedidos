using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    internal class Item
    {

        public Int16 Quantidade { get; set; }
        public Produto Produto { get; set; }

        public Item()
        {
        }

        public Item(Int16 quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        public override string ToString()
        {

            return $"{Quantidade} x {Produto.Nome} [R${Produto.Preco}] = R${CalcularTotal()}";
        }
    }
}
