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
    public class Pessoas : Entity
    {
        public int Id { get; set; }
        public string Razao_social { get; set; }
        public string Nome_fantasia { get; set; }
        public string Contato { get; set; }
        public string Cargo { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public string Website { get; set; }
        public int TIPO_PESSOA { get; set; }
        public bool Inativo { get; set; }
        public int Financeiro_pessoa_id { get; set; }
        public int Enderecos_id { get; set; }
        public int Documentos_id { get; set; }
    }
}
