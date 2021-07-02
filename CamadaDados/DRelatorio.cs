using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace CamadaDados
{
    public class DRelatorio
    {
        private string _tipo_equipamento;
        private string _data1;
        private string _data2;
        private string _checkMovimentacao;
        
        private string _statusEquipamento;
    
        public string  Tipo_Equipamento{ get => _tipo_equipamento; set => _tipo_equipamento = value; }

        public string Data1 { get => _data1; set => _data1 = value; }

        public string Data2 { get => _data2; set => _data2 = value; }

        public string CheckMovimentacao { get => _checkMovimentacao; set => _checkMovimentacao = value; }

        public string StatusEquipamento { get => _statusEquipamento; set => _statusEquipamento = value; }
        
        public void ConverterData(DateTime data1, DateTime data2)
        {
            this.Data1 = data1.ToString("yyyy-MM-dd");
            this.Data2 = data2.ToString("yyyy-MM-dd");
        }

        /// Método Buscar Nome Material
        /// 
        public DataTable RelatorioMateriais(DRelatorio Relatorio)
        {
            DataTable DtResult = new DataTable("Materiais");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_RelatorioMateriais";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTipoEquipamento = new SqlParameter();
                ParTipoEquipamento.ParameterName = "@valor";
                ParTipoEquipamento.SqlDbType = SqlDbType.VarChar;
                ParTipoEquipamento.Size = 50;
                ParTipoEquipamento.Value = Relatorio.Tipo_Equipamento;
                SqlCmd.Parameters.Add(ParTipoEquipamento);

                SqlParameter ParCheckTipoMovimentacao = new SqlParameter();
                ParCheckTipoMovimentacao.ParameterName = "@formula";
                ParCheckTipoMovimentacao.SqlDbType = SqlDbType.VarChar;
                ParCheckTipoMovimentacao.Size = 10;
                ParCheckTipoMovimentacao.Value = Relatorio.CheckMovimentacao;
                SqlCmd.Parameters.Add(ParCheckTipoMovimentacao);

                SqlParameter ParData1 = new SqlParameter();
                ParData1.ParameterName = "@data1";
                ParData1.SqlDbType = SqlDbType.Date;
                ParData1.Value = Convert.ToDateTime(Relatorio.Data1);
                SqlCmd.Parameters.Add(ParData1);

                SqlParameter ParData2 = new SqlParameter();
                ParData2.ParameterName = "@data2";
                ParData2.SqlDbType = SqlDbType.Date;
                ParData2.Value = Convert.ToDateTime(Relatorio.Data2);
                SqlCmd.Parameters.Add(ParData2);

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

        //// Método Buscar Tipo Equipamento
        ///
        public DataTable RelatorioEquipamento(DRelatorio Relatorio)
        {
            DataTable DtResult = new DataTable("Inventario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_RelatorioInventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTipoEquipamento = new SqlParameter();
                ParTipoEquipamento.ParameterName = "@tipo_equipamento";
                ParTipoEquipamento.SqlDbType = SqlDbType.VarChar;
                ParTipoEquipamento.Size = 50;
                ParTipoEquipamento.Value = Relatorio.Tipo_Equipamento;
                SqlCmd.Parameters.Add(ParTipoEquipamento);

                SqlParameter ParStatusEquipamento = new SqlParameter();
                ParStatusEquipamento.ParameterName = "@status_Equipamento";
                ParStatusEquipamento.SqlDbType = SqlDbType.VarChar;
                ParStatusEquipamento.Size = 5;
                ParStatusEquipamento.Value = Relatorio.StatusEquipamento;
                SqlCmd.Parameters.Add(ParStatusEquipamento);

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

    }
}
