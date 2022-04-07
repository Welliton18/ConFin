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
            /**List<Estado> lista = EstadoDB.GetEstados(conexao);

            richTextBox1.Clear();

            lista.ForEach(listar);

            
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

            List<Cidade> lista = CidadeDB.GetCidades(conexao);

            richTextBox1.Clear();

            lista.ForEach(listar);
        }

        void listar(Estado estado) {
            richTextBox1.AppendText("Sigla:" + estado.est_sigla);
            richTextBox1.AppendText("- Nome:" + estado.nome);
            richTextBox1.AppendText("\n");
        }
        void listar(Cidade cidade) {
            richTextBox1.AppendText("Código:" + cidade.cid_codigo);
            richTextBox1.AppendText("- Nome:" + cidade.nome);
            richTextBox1.AppendText("- Sigla Estado:" + cidade.Estado.est_sigla);
            richTextBox1.AppendText("- Nome Estado:" + cidade.Estado.nome);
            richTextBox1.AppendText("\n");
        }

        private void button_Incluir_Click(object sender, EventArgs e) {
            /*Estado estado = new Estado("RJ", "Rio de Janeiro");
            bool retorno  = EstadoDB.SetInsereEstado(estado, conexao);*/

            Cidade cidade = new Cidade(3, "Vidal Ramos", "SC");
            bool retorno = CidadeDB.SetInsereCidade(cidade, conexao);

            if(retorno) {
                MessageBox.Show("Cidade Inserido!");
                button_Listar_Click(sender, e);
            } else {
                MessageBox.Show("Erro ao Inserir Cidade!");
            }
        }

        private void button_Click_Alterar(object sender, EventArgs e) {
            /*Estado estado = new Estado("RJ", "Rio de Janeiro");
            bool retorno = EstadoDB.SetAlteraEstado(estado, conexao);*/

            Cidade cidade = new Cidade(3, "Vidal Ramos2", "SC");
            bool retorno = CidadeDB.SetAlteraCidade(cidade, conexao);

            if(retorno) {
                MessageBox.Show("Cidade Alterado!");
                button_Listar_Click(sender, e);
            } else {
                MessageBox.Show("Erro ao Alterar Cidade!");
            }
        }

        private void button_Click_Excluir(object sender, EventArgs e) {
            /*string sigla = "RJ";
            bool retorno = EstadoDB.SetExcluirEstado(sigla, conexao);*/

            int codigo = 3;
            bool retorno = CidadeDB.SetExcluirCidade(codigo, conexao);
            if(retorno) {
                MessageBox.Show("Cidade Excluído!");
                button_Listar_Click(sender, e);
            } else {
                MessageBox.Show("Erro ao Excluir Cidade!");
            }
        }
    }
}
