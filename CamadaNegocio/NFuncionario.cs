using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NFuncionario
    {

        //Método Inserir
        public static string Inserir(string id_funcionario, string nome_funcionario, string cargo_funcionario, string tel_funcionario, string senha_funcionario)
        {
            DFuncionario Fun = new CamadaDados.DFuncionario();

            Fun.Id_funcionario = id_funcionario.ToUpper();
            Fun.Nome = nome_funcionario.ToUpper();
            Fun.Cargo = cargo_funcionario.ToUpper();
            Fun.Telefone = tel_funcionario;
            Fun.Senha = senha_funcionario;

            return Fun.Insert(Fun);
        }

        //Método Editar
        public static string Editar(string id_funcionario, string nome_funcionario, string cargo_funcionario, string tel_funcionario, string senha_funcionario)
        {
            DFuncionario Fun = new CamadaDados.DFuncionario();

            Fun.Id_funcionario = id_funcionario.ToUpper();
            Fun.Nome = nome_funcionario.ToUpper();
            Fun.Cargo = cargo_funcionario.ToUpper();
            Fun.Telefone = tel_funcionario;
            Fun.Senha = senha_funcionario;

            return Fun.Editar(Fun);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DFuncionario().MostrarFuncionario();
        }

        //Método Buscar
        public static DataTable BuscarFuncionario(string buscar_fucionario)
        {
            DFuncionario Fun = new DFuncionario();
            Fun.BuscarFuncionario = buscar_fucionario.ToUpper();
            return Fun.BuscarTipoFuncionario(Fun);
        }

        //Método Deletar
        public static string Excluir(string id_funcionario)
        {
            DFuncionario Fun = new DFuncionario();
            Fun.Id_funcionario = id_funcionario.ToUpper();

            return Fun.ExcluirFuncionario(Fun);
        }

    }
}
