/* 17/09/2016 19:52:07 */
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
    public class Itens_pagamento : Entity
    {
        public int Id { get; set; }
        public int Operadoras_cartao_id { get; set; }
        public int Contas_bancarias_id { get; set; }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
        public decimal Valor { get; set; }
        public int Movimentos_id { get; set; }
        public int Formas_pagamento_id { get; set; }
    }
}
