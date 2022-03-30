using Confin.Controle;
using Confin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confin {
    public partial class frmPrincipal : Form {

        NpgsqlConnection conexao = null;

        public frmPrincipal() {
            conexao = Conexao.GetConexao();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
            Conexao.SetFechaConexao(conexao);
        }

        private void button_Listar_Click(object sender, EventArgs e) {
            List<Estado> lista = EstadoDB.GetEstados(conexao);

            richTextBox1.Clear();

            lista.ForEach(listar);

            /*
            foreach(Estado estado in lista) {
                richTextBox1.AppendText("Sigla:" + estado.est_sigla);
                richTextBox1.AppendText(" Nome:" + estado.nome);
                richTextBox1.AppendText("\n");
            }
            
            for(int i = 0; i < lista.Count; i++) {
                Estado estado = lista[i];

                richTextBox1.AppendText("Sigla:" + estado.est_sigla);
                richTextBox1.AppendText(" Nome:" + estado.nome);
                richTextBox1.AppendText("\n");
            }*/
        }

        void listar(Estado estado) {
            richTextBox1.AppendText("Sigla:" + estado.est_sigla);
            richTextBox1.AppendText("- Nome:" + estado.nome);
            richTextBox1.AppendText("\n");
        }
    }
}
