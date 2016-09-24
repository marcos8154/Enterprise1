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
    public class Permissoes : Entity
    {
        public int Rotina_id { get; set; }
        public bool Acesso { get; set; }
        public bool Inserir { get; set; }
        public bool Alterar { get; set; }
        public bool Excluir { get; set; }
        public int Grupos_id { get; set; }
    }
}
