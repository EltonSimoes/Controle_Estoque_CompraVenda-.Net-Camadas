using DAL_DataAccessLayer;
using DTO_DataTransferObject;
using System;
using System.Data;

namespace BLL_BusinessLogicLayer
{
    public class FilialNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public FilialColetion consultarPorCodigo(int idPessoaFilal)
        {
            acessoDados.limparParametros();
            acessoDados.adicionarParametros("@IDPessoaFilal", idPessoaFilal);
            DataTable dataTable = acessoDados.execuarConsulta(CommandType.StoredProcedure, "uspFilialConsultarPorCodigo");
            return carrgarTable(dataTable);
        }

        public FilialColetion consultarPorNome(string nome)
        {
            acessoDados.limparParametros();
            acessoDados.adicionarParametros("@Nome", nome);
            DataTable dataTable = acessoDados.execuarConsulta(CommandType.StoredProcedure, "uspFilialConsultarPorNome");
            return carrgarTable(dataTable);
        }

        private FilialColetion carrgarTable(DataTable dataTable)
        {
            FilialColetion filialColetion = new FilialColetion();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Filial filial = new Filial();
                filial.Pessoa = new Pessoa();
                filial.Pessoa.IDPessoa = Convert.ToInt32(dataRow["IDPessoaFilial"]);
                filial.Pessoa.Nome = Convert.ToString(dataRow["Nome"]);
                filial.Pessoa.CpfCnpj = Convert.ToString(dataRow["CpfCnpj"]);

                filial.Pessoa.PessoaTipo = new PessoaTipo();
                filial.Pessoa.PessoaTipo.IDPessoaTipo = Convert.ToInt32(dataRow["IDPessoaFilial"]);
                filial.Pessoa.PessoaTipo.Descricao = Convert.ToString(dataRow["DescricaoTipo"]);
                filialColetion.Add(filial);
            }
            return filialColetion;
        }
    }
}
