using Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class cls99Dal
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
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idcarro) + 1), 1) AS proximoNum FROM tbl99";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }

        // METÓDO PARA INSERIR VEICULO
        public void Inserir(cls99Dto Taxi99)
        {
            try
            {
                Taxi99.IdCarro = obterProximocodigo();
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tbl99 (idcarro, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao) " +
                "VALUES " +
                "('" + Taxi99.IdCarro + "','" + Taxi99.DatadaCorridas + "','" + Taxi99.Horas + "','" + Taxi99.KM + "'," + Taxi99.Corridas + ",'" + Taxi99.Combustivel + "','"
                + Taxi99.Ganhos + "','" + Taxi99.Gastos + "','" + Taxi99.OBS99 + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR VEICULO
        public void Alterar(cls99Dto Taxi99)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                "UPDATE tbl99 " +
                " SET horas = '" + Taxi99.Horas + "'," +
                " km = '" + Taxi99.KM + "'," +
                " corridas =  " + Taxi99.Corridas + "," +
                " combustivel = '" + Taxi99.Combustivel.Trim() + "'," +
                " ganhos = '" + Taxi99.Ganhos + "'," +
                " gasto = " + Taxi99.Gastos + "," +
                " observacao = '" + Taxi99.OBS99 + "'," +
                " datadacorrida = '" + Taxi99.DatadaCorridas + "'" +
                " WHERE idcarro = '" + Taxi99.IdCarro + "'";

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

                _comandoSql.CommandText = "DELETE FROM tbl99 WHERE idcarro = " + idcarro + "";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<cls99Dto> obterdadosCombo()
        {
            List<cls99Dto> taxi99Dtos = new List<cls99Dto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select placa, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao" +
                                              " from tbl99");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                cls99Dto taxi99Dto = new cls99Dto();

                taxi99Dto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                taxi99Dto.Horas = (_readersql["horas"].ToString());
                taxi99Dto.KM = (_readersql["km"].ToString());
                taxi99Dto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                taxi99Dto.Combustivel = (_readersql["combustivel"].ToString());
                taxi99Dto.Ganhos = (_readersql["ganhos"].ToString());
                taxi99Dto.Gastos = (_readersql["gasto"].ToString());
                taxi99Dto.OBS99 = (_readersql["observacao"].ToString());

                taxi99Dtos.Add(taxi99Dto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return taxi99Dtos;
        }

        public List<cls99Dto> obterDados(int tipo, String filtro)
        {
            List<cls99Dto> Taxi99Dtos = new List<cls99Dto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select idcarro, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao" +
                                              " from tbl99");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select idcarro, datadacorrida, horas, km, corridas, combustivel, ganhos, gasto, observacao" +
                                              " from tbl99 " +
                                              " where datadacorrida like '%" + filtro + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    cls99Dto taxi99Dto = new cls99Dto();

                    taxi99Dto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    taxi99Dto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    taxi99Dto.Horas = (_readersql["horas"].ToString());
                    taxi99Dto.KM = (_readersql["km"].ToString());
                    taxi99Dto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    taxi99Dto.Combustivel = (_readersql["combustivel"].ToString());
                    taxi99Dto.Ganhos = (_readersql["ganhos"].ToString());
                    taxi99Dto.Gastos = (_readersql["gasto"].ToString());
                    taxi99Dto.OBS99 = (_readersql["observacao"].ToString());

                    Taxi99Dtos.Add(taxi99Dto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return Taxi99Dtos;

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

        public List<cls99Dto> obterData(String data)
        {
            List<cls99Dto> Taxi99Dtos = new List<cls99Dto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select * from tbl99 order by datadacorrida desc ";

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    cls99Dto taxi99Dto = new cls99Dto();

                    taxi99Dto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    taxi99Dto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    taxi99Dto.Horas = (_readersql["horas"].ToString());
                    taxi99Dto.KM = (_readersql["km"].ToString());
                    taxi99Dto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    taxi99Dto.Combustivel = (_readersql["combustivel"].ToString());
                    taxi99Dto.Ganhos = (_readersql["ganhos"].ToString());
                    taxi99Dto.Gastos = (_readersql["gasto"].ToString());
                    taxi99Dto.OBS99 = (_readersql["observacao"].ToString());

                    Taxi99Dtos.Add(taxi99Dto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return Taxi99Dtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<cls99Dto> obterCorridas(String corridas)
        {
            List<cls99Dto> Taxi99Dtos = new List<cls99Dto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select * from tbl99 order by corridas DESC";

                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    cls99Dto taxi99Dto = new cls99Dto();

                    taxi99Dto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    taxi99Dto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    taxi99Dto.Horas = (_readersql["horas"].ToString());
                    taxi99Dto.KM = (_readersql["km"].ToString());
                    taxi99Dto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    taxi99Dto.Combustivel = (_readersql["combustivel"].ToString());
                    taxi99Dto.Ganhos = (_readersql["ganhos"].ToString());
                    taxi99Dto.Gastos = (_readersql["gasto"].ToString());
                    taxi99Dto.OBS99 = (_readersql["observacao"].ToString());

                    Taxi99Dtos.Add(taxi99Dto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return Taxi99Dtos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<cls99Dto> obterCombustivel(String Combustivel)
        {
            List<cls99Dto> Taxi99Dtos = new List<cls99Dto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select * from tbl99 order by combustivel DESC ";
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    cls99Dto taxi99Dto = new cls99Dto();

                    taxi99Dto.IdCarro = Convert.ToInt32(_readersql["idcarro"].ToString());
                    taxi99Dto.DatadaCorridas = Convert.ToDateTime(_readersql["datadacorrida"].ToString());
                    taxi99Dto.Horas = (_readersql["horas"].ToString());
                    taxi99Dto.KM = (_readersql["km"].ToString());
                    taxi99Dto.Corridas = Convert.ToInt32(_readersql["corridas"].ToString());
                    taxi99Dto.Combustivel = (_readersql["combustivel"].ToString());
                    taxi99Dto.Ganhos = (_readersql["ganhos"].ToString());

                    taxi99Dto.Gastos = (_readersql["gasto"].ToString());
                    taxi99Dto.OBS99 = (_readersql["observacao"].ToString());

                    Taxi99Dtos.Add(taxi99Dto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return Taxi99Dtos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
