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
    public class Tipos_movimento : Entity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Movimentacao_itens { get; set; }
        public int Movimentacao_valores { get; set; }
        public bool Gera_comissao { get; set; }
        public bool Permite_desconto { get; set; }
        public bool Informar_cliente { get; set; }
        public bool Informar_fornecedor { get; set; }
        public bool Informar_funcionario { get; set; }
        public bool Ativo { get; set; }
    }
}
