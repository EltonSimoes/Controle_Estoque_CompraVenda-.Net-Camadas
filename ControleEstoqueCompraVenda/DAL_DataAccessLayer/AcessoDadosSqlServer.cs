using DAL_DataAccessLayer.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_DataAccessLayer
{
    public class AcessoDadosSqlServer
    {
        //Parâmetros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //Criar Conexão
        private SqlConnection criarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        public void limparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void adicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistência de Dados - Inserir - Alterar - Excluir
        public object executarManipulacao(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            //Executar comando.
            return persistenciaConexao(commandType, nomeStoreProcedureOuTextoSql).ExecuteScalar();

        }

        //Consultar registros
        public DataTable execuarConsulta(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(persistenciaConexao(commandType, nomeStoreProcedureOuTextoSql));
                //Preencher DataTable com dados e adaptador
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private SqlCommand persistenciaConexao(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            try
            {
                //Criar a conexão.
                SqlConnection sqlConnection = criarConexao();
                //Abrir conexão.
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Processar comando.
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoreProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                //Adicionar os parâmentros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlCommand;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
