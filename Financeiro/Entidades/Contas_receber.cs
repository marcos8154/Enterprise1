/* 20/09/2016 18:29:02 */
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
    public class Contas_receber : Entity
    {
        public int Id { get; set; }
        public int Loja { get; set; }
        public string Num_doc { get; set; }
        public int Movimentos_id { get; set; }
        public string Pagador { get; set; }
        public string Beneficiado { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public double Juros_dia { get; set; }
        public bool Pago { get; set; }
    }
}
