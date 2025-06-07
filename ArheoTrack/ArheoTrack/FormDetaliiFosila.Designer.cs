namespace ArheoTrack
{
    partial class FormDetaliiFosila
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.txtMasuratori = new System.Windows.Forms.TextBox();
            this.txtAnaliza = new System.Windows.Forms.TextBox();
            this.txtDatare = new System.Windows.Forms.TextBox();
            this.pictureFosila = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFosila)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNume.Location = new System.Drawing.Point(55, 26);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(0, 16);
            this.lblNume.TabIndex = 0;
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLocatie.Location = new System.Drawing.Point(55, 66);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(0, 16);
            this.lblLocatie.TabIndex = 1;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLat.Location = new System.Drawing.Point(49, 114);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(0, 16);
            this.lblLat.TabIndex = 2;
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLon.Location = new System.Drawing.Point(44, 163);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(0, 16);
            this.lblLon.TabIndex = 3;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(58, 331);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.ReadOnly = true;
            this.txtDescriere.Size = new System.Drawing.Size(186, 60);
            this.txtDescriere.TabIndex = 4;
            // 
            // txtMasuratori
            // 
            this.txtMasuratori.Location = new System.Drawing.Point(301, 331);
            this.txtMasuratori.Multiline = true;
            this.txtMasuratori.Name = "txtMasuratori";
            this.txtMasuratori.ReadOnly = true;
            this.txtMasuratori.Size = new System.Drawing.Size(184, 60);
            this.txtMasuratori.TabIndex = 5;
            // 
            // txtAnaliza
            // 
            this.txtAnaliza.Location = new System.Drawing.Point(545, 331);
            this.txtAnaliza.Multiline = true;
            this.txtAnaliza.Name = "txtAnaliza";
            this.txtAnaliza.ReadOnly = true;
            this.txtAnaliza.Size = new System.Drawing.Size(199, 60);
            this.txtAnaliza.TabIndex = 6;
            // 
            // txtDatare
            // 
            this.txtDatare.Location = new System.Drawing.Point(301, 264);
            this.txtDatare.Name = "txtDatare";
            this.txtDatare.ReadOnly = true;
            this.txtDatare.Size = new System.Drawing.Size(184, 22);
            this.txtDatare.TabIndex = 7;
            this.txtDatare.TextChanged += new System.EventHandler(this.txtDatare_TextChanged);
            // 
            // pictureFosila
            // 
            this.pictureFosila.Location = new System.Drawing.Point(523, 58);
            this.pictureFosila.Name = "pictureFosila";
            this.pictureFosila.Size = new System.Drawing.Size(244, 206);
            this.pictureFosila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFosila.TabIndex = 8;
            this.pictureFosila.TabStop = false;
            this.pictureFosila.Click += new System.EventHandler(this.pictureFosila_Click);
            // 
            // FormDetaliiFosila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureFosila);
            this.Controls.Add(this.txtDatare);
            this.Controls.Add(this.txtAnaliza);
            this.Controls.Add(this.txtMasuratori);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblNume);
            this.Name = "FormDetaliiFosila";
            this.Text = "FormDetaliiFosila";
            this.Load += new System.EventHandler(this.FormDetaliiFosila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFosila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.TextBox txtMasuratori;
        private System.Windows.Forms.TextBox txtAnaliza;
        private System.Windows.Forms.TextBox txtDatare;
        private System.Windows.Forms.PictureBox pictureFosila;
    }
}