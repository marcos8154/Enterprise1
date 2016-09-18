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
    public class Cedentes : Entity
    {
        public int Id { get; set; }
        public int Contas_bancarias_id { get; set; }
        public int Carteira { get; set; }
        public int Convenio { get; set; }
        public double Taxa_servico { get; set; }
        public string Cod_cedente { get; set; }
        public int Modalidade { get; set; }
        public string Proximo_doc { get; set; }
        public string Especie_doc { get; set; }
        public string Aceite { get; set; }
        public string Local_pagamento { get; set; }
        public double Multa { get; set; }
        public double Juros_diarios { get; set; }
        public string Instrucoes { get; set; }
    }
}
