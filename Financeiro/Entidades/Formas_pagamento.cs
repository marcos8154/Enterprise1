/* 20/09/2016 18:29:03 */
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
    public class Formas_pagamento : Entity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Parcelado { get; set; }
        public int Maximo_parcelas { get; set; }
        public int Efetuado_em { get; set; }
        public bool Ativo { get; set; }
        public bool Utiliza_operadora { get; set; }
        public int Prazo_pagamento { get; set; }
        public int Tipo_prazo { get; set; }
    }
}
