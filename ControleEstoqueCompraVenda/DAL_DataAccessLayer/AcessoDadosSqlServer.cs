﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_DataAccessLayer.Properties;

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
            return persistenciaConexaoBanco(commandType, nomeStoreProcedureOuTextoSql, true).ExecuteScalar();

        }

        //Consultar registros
        public DataTable execuarConsulta(CommandType commandType, string nomeStoreProcedureOuTextoSql)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(persistenciaConexaoBanco(commandType, nomeStoreProcedureOuTextoSql, false));
            //Preencher DataTable com dados e adaptador
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        private SqlCommand persistenciaConexaoBanco(CommandType commandType, string nomeStoreProcedureOuTextoSql, bool tipoManipulacao)
        {
            try
            {
                //Criar a conexão.
                SqlConnection sqlConnection = criarConexao();
                //Abrir conexão.
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco.
                SqlCommand sqlCommand = new SqlCommand();
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
