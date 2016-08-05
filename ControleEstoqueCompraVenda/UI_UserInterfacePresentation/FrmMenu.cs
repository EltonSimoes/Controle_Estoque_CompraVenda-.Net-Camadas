using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_UserInterfacePresentation
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void menuPedido_Click(object sender, EventArgs e)
        {
            FrmPedidoVendaCadastrar frmPedidoVenda = new FrmPedidoVendaCadastrar();
            frmPedidoVenda.MdiParent = this;
            frmPedidoVenda.Show();
        }
    }
}
