using Confin.Controle;
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
    }
}
