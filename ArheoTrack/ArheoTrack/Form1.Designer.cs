namespace ArheoTrack
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
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.btnCautareFosile = new System.Windows.Forms.Button();
            this.txtArheoTrack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.SystemColors.Info;
            this.btnInregistrare.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInregistrare.Location = new System.Drawing.Point(610, 16);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(180, 38);
            this.btnInregistrare.TabIndex = 0;
            this.btnInregistrare.Text = "Înregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.BackColor = System.Drawing.SystemColors.Info;
            this.btnAutentificare.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAutentificare.Location = new System.Drawing.Point(423, 16);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(169, 37);
            this.btnAutentificare.TabIndex = 1;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = false;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnCautareFosile
            // 
            this.btnCautareFosile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCautareFosile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCautareFosile.Location = new System.Drawing.Point(21, 378);
            this.btnCautareFosile.Name = "btnCautareFosile";
            this.btnCautareFosile.Size = new System.Drawing.Size(290, 46);
            this.btnCautareFosile.TabIndex = 2;
            this.btnCautareFosile.Text = "Căutare Fosile";
            this.btnCautareFosile.UseVisualStyleBackColor = false;
            this.btnCautareFosile.Click += new System.EventHandler(this.btnCautareFosile_Click);
            // 
            // txtArheoTrack
            // 
            this.txtArheoTrack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtArheoTrack.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtArheoTrack.Location = new System.Drawing.Point(265, 194);
            this.txtArheoTrack.Name = "txtArheoTrack";
            this.txtArheoTrack.Size = new System.Drawing.Size(265, 22);
            this.txtArheoTrack.TabIndex = 3;
            this.txtArheoTrack.Text = "ArheoTrack";
            this.txtArheoTrack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArheoTrack.TextChanged += new System.EventHandler(this.txtArheoTrack_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArheoTrack);
            this.Controls.Add(this.btnCautareFosile);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.btnInregistrare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Button btnCautareFosile;
        private System.Windows.Forms.TextBox txtArheoTrack;
    }
}

