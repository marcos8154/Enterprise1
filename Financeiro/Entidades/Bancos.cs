/* 19/09/2016 20:51:33 */
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
    public class Bancos : Entity
    {
        public int Id { get; set; }
        public int Numero_banco { get; set; }
        public string Nome { get; set; }
        public string Agencia { get; set; }
        public string Correntista { get; set; }
        public string Gerente { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public int Enderecos_id { get; set; }
    }
}
