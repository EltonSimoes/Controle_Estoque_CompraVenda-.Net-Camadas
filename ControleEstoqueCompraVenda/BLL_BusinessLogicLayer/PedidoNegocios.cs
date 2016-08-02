using DAL_DataAccessLayer;
using DTO_DataTransferObject;
using System;
using System.Data;

namespace BLL_BusinessLogicLayer
{
    public class PedidoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        //Inserir
        public string iserir(Pedido pedido)
        {
            try
            {
                acessoDados.limparParametros();
                acessoDados.adicionarParametros("@IDOperacao", pedido.Operacao.IDOperacao);
                acessoDados.adicionarParametros("@IDSituacao", pedido.Situacao.IDSituacao);
                acessoDados.adicionarParametros("@IDPessoaEmitente", pedido.Emitente.IDPessoa);
                acessoDados.adicionarParametros("@IDPessoaDestinatario", pedido.Destinatario.IDPessoa);
                string idPedido = acessoDados.executarManipulacao(CommandType.StoredProcedure, "uspPedidoInserir").ToString();
                return idPedido;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //Consultar
        public PedidoColetion consultarPorData(DateTime dataInicil, DateTime DataFinal)
        {
            try
            {
                PedidoColetion pedidoColetion = new PedidoColetion();
                acessoDados.limparParametros();
                acessoDados.adicionarParametros("@DataInicial", dataInicil);
                acessoDados.adicionarParametros("@DataFinal", DataFinal);
                DataTable dataTable = acessoDados.execuarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarPorData");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Pedido pedido = new Pedido();
                    pedido.IDPedido = Convert.ToInt32(dataRow["IDPedido"]);
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);
                    pedido.Operacao = new Operacao();
                    pedido.Operacao.IDOperacao = Convert.ToInt32(dataRow["IDOperacao"]);
                    pedido.Operacao.Descricao = Convert.ToString(dataRow["DescOperacao"]);
                    pedido.Situacao = new Situacao();
                    pedido.Situacao.IDSituacao = Convert.ToInt32(dataRow["IDSituacao"]);
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["DescSituacao"]);
                    pedido.Emitente = new Pessoa();
                    pedido.Emitente.IDPessoa = Convert.ToInt32(dataRow["IDPessoaEmitente"]);
                    pedido.Emitente.Nome = Convert.ToString(dataRow["NomeEmitente"]);
                    pedido.Destinatario = new Pessoa();
                    pedido.Destinatario.IDPessoa = Convert.ToInt32(dataRow["IDPessoaDestinatario"]);
                    pedido.Destinatario.Nome = Convert.ToString(dataRow["NomeDestinatario"]);   
                    pedidoColetion.Add(pedido);
                }
                return pedidoColetion;
            }
            catch (Exception exception)
            {
                
                throw new Exception("Erro ao consultar Pedido por data! Detalhe: " + exception.Message);
            }
        }
    }
}
