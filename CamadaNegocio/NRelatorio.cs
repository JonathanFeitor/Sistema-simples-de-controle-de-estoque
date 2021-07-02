using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NRelatorio
    {
        ///Método Buscar
        ///
        public static DataTable MostrarRelatorioMateriais(string tipo_material, string formula, DateTime data1, DateTime data2)
        {
            DRelatorio Rel = new DRelatorio();
            Rel.Tipo_Equipamento = tipo_material.ToUpper();
            Rel.CheckMovimentacao = formula;
            Rel.ConverterData(data1, data2);
            return Rel.RelatorioMateriais(Rel);
        }

        ///Método Buscar
        ///
        public static DataTable MostraRelatorioInventario(string tipo_equipamento, string status_equipamento)
        {
            DRelatorio Rel = new DRelatorio();
            Rel.Tipo_Equipamento = tipo_equipamento.ToUpper();
            Rel.StatusEquipamento = status_equipamento;
            return Rel.RelatorioEquipamento(Rel);

        }
    }
}
