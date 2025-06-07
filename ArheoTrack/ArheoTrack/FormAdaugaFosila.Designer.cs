namespace ArheoTrack
{
    partial class FormAdaugaFosila
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
            this.btnAnuleaz = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblLatitudine = new System.Windows.Forms.Label();
            this.lblLongitudine = new System.Windows.Forms.Label();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtLatitudine = new System.Windows.Forms.TextBox();
            this.txtLongitudine = new System.Windows.Forms.TextBox();
            this.dateTimeDescoperire = new System.Windows.Forms.DateTimePicker();
            this.lblDataDescoperirii = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.txtImagineURL = new System.Windows.Forms.TextBox();
            this.lblURLImagine = new System.Windows.Forms.Label();
            this.cmbSpecie = new System.Windows.Forms.ComboBox();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnuleaz
            // 
            this.btnAnuleaz.BackColor = System.Drawing.SystemColors.Info;
            this.btnAnuleaz.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAnuleaz.Location = new System.Drawing.Point(95, 389);
            this.btnAnuleaz.Name = "btnAnuleaz";
            this.btnAnuleaz.Size = new System.Drawing.Size(198, 49);
            this.btnAnuleaz.TabIndex = 0;
            this.btnAnuleaz.Text = "Anulează";
            this.btnAnuleaz.UseVisualStyleBackColor = false;
            this.btnAnuleaz.Click += new System.EventHandler(this.btnAnuleaz_Click);

            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalveaza.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalveaza.Location = new System.Drawing.Point(470, 389);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(228, 49);
            this.btnSalveaza.TabIndex = 1;
            this.btnSalveaza.Text = "Salvează";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(155, 30);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(543, 22);
            this.txtNume.TabIndex = 2;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNume.Location = new System.Drawing.Point(29, 33);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(83, 16);
            this.lblNume.TabIndex = 3;
            this.lblNume.Text = "Nume Fosilă";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLocatie.Location = new System.Drawing.Point(29, 80);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(51, 16);
            this.lblLocatie.TabIndex = 4;
            this.lblLocatie.Text = "Locație";
            // 
            // lblLatitudine
            // 
            this.lblLatitudine.AutoSize = true;
            this.lblLatitudine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLatitudine.Location = new System.Drawing.Point(29, 126);
            this.lblLatitudine.Name = "lblLatitudine";
            this.lblLatitudine.Size = new System.Drawing.Size(64, 16);
            this.lblLatitudine.TabIndex = 5;
            this.lblLatitudine.Text = "Latitudine";
            // 
            // lblLongitudine
            // 
            this.lblLongitudine.AutoSize = true;
            this.lblLongitudine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLongitudine.Location = new System.Drawing.Point(29, 173);
            this.lblLongitudine.Name = "lblLongitudine";
            this.lblLongitudine.Size = new System.Drawing.Size(76, 16);
            this.lblLongitudine.TabIndex = 6;
            this.lblLongitudine.Text = "Longitudine";
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(155, 77);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(543, 22);
            this.txtLocatie.TabIndex = 7;
            //this.txtLocatie.TextChanged += new System.EventHandler(this.txtLocatie_TextChanged);
            // 
            // txtLatitudine
            // 
            this.txtLatitudine.Location = new System.Drawing.Point(155, 123);
            this.txtLatitudine.Name = "txtLatitudine";
            this.txtLatitudine.Size = new System.Drawing.Size(543, 22);
            this.txtLatitudine.TabIndex = 8;
            // 
            // txtLongitudine
            // 
            this.txtLongitudine.Location = new System.Drawing.Point(155, 170);
            this.txtLongitudine.Name = "txtLongitudine";
            this.txtLongitudine.Size = new System.Drawing.Size(543, 22);
            this.txtLongitudine.TabIndex = 9;
            // 
            // dateTimeDescoperire
            // 
            this.dateTimeDescoperire.Location = new System.Drawing.Point(155, 349);
            this.dateTimeDescoperire.Name = "dateTimeDescoperire";
            this.dateTimeDescoperire.Size = new System.Drawing.Size(543, 22);
            this.dateTimeDescoperire.TabIndex = 10;
            // 
            // lblDataDescoperirii
            // 
            this.lblDataDescoperirii.AutoSize = true;
            this.lblDataDescoperirii.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDataDescoperirii.Location = new System.Drawing.Point(29, 354);
            this.lblDataDescoperirii.Name = "lblDataDescoperirii";
            this.lblDataDescoperirii.Size = new System.Drawing.Size(112, 16);
            this.lblDataDescoperirii.TabIndex = 11;
            this.lblDataDescoperirii.Text = "Data Descoperirii";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(155, 217);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(543, 22);
            this.txtDescriere.TabIndex = 12;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDescriere.Location = new System.Drawing.Point(29, 220);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(66, 16);
            this.lblDescriere.TabIndex = 13;
            this.lblDescriere.Text = "Descriere";
            // 
            // txtImagineURL
            // 
            this.txtImagineURL.Location = new System.Drawing.Point(155, 260);
            this.txtImagineURL.Name = "txtImagineURL";
            this.txtImagineURL.Size = new System.Drawing.Size(543, 22);
            this.txtImagineURL.TabIndex = 14;
            // 
            // lblURLImagine
            // 
            this.lblURLImagine.AutoSize = true;
            this.lblURLImagine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblURLImagine.Location = new System.Drawing.Point(29, 263);
            this.lblURLImagine.Name = "lblURLImagine";
            this.lblURLImagine.Size = new System.Drawing.Size(85, 16);
            this.lblURLImagine.TabIndex = 15;
            this.lblURLImagine.Text = "URL Imagine";
            // 
            // cmbSpecie
            // 
            this.cmbSpecie.FormattingEnabled = true;
            this.cmbSpecie.Location = new System.Drawing.Point(155, 306);
            this.cmbSpecie.Name = "cmbSpecie";
            this.cmbSpecie.Size = new System.Drawing.Size(543, 24);
            this.cmbSpecie.TabIndex = 16;
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSpecie.Location = new System.Drawing.Point(29, 309);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(50, 16);
            this.lblSpecie.TabIndex = 17;
            this.lblSpecie.Text = "Specie";
            // 
            // FormAdaugaFosila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.cmbSpecie);
            this.Controls.Add(this.lblURLImagine);
            this.Controls.Add(this.txtImagineURL);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblDataDescoperirii);
            this.Controls.Add(this.dateTimeDescoperire);
            this.Controls.Add(this.txtLongitudine);
            this.Controls.Add(this.txtLatitudine);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.lblLongitudine);
            this.Controls.Add(this.lblLatitudine);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAnuleaz);
            this.Name = "FormAdaugaFosila";
            this.Text = "FormAdaugaFosila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnuleaz;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblLatitudine;
        private System.Windows.Forms.Label lblLongitudine;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtLatitudine;
        private System.Windows.Forms.TextBox txtLongitudine;
        private System.Windows.Forms.DateTimePicker dateTimeDescoperire;
        private System.Windows.Forms.Label lblDataDescoperirii;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.TextBox txtImagineURL;
        private System.Windows.Forms.Label lblURLImagine;
        private System.Windows.Forms.ComboBox cmbSpecie;
        private System.Windows.Forms.Label lblSpecie;
    }
}