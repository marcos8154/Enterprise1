/* 24/09/2016 12:55:45 */
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
    public class Pedidos_compra : Entity
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public DateTime Data_pedido { get; set; }
        public DateTime Prazo_entrega { get; set; }
        public decimal Total { get; set; }
        public string Obs { get; set; }
        public int Loja_pedido { get; set; }
        public int Loja_entrega { get; set; }
        public int Fornecedor_id { get; set; }
    }
}
