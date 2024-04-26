namespace SzegedGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_kereses = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jarat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megallonev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegallomasok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarattipusa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_jaratok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés";
            // 
            // tb_kereses
            // 
            this.tb_kereses.Location = new System.Drawing.Point(177, 19);
            this.tb_kereses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_kereses.Name = "tb_kereses";
            this.tb_kereses.Size = new System.Drawing.Size(625, 20);
            this.tb_kereses.TabIndex = 1;
            this.tb_kereses.TextChanged += new System.EventHandler(this.tb_kereses_TextChanged);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jarat,
            this.megallonev,
            this.vegallomasok,
            this.jarattipusa});
            this.DGV.Location = new System.Drawing.Point(27, 63);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(855, 320);
            this.DGV.TabIndex = 2;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.l_jaratok);
            this.panel1.Location = new System.Drawing.Point(27, 389);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 49);
            this.panel1.TabIndex = 3;
            // 
            // jarat
            // 
            this.jarat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.jarat.HeaderText = "Járat";
            this.jarat.Name = "jarat";
            this.jarat.ReadOnly = true;
            this.jarat.Width = 60;
            // 
            // megallonev
            // 
            this.megallonev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.megallonev.HeaderText = "Megálló neve";
            this.megallonev.Name = "megallonev";
            this.megallonev.ReadOnly = true;
            this.megallonev.Width = 99;
            // 
            // vegallomasok
            // 
            this.vegallomasok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vegallomasok.HeaderText = "Végállomások";
            this.vegallomasok.Name = "vegallomasok";
            this.vegallomasok.ReadOnly = true;
            // 
            // jarattipusa
            // 
            this.jarattipusa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jarattipusa.HeaderText = "Járat Típusa";
            this.jarattipusa.Name = "jarattipusa";
            this.jarattipusa.ReadOnly = true;
            // 
            // l_jaratok
            // 
            this.l_jaratok.AutoSize = true;
            this.l_jaratok.ForeColor = System.Drawing.Color.Yellow;
            this.l_jaratok.Location = new System.Drawing.Point(226, 19);
            this.l_jaratok.Name = "l_jaratok";
            this.l_jaratok.Size = new System.Drawing.Size(41, 13);
            this.l_jaratok.TabIndex = 0;
            this.l_jaratok.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.tb_kereses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "SzegedGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_kereses;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarat;
        private System.Windows.Forms.DataGridViewTextBoxColumn megallonev;
        private System.Windows.Forms.DataGridViewTextBoxColumn vegallomasok;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarattipusa;
        private System.Windows.Forms.Label l_jaratok;
    }
}

