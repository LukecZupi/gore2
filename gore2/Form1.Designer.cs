namespace gore2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorovje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transverzala = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.wiki = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNovoGoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniVDatotekoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.visina,
            this.gorovje,
            this.transverzala,
            this.slika,
            this.wiki});
            this.dataGridView1.Location = new System.Drawing.Point(0, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // ime
            // 
            this.ime.HeaderText = "ime";
            this.ime.MinimumWidth = 6;
            this.ime.Name = "ime";
            this.ime.Width = 125;
            // 
            // visina
            // 
            this.visina.HeaderText = "višina";
            this.visina.MinimumWidth = 6;
            this.visina.Name = "visina";
            this.visina.Width = 125;
            // 
            // gorovje
            // 
            this.gorovje.HeaderText = "gorovje";
            this.gorovje.MinimumWidth = 6;
            this.gorovje.Name = "gorovje";
            this.gorovje.Width = 125;
            // 
            // transverzala
            // 
            this.transverzala.HeaderText = "transverzala";
            this.transverzala.MinimumWidth = 6;
            this.transverzala.Name = "transverzala";
            this.transverzala.Width = 125;
            // 
            // slika
            // 
            this.slika.HeaderText = "slika";
            this.slika.MinimumWidth = 6;
            this.slika.Name = "slika";
            this.slika.Width = 125;
            // 
            // wiki
            // 
            this.wiki.HeaderText = "wiki";
            this.wiki.MinimumWidth = 6;
            this.wiki.Name = "wiki";
            this.wiki.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovoGoroToolStripMenuItem,
            this.izpisiToolStripMenuItem,
            this.shraniVDatotekoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajNovoGoroToolStripMenuItem
            // 
            this.dodajNovoGoroToolStripMenuItem.Name = "dodajNovoGoroToolStripMenuItem";
            this.dodajNovoGoroToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.dodajNovoGoroToolStripMenuItem.Text = "Dodaj novo goro";
            // 
            // izpisiToolStripMenuItem
            // 
            this.izpisiToolStripMenuItem.Name = "izpisiToolStripMenuItem";
            this.izpisiToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.izpisiToolStripMenuItem.Text = "izpisi";
            // 
            // shraniVDatotekoToolStripMenuItem
            // 
            this.shraniVDatotekoToolStripMenuItem.Name = "shraniVDatotekoToolStripMenuItem";
            this.shraniVDatotekoToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.shraniVDatotekoToolStripMenuItem.Text = "Shrani v datoteko";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nase Gore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoGoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniVDatotekoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn visina;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorovje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transverzala;
        private System.Windows.Forms.DataGridViewImageColumn slika;
        private System.Windows.Forms.DataGridViewLinkColumn wiki;
    }
}

