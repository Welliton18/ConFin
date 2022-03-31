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
                string sql = "SELECT CID_CODIGO, NOME, CIDADE.EST_SIGLA, ESTADO.NOME" +
                               "FROM CIDADE " +
                               "JOIN ESTADO ON ESTADO.EST_SIGLA = CIDADE.EST_SIGLA";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read()) {
                    Cidade cidade = new Cidade() {
                        cid_codigo = dr.GetInt32(0),
                        nome       = dr.GetString(1),
                    };

                    lista.Add(cidade);
                }
            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return lista;
        }

    }
}
