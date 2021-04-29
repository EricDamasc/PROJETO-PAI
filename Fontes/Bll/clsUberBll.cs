using Dal;
using Dto;
using System;
using System.Collections.Generic;

namespace Bll
{
    public class clsUberBll
    {
        private clsUberDal _uber;

        /* Método construtor (Fundamentos POO) */

        public clsUberBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _uber = new clsUberDal();
        }

        public void Inserir(clsUberDto uberDto)
        {
            try
            {
                if (uberDto.DatadaCorridas.ToString() == String.Empty)
                {
                    throw new Exception("O campo Data é obrigatório!");
                }

                _uber.Inserir(uberDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsUberDto uberDto)
        {
            try
            {
                if (uberDto.DatadaCorridas.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _uber.Alterar(uberDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int uberDto)
        {
            try
            {
                if (uberDto <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _uber.Excluir(uberDto);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsUberDto> ObterDados(int tipo, String filtro)
        {
            clsUberDal _uberDal = new clsUberDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _uberDal.obterDados(tipo, filtro);
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

        public List<clsUberDto> obterDados(String filtro)
        {
            clsUberDal _uberDal = new clsUberDal();

            try
            {

                if (filtro == "DATA")
                {
                    return _uberDal.obterDados(2, filtro);
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
