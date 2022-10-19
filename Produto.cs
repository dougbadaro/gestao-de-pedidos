using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    internal class Produto
    {

        public Int64 Codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        public Produto()
        {
        }

        public Produto(long codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome} [R${Preco}]";
        }
    }
}
