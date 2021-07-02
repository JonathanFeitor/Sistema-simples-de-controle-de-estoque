using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DMateriais

    {
        private int _idMateriais;
        private string _tipoMateriais;
        private string _modelo;
        private int _quantidade;
        private DateTime _data;
        private string _idFuncionario;
        private string _descricao;
        private string _BuscarMaterial;
        private int _movimentacao;

        public int IdMaterial { get => _idMateriais; set => _idMateriais = value; }

        public string TipoMateriais { get => _tipoMateriais; set => _tipoMateriais = value; }
        
        public string Modelo { get => _modelo; set => _modelo = value; }
        
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        
        public DateTime Data { get => _data; set => _data = value; }
        
        public string IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }
        
        public string BuscarMaterial { get => _BuscarMaterial; set => _BuscarMaterial = value; }

        public int Movimentacao { get => _movimentacao; set => _movimentacao = value; }

        public string Descricao { get => _descricao; set => _descricao = value; }

        //Construtor Vazio
        public DMateriais()
        {

        }

        //Construtores com Parâmetros
        public DMateriais(int idMaterial, string tipoMateriais, string modelo, int quantidade, DateTime data, string idFuncionario, string buscarMateriais, string descricao)
        {
            this.IdMaterial = idMaterial;
            this.TipoMateriais = tipoMateriais;
            this.Modelo = modelo;
            this.Quantidade = quantidade;
            this.Data = data;
            this.IdFuncionario = idFuncionario;
            this.BuscarMaterial = buscarMateriais;
            this.Descricao = descricao;

        }

        // Método Inserir
        public string Insert(DMateriais Materiais)
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
                SqlCmd.CommandText = "sp_InserirMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMaterial = new SqlParameter();
                ParIdMaterial.ParameterName = "@id_materiais";
                ParIdMaterial.SqlDbType = SqlDbType.Int;
                ParIdMaterial.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdMaterial);

                SqlParameter ParTipoMaterial = new SqlParameter();
                ParTipoMaterial.ParameterName = "@tipo";
                ParTipoMaterial.SqlDbType = SqlDbType.VarChar;
                ParTipoMaterial.Size = 50;
                ParTipoMaterial.Value = Materiais.TipoMateriais;
                SqlCmd.Parameters.Add(ParTipoMaterial);

                SqlParameter ParModeloMaterial = new SqlParameter();
                ParModeloMaterial.ParameterName = "@modelo";
                ParModeloMaterial.SqlDbType = SqlDbType.VarChar;
                ParModeloMaterial.Size = 50;
                ParModeloMaterial.Value = Materiais.Modelo;
                SqlCmd.Parameters.Add(ParModeloMaterial);

                SqlParameter ParQuantidadeMaterial = new SqlParameter();
                ParQuantidadeMaterial.ParameterName = "@quantidade";
                ParQuantidadeMaterial.SqlDbType = SqlDbType.Int;
                ParQuantidadeMaterial.Value = Materiais.Quantidade;
                SqlCmd.Parameters.Add(ParQuantidadeMaterial);

                SqlParameter ParDataMateriais = new SqlParameter();
                ParDataMateriais.ParameterName = "@data";
                ParDataMateriais.SqlDbType = SqlDbType.DateTime;
                ParDataMateriais.Value = Materiais.Data;
                SqlCmd.Parameters.Add(ParDataMateriais);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Materiais.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParDescricaoMateriais = new SqlParameter();
                ParDescricaoMateriais.ParameterName = "@descricao";
                ParDescricaoMateriais.SqlDbType = SqlDbType.VarChar;
                ParDescricaoMateriais.Size = 250;
                ParDescricaoMateriais.Value = Materiais.Descricao;
                SqlCmd.Parameters.Add(ParDescricaoMateriais);

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
        public DataTable MostrarMateriais()
        {
            DataTable DtResult = new DataTable("Materiais");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_MostrarMateriais";
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

        // Método Buscar Nome
        public DataTable BuscarTipoMateriais(DMateriais Materiais)
        {
            DataTable DtResult = new DataTable("Materiais");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_ProcurarMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParBuscarMaterial = new SqlParameter();
                ParBuscarMaterial.ParameterName = "@tipo";
                ParBuscarMaterial.SqlDbType = SqlDbType.VarChar;
                ParBuscarMaterial.Size = 50;
                ParBuscarMaterial.Value = Materiais.BuscarMaterial;
                SqlCmd.Parameters.Add(ParBuscarMaterial);

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
        public string Editar(DMateriais Materiais)
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
                SqlCmd.CommandText = "sp_EditarMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMateriais = new SqlParameter();
                ParIdMateriais.ParameterName = "@id_material";
                ParIdMateriais.SqlDbType = SqlDbType.Int;
                ParIdMateriais.Value = Materiais.IdMaterial;
                SqlCmd.Parameters.Add(ParIdMateriais);

                SqlParameter ParTipoMateriais = new SqlParameter();
                ParTipoMateriais.ParameterName = "@tipo";
                ParTipoMateriais.SqlDbType = SqlDbType.VarChar;
                ParTipoMateriais.Size = 50;
                ParTipoMateriais.Value = Materiais.TipoMateriais;
                SqlCmd.Parameters.Add(ParTipoMateriais);

                SqlParameter ParModelMateriais = new SqlParameter();
                ParModelMateriais.ParameterName = "@modelo";
                ParModelMateriais.SqlDbType = SqlDbType.VarChar;
                ParModelMateriais.Size = 50;
                ParModelMateriais.Value = Materiais.Modelo;
                SqlCmd.Parameters.Add(ParModelMateriais);

                SqlParameter ParDataMateriais = new SqlParameter();
                ParDataMateriais.ParameterName = "@data";
                ParDataMateriais.SqlDbType = SqlDbType.DateTime;
                ParDataMateriais.Value = Materiais.Data;
                SqlCmd.Parameters.Add(ParDataMateriais);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Materiais.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParDescricaoMateriais = new SqlParameter();
                ParDescricaoMateriais.ParameterName = "@descricao";
                ParDescricaoMateriais.SqlDbType = SqlDbType.VarChar;
                ParDescricaoMateriais.Size = 250;
                ParDescricaoMateriais.Value = Materiais.Descricao;
                SqlCmd.Parameters.Add(ParDescricaoMateriais);

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
        public string ExcluirMaterial(DMateriais Materiais)
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
                SqlCmd.CommandText = "sp_DeletarMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMateriais = new SqlParameter();
                ParIdMateriais.ParameterName = "@id_materiais";
                ParIdMateriais.SqlDbType = SqlDbType.Int;
                ParIdMateriais.Value = Materiais.IdMaterial;
                SqlCmd.Parameters.Add(ParIdMateriais);

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

        //Método Somar Valor Materiais
        public string SomaValorMateriais(DMateriais Materiais)
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
                SqlCmd.CommandText = "sp_SomaQuantidadeMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMateriais = new SqlParameter();
                ParIdMateriais.ParameterName = "@id_material";
                ParIdMateriais.SqlDbType = SqlDbType.Int;
                ParIdMateriais.Value = Materiais.IdMaterial;
                SqlCmd.Parameters.Add(ParIdMateriais);

                SqlParameter ParTipoMateriais = new SqlParameter();
                ParTipoMateriais.ParameterName = "@tipo";
                ParTipoMateriais.SqlDbType = SqlDbType.VarChar;
                ParTipoMateriais.Size = 50;
                ParTipoMateriais.Value = Materiais.TipoMateriais;
                SqlCmd.Parameters.Add(ParTipoMateriais);

                SqlParameter ParModeloMateriais = new SqlParameter();
                ParModeloMateriais.ParameterName = "modelo";
                ParModeloMateriais.SqlDbType = SqlDbType.VarChar;
                ParModeloMateriais.Size = 50;
                ParModeloMateriais.Value = Materiais.Modelo;
                SqlCmd.Parameters.Add(ParModeloMateriais);

                SqlParameter ParValorMateriais = new SqlParameter();
                ParValorMateriais.ParameterName = "valor";
                ParValorMateriais.SqlDbType = SqlDbType.Int;
                ParValorMateriais.Value = Materiais.Movimentacao;
                SqlCmd.Parameters.Add(ParValorMateriais);

                SqlParameter ParDataMateriais = new SqlParameter();
                ParDataMateriais.ParameterName = "@data_atual";
                ParDataMateriais.SqlDbType = SqlDbType.DateTime;
                ParDataMateriais.Value = Materiais.Data;
                SqlCmd.Parameters.Add(ParDataMateriais);

                resp = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "Valor não pode ser inserido!";
               
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

        //Método Subtrair Valor Materiais
        public string SubValorMateriais(DMateriais Materiais)
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
                SqlCmd.CommandText = "sp_SubtrairQuantidadeMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMateriais = new SqlParameter();
                ParIdMateriais.ParameterName = "@id_material";
                ParIdMateriais.SqlDbType = SqlDbType.Int;
                ParIdMateriais.Value = Materiais.IdMaterial;
                SqlCmd.Parameters.Add(ParIdMateriais);

                SqlParameter ParTipoMateriais = new SqlParameter();
                ParTipoMateriais.ParameterName = "@tipo";
                ParTipoMateriais.SqlDbType = SqlDbType.VarChar;
                ParTipoMateriais.Size = 50;
                ParTipoMateriais.Value = Materiais.TipoMateriais;
                SqlCmd.Parameters.Add(ParTipoMateriais);

                SqlParameter ParModeloMateriais = new SqlParameter();
                ParModeloMateriais.ParameterName = "modelo";
                ParModeloMateriais.SqlDbType = SqlDbType.VarChar;
                ParModeloMateriais.Size = 50;
                ParModeloMateriais.Value = Materiais.Modelo;
                SqlCmd.Parameters.Add(ParModeloMateriais);

                SqlParameter ParValorMateriais = new SqlParameter();
                ParValorMateriais.ParameterName = "valor";
                ParValorMateriais.SqlDbType = SqlDbType.Int;
                ParValorMateriais.Value = Materiais.Movimentacao;
                SqlCmd.Parameters.Add(ParValorMateriais);

                SqlParameter ParDataMateriais = new SqlParameter();
                ParDataMateriais.ParameterName = "@data_atual";
                ParDataMateriais.SqlDbType = SqlDbType.DateTime;
                ParDataMateriais.Value = Materiais.Data;
                SqlCmd.Parameters.Add(ParDataMateriais);

                //Executando o comando

                resp = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "Valor não pode ser inserido!";

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
