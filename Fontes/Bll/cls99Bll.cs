using Dal;
using Dto;
using System;
using System.Collections.Generic;

namespace Bll
{
    public class cls99Bll
    {
        private cls99Dal _taxi99;

        /* Método construtor (Fundamentos POO) */

        public cls99Bll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _taxi99 = new cls99Dal();
        }

        public void Inserir(cls99Dto taxi99Dto)
        {
            try
            {
                if (taxi99Dto.DatadaCorridas.ToString() == String.Empty)
                {
                    throw new Exception("O campo Data é obrigatório!");
                }

                _taxi99.Inserir(taxi99Dto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(cls99Dto taxi99Dto)
        {
            try
            {
                if (taxi99Dto.DatadaCorridas.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _taxi99.Alterar(taxi99Dto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int taxi99Dto)
        {
            try
            {
                if (taxi99Dto <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _taxi99.Excluir(taxi99Dto);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<cls99Dto> ObterDados(int tipo, String filtro)
        {
            cls99Dal _taxi99Dal = new cls99Dal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _taxi99Dal.obterDados(tipo, filtro);
                }

                else
                {
                    throw new Exception("A informação do Tipo para a consulta não foi fornecedida!");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<cls99Dto> obterDados(String filtro)
        {
            cls99Dal _99Dal = new cls99Dal();

            try
            {

                if (filtro == "DATA")
                {
                    return _99Dal.obterDados(2, filtro);
                }
                else
                {
                    throw new Exception("Não foi possivel realizar a busca");
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
