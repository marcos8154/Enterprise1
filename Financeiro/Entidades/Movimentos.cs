/* 18/09/2016 15:22:55 */
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
    public class Movimentos : Entity
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public bool Cancelado { get; set; }
        public string Obs { get; set; }
        public int Tipos_movimento_id { get; set; }
        public int Caixas_id { get; set; }
        public int Id_funcionario { get; set; }
        public int Id_cliente { get; set; }
        public int Id_fornecedor { get; set; }
    }
}
