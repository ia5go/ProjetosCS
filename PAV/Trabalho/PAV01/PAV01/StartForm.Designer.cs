namespace PAV01
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.lvwStart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LogNome = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.LogSenha = new System.Windows.Forms.ToolStripTextBox();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSignin = new System.Windows.Forms.ToolStripButton();
            this.btnSobre = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwStart
            // 
            this.lvwStart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwStart.FullRowSelect = true;
            this.lvwStart.GridLines = true;
            this.lvwStart.HideSelection = false;
            this.lvwStart.Location = new System.Drawing.Point(0, 29);
            this.lvwStart.Name = "lvwStart";
            this.lvwStart.Size = new System.Drawing.Size(724, 292);
            this.lvwStart.TabIndex = 0;
            this.lvwStart.UseCompatibleStateImageBehavior = false;
            this.lvwStart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grupo";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "URL";
            this.columnHeader4.Width = 800;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.LogNome,
            this.toolStripLabel2,
            this.LogSenha,
            this.btnLogin,
            this.btnSair,
            this.toolStripSeparator1,
            this.btnSobre,
            this.toolStripSeparator2,
            this.btnSignin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(724, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "Nome: ";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // LogNome
            // 
            this.LogNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogNome.Name = "LogNome";
            this.LogNome.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel2.Text = "Senha: ";
            // 
            // LogSenha
            // 
            this.LogSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogSenha.Name = "LogSenha";
            this.LogSenha.Size = new System.Drawing.Size(100, 25);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(41, 22);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.Acao);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.Acao);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSignin
            // 
            this.btnSignin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSignin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSignin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSignin.Image = ((System.Drawing.Image)(resources.GetObject("btnSignin.Image")));
            this.btnSignin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(77, 22);
            this.btnSignin.Text = "Cadastrar-se";
            this.btnSignin.Click += new System.EventHandler(this.Acao);
            // 
            // btnSobre
            // 
            this.btnSobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSobre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(41, 22);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.Acao);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 321);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvwStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StartForm";
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwStart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnLogin;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSignin;
        public System.Windows.Forms.ToolStripTextBox LogNome;
        public System.Windows.Forms.ToolStripTextBox LogSenha;
        private System.Windows.Forms.ToolStripButton btnSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}