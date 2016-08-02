using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DataAccessLayer;
using DTO_DataTransferObject;
using System.Data;

namespace BLL_BusinessLogicLayer
{
    public class PedidoItemNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public string inserir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDados.limparParametros();
                acessoDados.adicionarParametros("@IDPedido", pedidoItem.Pedido.IDPedido);
                acessoDados.adicionarParametros("@IDProduto", pedidoItem.Produto.IDProduto);
                acessoDados.adicionarParametros("@Quantidade", pedidoItem.Quantidade);
                acessoDados.adicionarParametros("@ValorUnitario", pedidoItem.ValorUnitario);
                acessoDados.adicionarParametros("@PercentualDesconto", pedidoItem.ValorDesconto);
                acessoDados.adicionarParametros("@ValorDesconto", pedidoItem.ValorDesconto);
                acessoDados.adicionarParametros("@ValorTotal", pedidoItem.ValorTotal);
                string idProduto = acessoDados.execuarConsulta(CommandType.StoredProcedure, "uspPedidoItemInserir").ToString();
                return idProduto;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public PedidoItemColetion consultar(int idPedido)
        {
            try
            {
                PedidoItemColetion pedidoItemColetion = new PedidoItemColetion();
                acessoDados.limparParametros();
                acessoDados.adicionarParametros("@IDPedido", idPedido);
                DataTable dataTable = acessoDados.execuarConsulta(CommandType.StoredProcedure, "uspPedidoItemConsultar");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PedidoItem pedidoItem = new PedidoItem();
                    pedidoItem.Pedido = new Pedido();
                    pedidoItem.Pedido.IDPedido = Convert.ToInt32(dataRow["IDPedido"]);
                    pedidoItem.Produto = new Produto();
                    pedidoItem.Produto.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
                    pedidoItem.Produto.Descricao = Convert.ToString(dataRow["DescProduto"]);
                    pedidoItem.Quantidade = Convert.ToInt32(dataRow["Quantidade"]);
                    pedidoItem.ValorUnitario = Convert.ToDecimal(dataRow["ValorUnitario"]);
                    pedidoItem.PercentualDesconto = Convert.ToDecimal(dataRow["PercentualDesconto"]);
                    pedidoItem.ValorDesconto = Convert.ToDecimal(dataRow["ValorDesconto"]);
                    pedidoItem.ValorTotal = Convert.ToDecimal(dataRow["ValorTotal"]);
                    pedidoItemColetion.Add(pedidoItem);
                }
                return pedidoItemColetion;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar item do pedido! Detalhes: " + ex.Message);
            }
        }
    }
}
