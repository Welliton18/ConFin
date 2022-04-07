using Confin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Controle {
    public class EstadoDB {

        public static List<Estado> GetEstados(NpgsqlConnection conexao) {
            List<Estado> lista = new List<Estado>();

            try {
                string sql          = "SELECT EST_SIGLA, NOME FROM ESTADO";
                NpgsqlCommand cmd   = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read()) {
                    string sigla = dr.GetString(0);
                    string nome  = dr.GetString(1);

                    lista.Add(new Estado(sigla, nome));
                }

                dr.Close();
            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return lista;
        }

        public static bool SetInsereEstado(Estado estado, NpgsqlConnection conexao) {
            bool retorno = false;

            try {
                string sql = "INSERT INTO ESTADO(EST_SIGLA, NOME) VALUES(@sigla, @nome)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.est_sigla;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;

                int valor = cmd.ExecuteNonQuery();

                retorno = valor == 1;

            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return retorno;
        }

        public static bool SetAlteraEstado(Estado estado, NpgsqlConnection conexao) {
            bool retorno = false;

            try {
                string sql = "UPDATE ESTADO SET NOME = @nome WHERE EST_SIGLA = @sigla";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.est_sigla;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;

                int valor = cmd.ExecuteNonQuery();

                retorno = valor == 1;

            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return retorno;
        }

        public static bool SetExcluirEstado(string sigla, NpgsqlConnection conexao) {
            bool retorno = false;

            try {
                string sql = "DELETE FROM ESTADO WHERE EST_SIGLA = @sigla";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = sigla;

                int valor = cmd.ExecuteNonQuery();

                retorno = valor == 1;

            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return retorno;
        }

    }
}
