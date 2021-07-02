using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NMateriais
    {
        //Método Inserir
        public static string Inserir(string tipo_materiais, string modelo_materiais, int quantidade, string id_funcionario, string descricao)
        {
            DMateriais Mta = new CamadaDados.DMateriais();
            Mta.TipoMateriais = tipo_materiais.ToUpper();
            Mta.Modelo = modelo_materiais.ToUpper();
            Mta.Quantidade = quantidade;
            Mta.Data = DateTime.Now;
            Mta.IdFuncionario = id_funcionario.ToUpper();
            Mta.Descricao = descricao.ToUpper();

            return Mta.Insert(Mta);

        }

        //Método Editar
        public static string Editar(int id_material, string tipo_materiais, string modelo_materiais, string id_funcionario, string descricao)
        {
            DMateriais Mta = new CamadaDados.DMateriais();
            Mta.IdMaterial = id_material;
            Mta.TipoMateriais = tipo_materiais.ToUpper();
            Mta.Modelo = modelo_materiais.ToUpper();
            Mta.Data = DateTime.Now;
            Mta.IdFuncionario = id_funcionario;
            Mta.Descricao = descricao.ToUpper();

            return Mta.Editar(Mta);

        }

        //Método Mostrar
        public static DataTable Mostra()
        {
            return new DMateriais().MostrarMateriais();
        }

        //Método Buscar
        public static DataTable BuscarMateriais(string buscar_materiais)
        {
            DMateriais Mta = new DMateriais();
            Mta.BuscarMaterial = buscar_materiais.ToUpper();
            return Mta.BuscarTipoMateriais(Mta);
        }

        //Método Deletar
        public static string Excluir(int id_materiais)
        {
            DMateriais Obj = new CamadaDados.DMateriais();
            Obj.IdMaterial = id_materiais;
            
            return Obj.ExcluirMaterial(Obj);
        }

        //Método Somar Quantidade
        public static string SomaQuantidade(int id_material, string tipo_materiais, string modelo_materiais, int valor_materiais)
        {
            DMateriais Mta = new CamadaDados.DMateriais();
            Mta.IdMaterial = id_material;
            Mta.TipoMateriais = tipo_materiais.ToUpper();
            Mta.Modelo = modelo_materiais.ToUpper();
            Mta.Movimentacao = valor_materiais;
            Mta.Data = DateTime.Now;

            return Mta.SomaValorMateriais(Mta);
        }

        //Método Subtrair Quantidade
        public static string SubQuantidade(int id_material, string tipo_materiais, string modelo_materiais, int valor_materiais)
        {
            DMateriais Mta = new CamadaDados.DMateriais();
            Mta.IdMaterial = id_material;
            Mta.TipoMateriais = tipo_materiais.ToUpper();
            Mta.Modelo = modelo_materiais.ToUpper();
            Mta.Movimentacao = valor_materiais;
            Mta.Data = DateTime.Now;

            return Mta.SubValorMateriais(Mta);
        }
    }
}
