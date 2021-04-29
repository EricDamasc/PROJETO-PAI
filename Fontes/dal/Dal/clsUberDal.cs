using Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class clsUberDal
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

        private Int32 obterProximocodigo()
        {

            Int32 proximoNum;

            _conexao = Conexao.ObterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idcarro) + 1), 1) AS proximoNum FROM tbluber";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }

        // METÓDO PARA INSERIR VEICULO
        public void Inserir(clsUberDto Uber)
        {
            try
            {
                Uber.IdCarro = obterProximocodigo();
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tbluber (idcarro, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao) " +
                "VALUES " +
                "('" + Uber.IdCarro + "','" + Uber.DatadaCorridas + "','" + Uber.Horas + "','" + Uber.KM + "'," + Uber.Corridas + ",'" + Uber.Combustivel + "','"
                + Uber.Ganhos + "','" + Uber.Gastos + "','" + Uber.OBSUBER + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR VEICULO
        public void Alterar(clsUberDto Uber)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                "UPDATE tbluber " +
                " SET horas = '" + Uber.Horas + "'," +
                " km = '" + Uber.KM + "'," +
                " corridas =  " + Uber.Corridas + "," +
                " combustivel = '" + Uber.Combustivel.Trim() + "'," +
                " ganhos = '" + Uber.Ganhos + "'," +
                " gasto = " + Uber.Gastos + "," +
                " observacao = '" + Uber.OBSUBER + "'," +
                " datadacorrida = '" + Uber.DatadaCorridas + "'" +
                " WHERE idcarro = '" + Uber.IdCarro + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }

        }

        // METÓDO PARA EXCLUIR VEICULO
        public void Excluir(int idcarro)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tbluber WHERE idcarro = " + idcarro + "";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsUberDto> obterdadosCombo()
        {
            List<clsUberDto> uberDtos = new List<clsUberDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select placa, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao" +
                                              " from tbluber");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsUberDto uberDto = new clsUberDto();

                uberDto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                uberDto.Horas = (_readersql["horas"].ToString());
                uberDto.KM = (_readersql["km"].ToString());
                uberDto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                uberDto.Combustivel = (_readersql["combustivel"].ToString());
                uberDto.Ganhos = (_readersql["ganhos"].ToString());
                uberDto.Gastos = (_readersql["gasto"].ToString());
                uberDto.OBSUBER = (_readersql["observacao"].ToString());

                uberDtos.Add(uberDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return uberDtos;
        }

        public List<clsUberDto> obterDados(int tipo, String filtro)
        {
            List<clsUberDto> UberDtos = new List<clsUberDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idcarro, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao" +
                                              " from tbluber");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select idcarro, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao" +
                                              " from tbluber " +
                                              " where datadacorrida like '%" + filtro + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsUberDto uberDto = new clsUberDto();

                    uberDto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    uberDto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    uberDto.Horas = (_readersql["horas"].ToString());
                    uberDto.KM = (_readersql["km"].ToString());
                    uberDto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    uberDto.Combustivel = (_readersql["combustivel"].ToString());
                    uberDto.Ganhos = (_readersql["ganhos"].ToString());
                    uberDto.Gastos = (_readersql["gasto"].ToString());
                    uberDto.OBSUBER = (_readersql["observacao"].ToString());

                    UberDtos.Add(uberDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return UberDtos;

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

        public List<clsUberDto> obterData(String data)
        {
            List<clsUberDto> UberDtos = new List<clsUberDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select * from tbluber order by datadacorrida desc ";

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsUberDto uberDto = new clsUberDto();

                    uberDto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    uberDto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    uberDto.Horas = (_readersql["horas"].ToString());
                    uberDto.KM = (_readersql["km"].ToString());
                    uberDto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    uberDto.Combustivel = (_readersql["combustivel"].ToString());
                    uberDto.Ganhos = (_readersql["ganhos"].ToString());
                    uberDto.Gastos = (_readersql["gasto"].ToString());
                    uberDto.OBSUBER = (_readersql["observacao"].ToString());

                    UberDtos.Add(uberDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return UberDtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<clsUberDto> obterCorridas(String corridas)
        {
            List<clsUberDto> UberDtos = new List<clsUberDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select * from tbluber order by corridas DESC";

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsUberDto uberDto = new clsUberDto();

                    uberDto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    uberDto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    uberDto.Horas = (_readersql["horas"].ToString());
                    uberDto.KM = (_readersql["km"].ToString());
                    uberDto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    uberDto.Combustivel = (_readersql["combustivel"].ToString());
                    uberDto.Ganhos = (_readersql["ganhos"].ToString());
                    uberDto.Gastos = (_readersql["gasto"].ToString());
                    uberDto.OBSUBER = (_readersql["observacao"].ToString());

                    UberDtos.Add(uberDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return UberDtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<clsUberDto> obterCombustivel(String Combustivel)
        {
            List<clsUberDto> UberDtos = new List<clsUberDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select * from tbluber order by combustivel DESC ";
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsUberDto uberDto = new clsUberDto();

                    uberDto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    uberDto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    uberDto.Horas = (_readersql["horas"].ToString());
                    uberDto.KM = (_readersql["km"].ToString());
                    uberDto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    uberDto.Combustivel = (_readersql["combustivel"].ToString());
                    uberDto.Ganhos = (_readersql["ganhos"].ToString());

                    uberDto.Gastos = (_readersql["gasto"].ToString());
                    uberDto.OBSUBER = (_readersql["observacao"].ToString());

                    UberDtos.Add(uberDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return UberDtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
