using Confin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Controle {
    public class CidadeDB {

        public static List<Cidade> GetCidades(NpgsqlConnection conexao) {
            List<Cidade> lista = new List<Cidade>();

            try {
                string sql = "SELECT CIDADE.CID_CODIGO, CIDADE.NOME, CIDADE.EST_SIGLA, ESTADO.NOME " +
                               "FROM CIDADE JOIN ESTADO ON ESTADO.EST_SIGLA = CIDADE.EST_SIGLA";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read()) {
                    Cidade cidade = new Cidade() {
                        cid_codigo = dr.GetInt32(0),
                        nome       = dr.GetString(1),
                        Estado     = new Estado(dr.GetString(2), dr.GetString(3))
                    };
                    lista.Add(cidade);
                }

                dr.Close();
            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return lista;
        }
        public static bool SetInsereCidade(Cidade cidade, NpgsqlConnection conexao) {
            bool retorno = false;

            try {
                string sql = "INSERT INTO CIDADE(CID_CODIGO, NOME, EST_SIGLA) " +
                             "VALUES(@codigo, @nome, @siglaEstado)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.cid_codigo;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("@siglaEstado", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.Estado.est_sigla;

                int valor = cmd.ExecuteNonQuery();

                retorno = valor == 1;

            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return retorno;
        }

        public static bool SetAlteraCidade(Cidade cidade, NpgsqlConnection conexao) {
            bool retorno = false;

            try {
                string sql = "UPDATE CIDADE " +
                             "SET NOME = @nome, EST_SIGLA = @siglaEstado  " +
                             "WHERE CID_CODIGO = @codigo";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = cidade.cid_codigo;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.nome;
                cmd.Parameters.Add("@siglaEstado", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cidade.Estado.est_sigla;

                int valor = cmd.ExecuteNonQuery();

                retorno = valor == 1;

            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return retorno;
        }

        public static bool SetExcluirCidade(int codigo, NpgsqlConnection conexao) {
            bool retorno = false;

            try {
                string sql = "DELETE FROM CIDADE WHERE CID_CODIGO = @codigo";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;

                int valor = cmd.ExecuteNonQuery();

                retorno = valor == 1;

            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return retorno;
        }

    }
}
