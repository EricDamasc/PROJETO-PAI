using Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class MotoristaDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        public DataTable ObterDados(int tipo, String filtro)
        {
            try
            {
                if (tipo == 0)
                {
                    return Conexao.obterDados("SELECT DATEPART ( DAY , '10/01/2021' )");
                }
                else if (tipo == 1)
                {
                    return Conexao.obterDados("SELECT DATEPART ( MONTH , '10/01/2021' )");
                }

                else if (tipo == 2)
                {
                    return Conexao.obterDados("SELECT DATEPART ( YEAR , '10/01/2021' )");
                }

                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        // METÓDO PARA INSERIR MOTORISTA
        public void Inserir(MotoristaDto Motorista)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO Motoristas (placa, senha, nome, carro, datadeinicio) " +
                "VALUES " +
                "('" + Motorista.Placa + "','" + Motorista.Senha + "','" + Motorista.motorista + "','" + Motorista.Carro + "','" + Motorista.Data + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA EXCLUIR MOTORISTA
        public void Excluir(int placa)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM Motoristas WHERE placa = " + placa + "";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<MotoristaDto> obterDados(int tipo, String filtro)
        {
            List<MotoristaDto> motoristaDtos = new List<MotoristaDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select placa, senha, nome, carro, datadeinicio" +
                                              " from Motoristas");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select placa, senha, nome, carro, datadeinicio" +
                                              " from Motoristas " +
                                              " where nome like '%" + filtro + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    MotoristaDto MotoristaDto = new MotoristaDto();

                    MotoristaDto.Placa = (_readersql["placa"].ToString());
                    MotoristaDto.Senha = (_readersql["senha"].ToString());
                    MotoristaDto.motorista = (_readersql["nome"].ToString());
                    MotoristaDto.Carro = (_readersql["carro"].ToString());
                    MotoristaDto.Data = Convert.ToDateTime(_readersql["datadeinicio"].ToString());

                    motoristaDtos.Add(MotoristaDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return motoristaDtos;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public string ObterCombo(int codigo)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                    "select placa " +
                     "  from tblveiculo" +
                     " where placa = @placa";

                _comandoSql.Parameters.Add("@placa", SqlDbType.Int).Value = codigo;

                string x = _comandoSql.ExecuteScalar().ToString();
                Conexao.fecharConexao(_conexao);
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String obternome(String placa)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select datadacorrida from tbluber where datadacorrida = " + placa;

                String x = _comandoSql.ExecuteScalar().ToString();
                Conexao.fecharConexao(_conexao);
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
