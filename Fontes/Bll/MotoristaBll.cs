using Dal;
using Dto;
using System;
using System.Collections.Generic;

namespace Bll
{
    public class MotoristaBll
    {
        private MotoristaDal _motoristas;

        /* Método construtor (Fundamentos POO) */

        public MotoristaBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _motoristas = new MotoristaDal();
        }

        public void Inserir(MotoristaDto motoristaDto)
        {
            try
            {
                if (motoristaDto.Placa.ToString() == String.Empty)
                {
                    throw new Exception("O campo Placa é obrigatório!");
                }

                _motoristas.Inserir(motoristaDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int motoristaDto)
        {
            try
            {
                if (motoristaDto <= 0)
                {
                    throw new Exception("O campo Placa não pode ser zero ou negativo.");
                }

                _motoristas.Excluir(motoristaDto);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<MotoristaDto> ObterDados(int tipo, String filtro)
        {
            MotoristaDal _motorista = new MotoristaDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _motorista.obterDados(tipo, filtro);
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

        public List<clsUberDto> obterDados(int tipo, String filtro)
        {
            clsUberDal _uberDal = new clsUberDal();

            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _uberDal.obterDados(tipo, filtro);
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
