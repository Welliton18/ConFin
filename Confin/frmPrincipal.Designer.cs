namespace Confin {
    partial class frmPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.Button_Listar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Incluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Listar
            // 
            this.Button_Listar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Button_Listar.Location = new System.Drawing.Point(176, 74);
            this.Button_Listar.Name = "Button_Listar";
            this.Button_Listar.Size = new System.Drawing.Size(75, 23);
            this.Button_Listar.TabIndex = 0;
            this.Button_Listar.Text = "Listar";
            this.Button_Listar.UseVisualStyleBackColor = true;
            this.Button_Listar.Click += new System.EventHandler(this.button_Listar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(565, 173);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button_Incluir
            // 
            this.button_Incluir.Location = new System.Drawing.Point(367, 74);
            this.button_Incluir.Name = "button_Incluir";
            this.button_Incluir.Size = new System.Drawing.Size(75, 23);
            this.button_Incluir.TabIndex = 2;
            this.button_Incluir.Text = "Incluir";
            this.button_Incluir.UseVisualStyleBackColor = true;
            this.button_Incluir.Click += new System.EventHandler(this.button_Incluir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.button_Incluir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Button_Listar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConFin - Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Listar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Incluir;
    }
}

