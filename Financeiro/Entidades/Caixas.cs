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
    public class Caixas : Entity
    {
        public int Id { get; set; }
        public int Loja { get; set; }
        public DateTime Data_abertura { get; set; }
        public DateTime Data_fechamento { get; set; }
        public decimal Valor_entrada { get; set; }
        public int Usuarios_id { get; set; }
    }
}
