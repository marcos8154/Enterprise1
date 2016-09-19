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
    public class Itens_sc : Entity
    {
        public int Id { get; set; }
        public int Produtos_id { get; set; }
        public double Quant { get; set; }
        public int Solicitacao_id { get; set; }
    }
}
