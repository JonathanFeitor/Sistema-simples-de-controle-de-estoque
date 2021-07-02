using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CamadaDados
{
    public class DLogin
    {
        public bool tem = false;
        public string mensagem = "";
                   
        public bool verificarLogin(string login, string senha)
        {

            SqlConnection SqlCon = new SqlConnection();
            int dados;
            
            try
            {
                //Código
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand adpt = new SqlCommand("SELECT COUNT(id_funcionario) FROM FUNCIONARIO WHERE id_funcionario = @login AND senha = @senha", SqlCon);
                adpt.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                adpt.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                SqlCon.Open();
                dados = (int)adpt.ExecuteScalar();

                if (dados > 0)
                {
                    tem = true;
                }

            }
            catch (SqlException ex)
            {
                mensagem = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return tem;
                       
        }

    }
}
