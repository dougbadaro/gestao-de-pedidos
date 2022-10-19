using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class WindowCadastro : Form
    {
        private Pedido pedidoaux;

        private static WindowCadastro instance;
        public WindowCadastro()
        {
            InitializeComponent();

            pedidoaux = new Pedido();
        }

        public static WindowCadastro GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowCadastro();
            }

            return instance;
        }

        private void HabilitarBotao()
        {

            if (lstPesquisa.Items.Count > 0)
            {

                btnAcrescentar.Enabled = true;
            }
            else
            {
                btnAcrescentar.Enabled = false;
            }
        }

        private void btnAcrescentar_Click(object sender, EventArgs e)
        {

            Item item = new Item(Convert.ToInt16(nudQuantidade.Value), (Produto)lstPesquisa.SelectedItem);
            
            pedidoaux.AdicionarItem(item);

            lstItens.Items.Add(item);

            lblTotal.Text = $"R${pedidoaux.CalcularTotal().ToString().Replace('.', ',')}";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

            lstPesquisa.DataSource = BancoDadosSimulado.LocalizarProdutoPorParteNome(txtNome.Text);

            HabilitarBotao();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            lstPesquisa.DataSource = null;

            lstPesquisa.Items.Clear();

            if (txtCodigo.Text != String.Empty && 
                Regex.IsMatch(txtCodigo.Text, "^[0-9]+$"))
            {
                if (BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)) != null)
                {
                    lstPesquisa.Items.Add(BancoDadosSimulado.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)));
                    lstPesquisa.SelectedIndex = 0;
                }
            }

            HabilitarBotao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            foreach (Item item in pedidoaux.Items)
            {

                pedido.AdicionarItem(item);
            }

            BancoDadosSimulado.Pedidos.Add(pedido);

            pedidoaux.Items.Clear();
            lstItens.Items.Clear();
            lblTotal.Text = $"R$ --";
        }

        //private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
        //    {

        //        e.Handled = true;
        //    }
        //}
    }
}
