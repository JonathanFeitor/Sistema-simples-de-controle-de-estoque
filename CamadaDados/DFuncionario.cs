using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFuncionario
    {
        private string _id_funcionario;
        private string _nome;
        private string _cargo;
        private string _telefone;
        private string _senha;
        private string _buscarFuncionario;
        
        public string Id_funcionario { get => _id_funcionario; set => _id_funcionario = value; }

        public string Nome { get => _nome; set => _nome = value; }

        public string Cargo { get => _cargo; set => _cargo = value; }

        public string Telefone { get => _telefone; set => _telefone = value; }

        public string Senha { get => _senha; set => _senha = value; }

        public string BuscarFuncionario { get => _buscarFuncionario; set => _buscarFuncionario = value; }

        //Construtor Vazio
        public DFuncionario()
        {

        }

        //Construtor com Parâmentros
        public DFuncionario(string id_funcionario, string nome, string cargo, string telefone, string senha)
        {
            this.Id_funcionario = id_funcionario;
            this.Nome = nome;
            this.Cargo = cargo;
            this.Telefone = telefone;
            this.Senha = senha;
        }

        //Método Inserir
        public string Insert(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //código
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_InserirFuncionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Funcionario.Id_funcionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParNomeFuncionario = new SqlParameter();
                ParNomeFuncionario.ParameterName = "@nome";
                ParNomeFuncionario.SqlDbType = SqlDbType.VarChar;
                ParNomeFuncionario.Size = 50;
                ParNomeFuncionario.Value = Funcionario.Nome;
                SqlCmd.Parameters.Add(ParNomeFuncionario);

                SqlParameter ParCargoFuncionario = new SqlParameter();
                ParCargoFuncionario.ParameterName = "@cargo";
                ParCargoFuncionario.SqlDbType = SqlDbType.VarChar;
                ParCargoFuncionario.Size = 50;
                ParCargoFuncionario.Value = Funcionario.Cargo;
                SqlCmd.Parameters.Add(ParCargoFuncionario);

                SqlParameter ParTelFuncionario = new SqlParameter();
                ParTelFuncionario.ParameterName = "@telefone";
                ParTelFuncionario.SqlDbType = SqlDbType.VarChar;
                ParTelFuncionario.Size = 11;
                ParTelFuncionario.Value = Funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelFuncionario);

                SqlParameter ParSenhaFuncionario = new SqlParameter();
                ParSenhaFuncionario.ParameterName = "@senha";
                ParSenhaFuncionario.SqlDbType = SqlDbType.VarChar;
                ParSenhaFuncionario.Size = 100;
                ParSenhaFuncionario.Value = Funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenhaFuncionario);

                //Executando o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi inserido!";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        // Método Mostrar
        public DataTable MostrarFuncionario()
        {
            DataTable DtResult = new DataTable("Funcionario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Código
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_MostrarFuncionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResult);

            }
            catch (Exception ex)
            {
                DtResult = null;
            }
            return DtResult;
        }

        // Método Buscar Tipo
        public DataTable BuscarTipoFuncionario(DFuncionario Funcionario)
        {
            DataTable DtResult = new DataTable("Funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_ProcurarFuncionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscarFuncionario = new SqlParameter();
                ParBuscarFuncionario.ParameterName = "@id_funcionario";
                ParBuscarFuncionario.SqlDbType = SqlDbType.VarChar;
                ParBuscarFuncionario.Size = 10;
                ParBuscarFuncionario.Value = Funcionario.BuscarFuncionario;
                SqlCmd.Parameters.Add(ParBuscarFuncionario);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResult);

            }
            catch (Exception ex)
            {
                DtResult = null;
            }
            return DtResult;
        }

        //Método Editar
        public string Editar(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Código
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_EditarFuncionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Funcionario.Id_funcionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParNomeFuncionario = new SqlParameter();
                ParNomeFuncionario.ParameterName = "@nome";
                ParNomeFuncionario.SqlDbType = SqlDbType.VarChar;
                ParNomeFuncionario.Size = 50;
                ParNomeFuncionario.Value = Funcionario.Nome;
                SqlCmd.Parameters.Add(ParNomeFuncionario);

                SqlParameter ParCargoFuncionario = new SqlParameter();
                ParCargoFuncionario.ParameterName = "@cargo";
                ParCargoFuncionario.SqlDbType = SqlDbType.VarChar;
                ParCargoFuncionario.Size = 50;
                ParCargoFuncionario.Value = Funcionario.Cargo;
                SqlCmd.Parameters.Add(ParCargoFuncionario);

                SqlParameter ParTelFuncionario = new SqlParameter();
                ParTelFuncionario.ParameterName = "@telefone";
                ParTelFuncionario.SqlDbType = SqlDbType.VarChar;
                ParTelFuncionario.Size = 11;
                ParTelFuncionario.Value = Funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelFuncionario);

                SqlParameter ParSenhaFuncionario = new SqlParameter();
                ParSenhaFuncionario.ParameterName = "@senha";
                ParSenhaFuncionario.SqlDbType = SqlDbType.VarChar;
                ParSenhaFuncionario.Size = 100;
                ParSenhaFuncionario.Value = Funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenhaFuncionario);

                //Executando o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi realizada!";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Método Excluir
        public string ExcluirFuncionario(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //código
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_DeletarFuncionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Funcionario.Id_funcionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                //Executando o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi realizada!";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
    }
}
