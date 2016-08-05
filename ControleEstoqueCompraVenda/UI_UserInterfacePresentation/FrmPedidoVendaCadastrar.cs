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
    public partial class FrmPedidoVendaCadastrar : Form
    {
        public FrmPedidoVendaCadastrar()
        {
            InitializeComponent();
        }

        private void btnPesquisarEmitente_Click(object sender, EventArgs e)
        {
            FrmFilialPesquisar frmFilialPesquisar = new FrmFilialPesquisar();
            frmFilialPesquisar.ShowDialog();
        }
    }
}
