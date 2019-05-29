namespace PAV01
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView lvwCanais;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		private void InitializeComponent(){
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvwCanais = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edtFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bntAdd = new System.Windows.Forms.ToolStripButton();
            this.bntDel = new System.Windows.Forms.ToolStripButton();
            this.bntEdit = new System.Windows.Forms.ToolStripButton();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.bntFiltro = new System.Windows.Forms.ToolStripButton();
            this.bntVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwCanais
            // 
            this.lvwCanais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwCanais.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwCanais.FullRowSelect = true;
            this.lvwCanais.GridLines = true;
            this.lvwCanais.HideSelection = false;
            this.lvwCanais.Location = new System.Drawing.Point(0, 28);
            this.lvwCanais.Name = "lvwCanais";
            this.lvwCanais.Size = new System.Drawing.Size(684, 260);
            this.lvwCanais.TabIndex = 0;
            this.lvwCanais.UseCompatibleStateImageBehavior = false;
            this.lvwCanais.View = System.Windows.Forms.View.Details;
            this.lvwCanais.SelectedIndexChanged += new System.EventHandler(this.lvwCanais_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "#";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grupo";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "URL";
            this.columnHeader3.Width = 800;
            // 
            // edtFiltro
            // 
            this.edtFiltro.Name = "edtFiltro";
            this.edtFiltro.Size = new System.Drawing.Size(100, 25);
            this.edtFiltro.Click += new System.EventHandler(this.Acao);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bntAdd,
            this.bntDel,
            this.bntEdit,
            this.btnAbrir,
            this.edtFiltro,
            this.bntFiltro,
            this.bntVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bntAdd
            // 
            this.bntAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntAdd.Image = ((System.Drawing.Image)(resources.GetObject("bntAdd.Image")));
            this.bntAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(23, 22);
            this.bntAdd.Text = "toolStripButton1";
            this.bntAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntAdd.ToolTipText = "Inserir um novo canal";
            this.bntAdd.Click += new System.EventHandler(this.Acao);
            // 
            // bntDel
            // 
            this.bntDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntDel.Image = ((System.Drawing.Image)(resources.GetObject("bntDel.Image")));
            this.bntDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(23, 22);
            this.bntDel.Text = "toolStripButton1";
            this.bntDel.ToolTipText = "Remover canal";
            this.bntDel.Click += new System.EventHandler(this.Acao);
            // 
            // bntEdit
            // 
            this.bntEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntEdit.Image = ((System.Drawing.Image)(resources.GetObject("bntEdit.Image")));
            this.bntEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(23, 22);
            this.bntEdit.Text = "toolStripButton2";
            this.bntEdit.ToolTipText = "Editar canal";
            this.bntEdit.Click += new System.EventHandler(this.Acao);
            // 
            // btnAbrir
            // 
            this.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbrir.Image = global::PAV01.Properties.Resources.iconOpen;
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(23, 22);
            this.btnAbrir.Text = "toolStripButton7";
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAbrir.ToolTipText = "Abrir URL";
            this.btnAbrir.Click += new System.EventHandler(this.Acao);
            // 
            // bntFiltro
            // 
            this.bntFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntFiltro.Image = ((System.Drawing.Image)(resources.GetObject("bntFiltro.Image")));
            this.bntFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntFiltro.Name = "bntFiltro";
            this.bntFiltro.Size = new System.Drawing.Size(23, 22);
            this.bntFiltro.Text = "toolStripButton3";
            this.bntFiltro.ToolTipText = "Procurar canal";
            this.bntFiltro.Click += new System.EventHandler(this.Acao);
            // 
            // bntVoltar
            // 
            this.bntVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntVoltar.Image = ((System.Drawing.Image)(resources.GetObject("bntVoltar.Image")));
            this.bntVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntVoltar.Name = "bntVoltar";
            this.bntVoltar.Size = new System.Drawing.Size(23, 22);
            this.bntVoltar.Text = "toolStripButton4";
            this.bntVoltar.ToolTipText = "Sair";
            this.bntVoltar.Visible = false;
            this.bntVoltar.Click += new System.EventHandler(this.Acao);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 288);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvwCanais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Canais - Adm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStripButton bntAdd;
        private System.Windows.Forms.ToolStripButton bntDel;
        private System.Windows.Forms.ToolStripButton bntEdit;
        private System.Windows.Forms.ToolStripTextBox edtFiltro;
        private System.Windows.Forms.ToolStripButton bntFiltro;
        private System.Windows.Forms.ToolStripButton bntVoltar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripButton btnAbrir;
    }
}
