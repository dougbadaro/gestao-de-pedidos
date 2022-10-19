using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    internal class Pedido
    {

        public static Int64 Serial { get; private set; }
        public Int64 NotaFiscal { get; set; }
        public List<Item> Items { get; set; }


        static Pedido()
        {

            Serial = Convert.ToInt64(DateTime.Now.Year.ToString().Substring(2)) * 1000000;
        }
        public Pedido()
        {

            Items = new List<Item>();
            NotaFiscal = Serial;
            Serial += 1;
        }

        public void AdicionarItem(Item item)
        {

            Items.Add(item);
        }

        public Decimal CalcularTotal()
        {

            Decimal total = 0;

            foreach (Item item in Items)
            {
                total += item.CalcularTotal();
            }

            return total;
        }

        public override string ToString()
        {
            
            return $"> {NotaFiscal} R${CalcularTotal()}";
        }
    }
}
