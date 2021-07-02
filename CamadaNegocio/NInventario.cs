using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;
using System.Collections;

namespace CamadaNegocio
{
    public class NInventario
    {
        //Método Inserir
        public static string Inserir(int num_inventario, string tipo_equipamento, string modelo_equipamento, string num_serial,
            string status_equipamento, string id_funcionario, string ip_equipamento, string localizacao, string descricao)
        {
            DInventario Inv = new CamadaDados.DInventario();

            Inv.NumInventario = num_inventario;
            Inv.TipoEquipamento = tipo_equipamento.ToUpper();
            Inv.ModeloEquipamento = modelo_equipamento.ToUpper();
            Inv.NumSerial = num_serial.ToUpper();
            Inv.StatusEquipamento = status_equipamento;
            Inv.DataEquipamento = DateTime.Now;
            Inv.IdFuncionario = id_funcionario.ToUpper();
            Inv.Descricao = descricao.ToUpper();
            Inv.IpEquipamento = ip_equipamento;
            Inv.Localizacao = localizacao.ToUpper();

            return Inv.Insert(Inv);
        }

        //Método Editar
        public static string Editar(int num_inventario, string tipo_equipamento, string modelo_equipamento, string num_serial, string status_equipamento,
            string id_funcionario, string ip_equipamento, string localizacao, string descricao)
        {
            DInventario Inv = new CamadaDados.DInventario();
            Inv.NumInventario = num_inventario;
            Inv.TipoEquipamento = tipo_equipamento.ToUpper();
            Inv.ModeloEquipamento = modelo_equipamento.ToUpper();
            Inv.NumSerial = num_serial.ToUpper();
            Inv.StatusEquipamento = status_equipamento;
            Inv.DataEquipamento = DateTime.Now;
            Inv.IdFuncionario = id_funcionario.ToUpper();
            Inv.Descricao = descricao.ToUpper();
            Inv.IpEquipamento = ip_equipamento;
            Inv.Localizacao = localizacao.ToUpper();

            return Inv.Editar(Inv);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DInventario().MostrarInventario();
        }

        //Método Buscar
        public static DataTable BuscarEquipamento(string buscar_equipamento)
        {
            DInventario Inv = new DInventario();
            Inv.BuscarInventario = buscar_equipamento.ToUpper();
            return Inv.BuscarTipoInventario(Inv);
        }

        //Método Deletar
        public static string Excluir(int num_inventario)
        {
            DInventario Inv = new DInventario();
            Inv.NumInventario = num_inventario;

            return Inv.ExcluirInventario(Inv);
        }

    }
}
