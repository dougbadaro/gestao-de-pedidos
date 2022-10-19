using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class WindowPedidos : Form
    {

        private static WindowPedidos instance;
        public WindowPedidos()
        {
            InitializeComponent();

            lstPedidos.DataSource = BancoDadosSimulado.Pedidos;
        }

        public static WindowPedidos GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowPedidos();
            }

            return instance;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {

            WindowCadastro wcadastro = WindowCadastro.GetInstance();
            wcadastro.MdiParent = this.MdiParent;
            wcadastro.WindowState = FormWindowState.Normal;
            wcadastro.Show();
        }
    }
}
