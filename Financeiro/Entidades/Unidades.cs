/* 17/09/2016 19:52:06 */
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
    public class Unidades : Entity
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public bool Fracionavel { get; set; }
    }
}
