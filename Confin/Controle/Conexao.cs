using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Controle {
    public class Conexao {

        public static NpgsqlConnection GetConexao() {
            NpgsqlConnection conexao = null;

            try {
                conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres; Database=financeiro;");
                conexao.Open();
                Console.WriteLine("Conexão OK");
            } catch(Exception e) {
                Console.WriteLine("Erro ao concectar o banco:" + e.Message);
            }

            return conexao;
        }

        public static void SetFechaConexao(NpgsqlConnection conexao) {
            if(conexao != null) {
                try {
                    conexao.Close();
                    Console.WriteLine("Fechamento OK");
                } catch(Exception e) {
                    Console.WriteLine("Erro ao fechar conexão banco:" + e.Message);
                }
            }
        }

    }

}
