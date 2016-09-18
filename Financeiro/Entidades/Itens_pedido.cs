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
    public class Itens_pedido : Entity
    {
        public int Id { get; set; }
        public decimal Valor_unit { get; set; }
        public double QNTD { get; set; }
        public decimal Total { get; set; }
        public int Pedidos_compra_id { get; set; }
        public int Produtos_id { get; set; }
    }
}
