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
    public partial class WindowMain : Form
    {

        private static WindowMain instance;
        public WindowMain()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            new BancoDadosSimulado();
        }

        public static WindowMain GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {

                instance = new WindowMain();
            }

            return instance;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowPedidos wpedidos = WindowPedidos.GetInstance();
            wpedidos.MdiParent = this;
            wpedidos.WindowState = FormWindowState.Normal;
            wpedidos.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowProdutos wprodutos = WindowProdutos.GetInstance();
            wprodutos.MdiParent = this;
            wprodutos.WindowState = FormWindowState.Normal;
            wprodutos.Show();
        }
    }
}
