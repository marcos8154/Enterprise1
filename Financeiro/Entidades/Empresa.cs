/* 20/09/2016 20:06:29 */
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
    public class Empresa : Entity
    {
        public int Id { get; set; }
        public string Nome_fantasia { get; set; }
        public string Razao_social { get; set; }
        public string CNPJ { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Responsavel { get; set; }
        public bool Ativo { get; set; }
        public int Tipo { get; set; }
        public int Enderecos_id { get; set; }
    }
}
