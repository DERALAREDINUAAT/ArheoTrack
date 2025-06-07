namespace ArheoTrack
{
    partial class FormAutentificare
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAutentificare1 = new System.Windows.Forms.Button();
            this.btnAmUitatParola = new System.Windows.Forms.Button();
            this.txtEmailAfter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPassword.Location = new System.Drawing.Point(66, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password*";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsername.Location = new System.Drawing.Point(66, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username*";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(66, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(208, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(405, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(208, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(403, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(208, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // btnAutentificare1
            // 
            this.btnAutentificare1.BackColor = System.Drawing.SystemColors.Info;
            this.btnAutentificare1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAutentificare1.Location = new System.Drawing.Point(616, 377);
            this.btnAutentificare1.Name = "btnAutentificare1";
            this.btnAutentificare1.Size = new System.Drawing.Size(157, 50);
            this.btnAutentificare1.TabIndex = 7;
            this.btnAutentificare1.Text = "Autentificare";
            this.btnAutentificare1.UseVisualStyleBackColor = false;
            this.btnAutentificare1.Click += new System.EventHandler(this.btnAutentificare1_Click);
            // 
            // btnAmUitatParola
            // 
            this.btnAmUitatParola.BackColor = System.Drawing.SystemColors.Info;
            this.btnAmUitatParola.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAmUitatParola.Location = new System.Drawing.Point(388, 377);
            this.btnAmUitatParola.Name = "btnAmUitatParola";
            this.btnAmUitatParola.Size = new System.Drawing.Size(221, 49);
            this.btnAmUitatParola.TabIndex = 8;
            this.btnAmUitatParola.Text = "Am uitat parola";
            this.btnAmUitatParola.UseVisualStyleBackColor = false;
            this.btnAmUitatParola.Click += new System.EventHandler(this.btnAmUitatParola_Click);
            // 
            // txtEmailAfter
            // 
            this.txtEmailAfter.Location = new System.Drawing.Point(69, 391);
            this.txtEmailAfter.Name = "txtEmailAfter";
            this.txtEmailAfter.Size = new System.Drawing.Size(199, 22);
            this.txtEmailAfter.TabIndex = 9;
            this.txtEmailAfter.TextChanged += new System.EventHandler(this.txtEmailAfter_TextChanged);
            // 
            // FormAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmailAfter);
            this.Controls.Add(this.btnAmUitatParola);
            this.Controls.Add(this.btnAutentificare1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Name = "FormAutentificare";
            this.Text = "FormAutentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAutentificare1;
        private System.Windows.Forms.Button btnAmUitatParola;
        private System.Windows.Forms.TextBox txtEmailAfter;
    }
}