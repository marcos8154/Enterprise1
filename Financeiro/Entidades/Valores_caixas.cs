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
    public class Valores_caixas : Entity
    {
        public int Id { get; set; }
        public int Caixas_id { get; set; }
        public int Entrada_saida { get; set; }
        public decimal Valor { get; set; }
    }
}
