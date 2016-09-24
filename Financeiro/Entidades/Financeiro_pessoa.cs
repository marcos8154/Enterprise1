/* 24/09/2016 12:55:44 */
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
    public class Financeiro_pessoa : Entity
    {
        public int Id { get; set; }
        public string Endereco_cobranca { get; set; }
        public string Endereco_entrega { get; set; }
        public decimal Credito { get; set; }
        public decimal Limite_credito { get; set; }
        public decimal Debito { get; set; }
        public double Desconto { get; set; }
        public DateTime Ultima_compra { get; set; }
        public double Comissao { get; set; }
        public double Salario { get; set; }
        public DateTime Data_admissao { get; set; }
        public DateTime Data_demissao { get; set; }
    }
}
