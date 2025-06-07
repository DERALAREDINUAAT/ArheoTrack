namespace ArheoTrack
{
    partial class FormCautareFosile
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
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.dgvFosile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFosile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(38, 27);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(706, 22);
            this.txtCautare.TabIndex = 0;
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.SystemColors.Info;
            this.btnCauta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCauta.Location = new System.Drawing.Point(297, 86);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(175, 52);
            this.btnCauta.TabIndex = 1;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dgvFosile
            // 
            this.dgvFosile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFosile.Location = new System.Drawing.Point(38, 174);
            this.dgvFosile.Name = "dgvFosile";
            this.dgvFosile.RowHeadersWidth = 51;
            this.dgvFosile.RowTemplate.Height = 24;
            this.dgvFosile.Size = new System.Drawing.Size(705, 216);
            this.dgvFosile.TabIndex = 2;
            // 
            // FormCautareFosile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFosile);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCautare);
            this.Name = "FormCautareFosile";
            this.Text = "FormCautareFosile";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFosile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DataGridView dgvFosile;
    }
}