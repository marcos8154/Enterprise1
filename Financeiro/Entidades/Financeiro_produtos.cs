/* 18/09/2016 15:22:56 */
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
    public class Financeiro_produtos : Entity
    {
        public int Id { get; set; }
        public DateTime Ultima_compra { get; set; }
        public DateTime Ultima_venda { get; set; }
        public decimal Preco_custo { get; set; }
        public double Margem_lucro { get; set; }
        public decimal Preco_venda { get; set; }
        public DateTime Ultimo_reajuste { get; set; }
        public decimal Ultimo_preco { get; set; }
        public int Produtos_id { get; set; }
    }
}
