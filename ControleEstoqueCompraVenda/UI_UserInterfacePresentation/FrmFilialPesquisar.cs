using BLL_BusinessLogicLayer;
using DTO_DataTransferObject;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI_UserInterfacePresentation
{
    public partial class FrmFilialPesquisar : Form
    {
        public FrmFilialPesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FilialNegocios filialNegocios = new FilialNegocios();
            dgwPrincipal.DataSource = null;
            //Compare número ou texto...dgwPrincipal = filialColecao
            int codigoDigitado;
            FilialColetion filialColecao = new FilialColetion();
            if (int.TryParse(txtPesquisar.Text, out codigoDigitado))
            {
                filialColecao = filialNegocios.consultarPorCodigo(codigoDigitado);
            }
            else
            {
                filialColecao = filialNegocios.consultarPorNome(txtPesquisar.Text);
            }
            var novaListFilial = filialColecao.Select(Filial => new
            {
                IDPessoaFilial = Filial.Pessoa.IDPessoa,
                Nome = Filial.Pessoa.Nome,
                CpfCnpj = Filial.Pessoa.CpfCnpj,
                DescricaoTipo = Filial.Pessoa.PessoaTipo.Descricao
            }).ToList();
            dgwPrincipal.DataSource = novaListFilial;
            dgwPrincipal.AutoResizeColumns();
            //foreach (DataGridViewColumn column in dgwPrincipal.Columns)
              //  column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgwPrincipal.Columns[1].Width = 252;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
    }
}
