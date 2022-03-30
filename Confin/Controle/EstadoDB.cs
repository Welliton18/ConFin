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
            } catch(Exception e) {
                Console.WriteLine("Erro de SQL: " + e.Message);
            }

            return lista;
        }

    }
}
