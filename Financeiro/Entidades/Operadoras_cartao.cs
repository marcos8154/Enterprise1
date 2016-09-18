/* 18/09/2016 15:22:53 */
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
    public class Operadoras_cartao : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Debito { get; set; }
        public int Credito { get; set; }
        public double Taxa { get; set; }
        public bool Ativo { get; set; }
    }
}
