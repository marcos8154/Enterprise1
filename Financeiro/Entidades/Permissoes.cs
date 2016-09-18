/* 17/09/2016 19:52:07 */
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
        public bool Admin { get; set; }
        public bool Movimentos_acesso { get; set; }
        public bool Movimentos_incluir { get; set; }
        public bool Formas_pg_acesso { get; set; }
        public bool Formas_pg_incluir { get; set; }
        public bool Formas_pg_alt { get; set; }
        public bool Formas_pg_excl { get; set; }
        public bool Cxa_abrir { get; set; }
        public bool Cxa_fechar { get; set; }
        public bool Cxa_retirada { get; set; }
        public bool Situacao_clientes_acesso { get; set; }
        public bool Comissao_vendedores_acesso { get; set; }
        public bool Ped_vnd_acesso { get; set; }
        public bool Ped_vnd_incluir { get; set; }
        public bool Ped_vnd_alt { get; set; }
        public bool Ped_vnd_excl { get; set; }
        public bool Ped_compra_acesso { get; set; }
        public bool Ped_compra_incluir { get; set; }
        public bool Ped_compra_baixa { get; set; }
        public bool Devolucao_acesso { get; set; }
        public bool Devolucao_efetuar { get; set; }
        public bool Cad_item_acesso { get; set; }
        public bool Cad_item_incluir { get; set; }
        public bool Cadastro_item_alterar { get; set; }
        public bool Cad_item_excluir { get; set; }
        public bool Consulta_items_acesso { get; set; }
        public bool Entrada_item_acesso { get; set; }
        public bool Saida_item_acesso { get; set; }
        public bool Pessoas_acesso { get; set; }
        public bool Cad_pessoas_acesso { get; set; }
        public bool Cad_pessoas_incluir { get; set; }
        public bool Cad_pessoas_alterar { get; set; }
        public bool Cad_pessoas_excluir { get; set; }
        public int Usuarios_id { get; set; }
    }
}
