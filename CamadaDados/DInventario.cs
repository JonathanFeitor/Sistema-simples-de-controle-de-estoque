using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace CamadaDados
{
    public class DInventario
    {
        private int _numInventario;
        private string _tipoEquipamento;
        private string _modeloEquipamento;
        private string _numSerial;
        private string _statusEquipamento;
        private DateTime _dataEquipamento;
        private string _idFuncionario;
        private string _descricao;
        private string _ipEquipamento;
        private string _localizacao;
        private string _buscarInventario;
        
        public int NumInventario { get => _numInventario; set => _numInventario = value; }

        public string TipoEquipamento { get => _tipoEquipamento; set => _tipoEquipamento = value; }

        public string ModeloEquipamento { get => _modeloEquipamento; set => _modeloEquipamento = value; }

        public string NumSerial { get => _numSerial; set => _numSerial = value; }

        public string StatusEquipamento { get => _statusEquipamento; set => _statusEquipamento = value; }

        public DateTime DataEquipamento { get => _dataEquipamento; set => _dataEquipamento = value; }

        public string IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }

        public string Descricao { get => _descricao; set => _descricao = value; }

        public string BuscarInventario { get => _buscarInventario; set => _buscarInventario = value; }

        public string IpEquipamento { get => _ipEquipamento; set => _ipEquipamento = value; }

        public string Localizacao { get => _localizacao; set => _localizacao = value; }

        //Construtor Vazio
        public DInventario()
        {

        }

        //Construtor com Parâmentros
        public DInventario(int numInventario, string tipoEquipamento, string modeloEquipamento, string numSerial, string statusEquipamento,
            DateTime dataEquipamento, string idFuncionario, string descricao, string buscarInventario, string ip_equipamento, string localizacao)
        {
            this.NumInventario = numInventario;
            this.TipoEquipamento = tipoEquipamento;
            this.ModeloEquipamento = modeloEquipamento;
            this.NumSerial = numSerial;
            this.StatusEquipamento = statusEquipamento;
            this.DataEquipamento = dataEquipamento;
            this.IdFuncionario = idFuncionario;
            this.Descricao = descricao;
            this.IpEquipamento = ip_equipamento;
            this.Localizacao = localizacao;
            this.BuscarInventario = buscarInventario;
        }

        //Método Inserir
        public string Insert(DInventario Inventario)
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
                SqlCmd.CommandText = "sp_InserirInventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumIventario = new SqlParameter();
                ParNumIventario.ParameterName = "@numero_inventario";
                ParNumIventario.SqlDbType = SqlDbType.Int;
                ParNumIventario.Value = Inventario.NumInventario;
                SqlCmd.Parameters.Add(ParNumIventario);

                SqlParameter ParTipoEquipamento = new SqlParameter();
                ParTipoEquipamento.ParameterName = "@tipo_equipamento";
                ParTipoEquipamento.SqlDbType = SqlDbType.VarChar;
                ParTipoEquipamento.Size = 50;
                ParTipoEquipamento.Value = Inventario.TipoEquipamento;
                SqlCmd.Parameters.Add(ParTipoEquipamento);

                SqlParameter ParModeloEquipamento = new SqlParameter();
                ParModeloEquipamento.ParameterName = "@modelo";
                ParModeloEquipamento.SqlDbType = SqlDbType.VarChar;
                ParModeloEquipamento.Size = 50;
                ParModeloEquipamento.Value = Inventario.ModeloEquipamento;
                SqlCmd.Parameters.Add(ParModeloEquipamento);

                SqlParameter ParNumSerial = new SqlParameter();
                ParNumSerial.ParameterName = "@numero_serial";
                ParNumSerial.SqlDbType = SqlDbType.VarChar;
                ParNumSerial.Size = 50;
                ParNumSerial.Value = Inventario.NumSerial;
                SqlCmd.Parameters.Add(ParNumSerial);

                SqlParameter ParStatusEquipamento = new SqlParameter();
                ParStatusEquipamento.ParameterName = "@status";
                ParStatusEquipamento.SqlDbType = SqlDbType.VarChar;
                ParStatusEquipamento.Size = 3;
                ParStatusEquipamento.Value = Inventario.StatusEquipamento;
                SqlCmd.Parameters.Add(ParStatusEquipamento);

                SqlParameter ParDataEquipamento = new SqlParameter();
                ParDataEquipamento.ParameterName = "@data";
                ParDataEquipamento.SqlDbType = SqlDbType.DateTime;
                ParDataEquipamento.Value = Inventario.DataEquipamento;
                SqlCmd.Parameters.Add(ParDataEquipamento);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Inventario.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParIpEquipamento = new SqlParameter();
                ParIpEquipamento.ParameterName = "@ip_equipamento";
                ParIpEquipamento.SqlDbType = SqlDbType.VarChar;
                ParIpEquipamento.Size = 15;
                ParIpEquipamento.Value = Inventario.IpEquipamento;
                SqlCmd.Parameters.Add(ParIpEquipamento);

                SqlParameter ParLocalizacaoEquipamento = new SqlParameter();
                ParLocalizacaoEquipamento.ParameterName = "@localizacao";
                ParLocalizacaoEquipamento.SqlDbType = SqlDbType.VarChar;
                ParLocalizacaoEquipamento.Size = 50;
                ParLocalizacaoEquipamento.Value = Inventario.Localizacao;
                SqlCmd.Parameters.Add(ParLocalizacaoEquipamento);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 250;
                ParDescricao.Value = Inventario.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

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
        public DataTable MostrarInventario()
        {
            DataTable DtResult = new DataTable("Inventario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Código
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_MostrarInventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResult);

            }
            catch (Exception ex)
            {
                DtResult = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            
            return DtResult;
        }

        // Método Buscar Tipo
        public DataTable BuscarTipoInventario(DInventario Inventario)
        {
            DataTable DtResult = new DataTable("Inventario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_ProcurarInventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscarEquipamento = new SqlParameter();
                ParBuscarEquipamento.ParameterName = "@tipo_equipamento";
                ParBuscarEquipamento.SqlDbType = SqlDbType.VarChar;
                ParBuscarEquipamento.Size = 50;
                ParBuscarEquipamento.Value = Inventario.BuscarInventario;
                SqlCmd.Parameters.Add(ParBuscarEquipamento);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResult);

            }
            catch (Exception ex)
            {
                DtResult = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResult;
        }

        //Método Editar
        public string Editar(DInventario Inventario)
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
                SqlCmd.CommandText = "sp_EditarInventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumeroInventario = new SqlParameter();
                ParNumeroInventario.ParameterName = "@numero_inventario";
                ParNumeroInventario.SqlDbType = SqlDbType.Int;
                ParNumeroInventario.Value = Inventario.NumInventario;
                SqlCmd.Parameters.Add(ParNumeroInventario);

                SqlParameter ParTipoEquipamento = new SqlParameter();
                ParTipoEquipamento.ParameterName = "@tipo_equipamento";
                ParTipoEquipamento.SqlDbType = SqlDbType.VarChar;
                ParTipoEquipamento.Size = 50;
                ParTipoEquipamento.Value = Inventario.TipoEquipamento;
                SqlCmd.Parameters.Add(ParTipoEquipamento);

                SqlParameter ParModeloEquipamento = new SqlParameter();
                ParModeloEquipamento.ParameterName = "@modelo";
                ParModeloEquipamento.SqlDbType = SqlDbType.VarChar;
                ParModeloEquipamento.Size = 50;
                ParModeloEquipamento.Value = Inventario.ModeloEquipamento;
                SqlCmd.Parameters.Add(ParModeloEquipamento);

                SqlParameter ParNumSerial = new SqlParameter();
                ParNumSerial.ParameterName = "@numero_serial";
                ParNumSerial.SqlDbType = SqlDbType.VarChar;
                ParNumSerial.Size = 50;
                ParNumSerial.Value = Inventario.NumSerial;
                SqlCmd.Parameters.Add(ParNumSerial);

                SqlParameter ParStatusEquipamento = new SqlParameter();
                ParStatusEquipamento.ParameterName = "@status";
                ParStatusEquipamento.SqlDbType = SqlDbType.VarChar;
                ParStatusEquipamento.Value = 3;
                ParStatusEquipamento.Value = Inventario.StatusEquipamento;
                SqlCmd.Parameters.Add(ParStatusEquipamento);

                SqlParameter ParDataEquipamento = new SqlParameter();
                ParDataEquipamento.ParameterName = "@data";
                ParDataEquipamento.SqlDbType = SqlDbType.DateTime;
                ParDataEquipamento.Value = Inventario.DataEquipamento;
                SqlCmd.Parameters.Add(ParDataEquipamento);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@id_funcionario";
                ParIdFuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdFuncionario.Size = 10;
                ParIdFuncionario.Value = Inventario.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParIpEquipamento = new SqlParameter();
                ParIpEquipamento.ParameterName = "@ip_equipamento";
                ParIpEquipamento.SqlDbType = SqlDbType.VarChar;
                ParIpEquipamento.Size = 15;
                ParIpEquipamento.Value = Inventario.IpEquipamento;
                SqlCmd.Parameters.Add(ParIpEquipamento);

                SqlParameter ParLocalizacaoEquipamento = new SqlParameter();
                ParLocalizacaoEquipamento.ParameterName = "@localizacao";
                ParLocalizacaoEquipamento.SqlDbType = SqlDbType.VarChar;
                ParLocalizacaoEquipamento.Size = 50;
                ParLocalizacaoEquipamento.Value = Inventario.Localizacao;
                SqlCmd.Parameters.Add(ParLocalizacaoEquipamento);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 250;
                ParDescricao.Value = Inventario.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

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
        public string ExcluirInventario(DInventario Inventario)
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
                SqlCmd.CommandText = "sp_DeletarInventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumInventario = new SqlParameter();
                ParNumInventario.ParameterName = "@numero_inventario";
                ParNumInventario.SqlDbType = SqlDbType.Int;
                ParNumInventario.Value = Inventario.NumInventario;
                SqlCmd.Parameters.Add(ParNumInventario);

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
