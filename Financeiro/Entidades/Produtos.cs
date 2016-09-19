/* 19/09/2016 20:51:34 */
/* AUTO-GENERATED CLASS */
/* DOES NOT ADD PROPERTIES */
/* DOES NOT CHANGE NAME OF PROPERTIES */
/* IMPLEMENTS INTERFACES OR ABSTRACT CLASSES DOES NOT CHANGE THE OPERATION */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistor.Persistence;
using Persistor_GA.AbstractClasses;

namespace Entidades
{
    public class Produtos : Entity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Descricao_reduzida { get; set; }
        public string Referencia { get; set; }
        public string EAN { get; set; }
        public int Unidade { get; set; }
        public int Segunda_unidade { get; set; }
        public int Fator_conversao { get; set; }
        public bool Para_venda { get; set; }
        public bool Para_balanca { get; set; }
        public bool Insumo { get; set; }
        public bool Fabricado { get; set; }
        public int Garantia_cliente { get; set; }
        public int Garantia_fornecedor { get; set; }
        public string Fabricante { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Data_cadastro { get; set; }
        public double Quant_total { get; set; }
        public double Quant_min { get; set; }
        public double Quant_max { get; set; }
        public byte[] Foto { get; set; }
        public int Grupos_id { get; set; }
        public bool Inativo { get; set; }
        public int Loja { get; set; }
        public int Locais_estoque_id { get; set; }
    }
}
