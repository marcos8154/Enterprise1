﻿using Entidades;
using Financeiro.SessionProvider;
using Persistor.EntityManager;
using Persistor.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Financeiro.Controllers
{
    public class EmpresaController
    {
        public static Empresa Carregar()
        {
            Session session = null;

            try
            {
                session = new ConfigureSession().GetSession();
                Empresa empresa = new Empresa();

                session.OnID(empresa, 1);
                session.Close();

                return empresa;

            }
            catch(Exception ex)
            {
                Log.Write("EmpresaController", "Carregar", ex.Message);
                if (session != null) session.Close();
                return null;
            }
        }

        public static bool Salvar(Empresa empresa, Enderecos endereco)
        {
            Session session = null;

            try
            {
                if (!ValidaEmpresa(empresa)) return false;
                if (!ValidaEndereco(endereco)) return false;

                bool result = false;
                empresa.Enderecos_id = endereco.Id;

                session = new ConfigureSession().GetSession();
                Transaction transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

                if (EntidadeController.Existe(empresa, "id", empresa.Id.ToString()))
                {
                    session.Update(endereco, null, transaction);
                    session.Update(empresa, null, transaction);

                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Empresa alterada.");
                }
                else
                {
                    session.Save(endereco, transaction);
                    empresa.Enderecos_id = endereco.Id;
                    session.Save(empresa, transaction);

                    Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.SUCESSO, "Empresa salva.");
                }

                if (transaction.Commit()) result = true;

                session.Close();

                return result;
            }
            catch (Exception ex)
            {
                Log.Write("EmpresaController", "Salvar", ex.Message);
                if (session != null) session.Close();
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ERRO, "Ocorreu um problema interno ao realizar a operação: " + ex.Message);
                return false;
            }
        }

        private static bool ValidaEmpresa(Empresa empresa)
        {
            if (string.IsNullOrWhiteSpace(empresa.Nome_fantasia))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O nome fantasia não pode estar vazio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(empresa.Razao_social))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "A razão social não pode estar vazia.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(empresa.CNPJ))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O CNPJ não pode estar vazio.");
                return false;
            }

            return true;
        }

        private static bool ValidaEndereco(Enderecos endereco)
        {
            if (endereco.CEP.StartsWith("_"))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "CEP inválido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(endereco.Logradouro))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O logradouro é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(endereco.Municipio))
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O município é obrigatório.");
                return false;
            }

            if (endereco.Numero == 0)
            {
                Notificacao.Publicar(Enums.TIPO_NOTIFICACAO.ALERTA, "O número é obrigatório.");
                return false;
            }

            return true;
        }

    }
}