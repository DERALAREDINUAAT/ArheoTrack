namespace ArheoTrack
{
    partial class FormMain
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
            this.dataGridFosile = new System.Windows.Forms.DataGridView();
            this.btnAdaugaFosila = new System.Windows.Forms.Button();
            this.btnVizualizeazaDetalii = new System.Windows.Forms.Button();
            this.btnStergeFosila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFosile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFosile
            // 
            this.dataGridFosile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFosile.Location = new System.Drawing.Point(209, 89);
            this.dataGridFosile.Name = "dataGridFosile";
            this.dataGridFosile.RowHeadersWidth = 51;
            this.dataGridFosile.RowTemplate.Height = 24;
            this.dataGridFosile.Size = new System.Drawing.Size(379, 192);
            this.dataGridFosile.TabIndex = 0;
            this.dataGridFosile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFosile_CellContentClick);
            // 
            // btnAdaugaFosila
            // 
            this.btnAdaugaFosila.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdaugaFosila.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdaugaFosila.Location = new System.Drawing.Point(38, 369);
            this.btnAdaugaFosila.Name = "btnAdaugaFosila";
            this.btnAdaugaFosila.Size = new System.Drawing.Size(209, 56);
            this.btnAdaugaFosila.TabIndex = 1;
            this.btnAdaugaFosila.Text = "Adaugă Fosilă";
            this.btnAdaugaFosila.UseVisualStyleBackColor = false;
            this.btnAdaugaFosila.Click += new System.EventHandler(this.btnAdaugaFosila_Click);
            // 
            // btnVizualizeazaDetalii
            // 
            this.btnVizualizeazaDetalii.BackColor = System.Drawing.SystemColors.Info;
            this.btnVizualizeazaDetalii.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVizualizeazaDetalii.Location = new System.Drawing.Point(287, 369);
            this.btnVizualizeazaDetalii.Name = "btnVizualizeazaDetalii";
            this.btnVizualizeazaDetalii.Size = new System.Drawing.Size(224, 55);
            this.btnVizualizeazaDetalii.TabIndex = 2;
            this.btnVizualizeazaDetalii.Text = "Vezi Detalii";
            this.btnVizualizeazaDetalii.UseVisualStyleBackColor = false;
            this.btnVizualizeazaDetalii.Click += new System.EventHandler(this.btnVizualizeazaDetalii_Click);
            // 
            // btnStergeFosila
            // 
            this.btnStergeFosila.BackColor = System.Drawing.SystemColors.Info;
            this.btnStergeFosila.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnStergeFosila.Location = new System.Drawing.Point(546, 369);
            this.btnStergeFosila.Name = "btnStergeFosila";
            this.btnStergeFosila.Size = new System.Drawing.Size(214, 56);
            this.btnStergeFosila.TabIndex = 3;
            this.btnStergeFosila.Text = "Șterge Fosila";
            this.btnStergeFosila.UseVisualStyleBackColor = false;
            this.btnStergeFosila.Click += new System.EventHandler(this.btnStergeFosila_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergeFosila);
            this.Controls.Add(this.btnVizualizeazaDetalii);
            this.Controls.Add(this.btnAdaugaFosila);
            this.Controls.Add(this.dataGridFosile);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFosile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFosile;
        private System.Windows.Forms.Button btnAdaugaFosila;
        private System.Windows.Forms.Button btnVizualizeazaDetalii;
        private System.Windows.Forms.Button btnStergeFosila;
    }
}