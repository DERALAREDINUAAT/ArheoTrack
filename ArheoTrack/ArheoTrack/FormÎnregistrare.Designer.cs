namespace ArheoTrack
{
    partial class FormÎnregistrare
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
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblEmailI = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblCPsw = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblStudies = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblInstitEmail = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.btnInregistrareI = new System.Windows.Forms.Button();
            this.btnInapoiI = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmailI = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtStudies = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtInstitEmail = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtCPsw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLName.Location = new System.Drawing.Point(30, 23);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(77, 16);
            this.lblLName.TabIndex = 0;
            this.lblLName.Text = "Last Name*";
            this.lblLName.Click += new System.EventHandler(this.lblLName_Click);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFName.Location = new System.Drawing.Point(30, 55);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(77, 16);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name*";
            this.lblFName.Click += new System.EventHandler(this.lblFName_Click);
            // 
            // lblEmailI
            // 
            this.lblEmailI.AutoSize = true;
            this.lblEmailI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmailI.Location = new System.Drawing.Point(30, 88);
            this.lblEmailI.Name = "lblEmailI";
            this.lblEmailI.Size = new System.Drawing.Size(50, 16);
            this.lblEmailI.TabIndex = 2;
            this.lblEmailI.Text = "E-mail*";
            this.lblEmailI.Click += new System.EventHandler(this.lblEmailI_Click);
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPsw.Location = new System.Drawing.Point(30, 327);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(72, 16);
            this.lblPsw.TabIndex = 3;
            this.lblPsw.Text = "Password*";
            this.lblPsw.Click += new System.EventHandler(this.lblPsw_Click);
            // 
            // lblCPsw
            // 
            this.lblCPsw.AutoSize = true;
            this.lblCPsw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCPsw.Location = new System.Drawing.Point(30, 363);
            this.lblCPsw.Name = "lblCPsw";
            this.lblCPsw.Size = new System.Drawing.Size(115, 16);
            this.lblCPsw.TabIndex = 4;
            this.lblCPsw.Text = "Confirm Password";
            this.lblCPsw.Click += new System.EventHandler(this.lblCPsw_Click);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBD.Location = new System.Drawing.Point(30, 122);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(70, 16);
            this.lblBD.TabIndex = 5;
            this.lblBD.Text = "Birth Date*";
            this.lblBD.Click += new System.EventHandler(this.lblBD_Click);
            // 
            // lblStudies
            // 
            this.lblStudies.AutoSize = true;
            this.lblStudies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStudies.Location = new System.Drawing.Point(30, 224);
            this.lblStudies.Name = "lblStudies";
            this.lblStudies.Size = new System.Drawing.Size(52, 16);
            this.lblStudies.TabIndex = 6;
            this.lblStudies.Text = "Studies";
            this.lblStudies.Click += new System.EventHandler(this.lblStudies_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAddress.Location = new System.Drawing.Point(30, 155);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRole.Location = new System.Drawing.Point(30, 257);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 16);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role*";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblInstitEmail
            // 
            this.lblInstitEmail.AutoSize = true;
            this.lblInstitEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInstitEmail.Location = new System.Drawing.Point(30, 292);
            this.lblInstitEmail.Name = "lblInstitEmail";
            this.lblInstitEmail.Size = new System.Drawing.Size(113, 16);
            this.lblInstitEmail.TabIndex = 9;
            this.lblInstitEmail.Text = "Institutional E-mail";
            this.lblInstitEmail.Click += new System.EventHandler(this.lblInstitEmail_Click);
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPhoneNum.Location = new System.Drawing.Point(30, 189);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(102, 16);
            this.lblPhoneNum.TabIndex = 10;
            this.lblPhoneNum.Text = "Phone Number*";
            this.lblPhoneNum.Click += new System.EventHandler(this.lblPhoneNum_Click);
            // 
            // btnInregistrareI
            // 
            this.btnInregistrareI.BackColor = System.Drawing.SystemColors.Info;
            this.btnInregistrareI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInregistrareI.Location = new System.Drawing.Point(647, 394);
            this.btnInregistrareI.Name = "btnInregistrareI";
            this.btnInregistrareI.Size = new System.Drawing.Size(127, 42);
            this.btnInregistrareI.TabIndex = 11;
            this.btnInregistrareI.Text = "Înregistrare";
            this.btnInregistrareI.UseVisualStyleBackColor = false;
            this.btnInregistrareI.Click += new System.EventHandler(this.btnInregistrareI_Click);
            // 
            // btnInapoiI
            // 
            this.btnInapoiI.BackColor = System.Drawing.SystemColors.Info;
            this.btnInapoiI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInapoiI.Location = new System.Drawing.Point(476, 394);
            this.btnInapoiI.Name = "btnInapoiI";
            this.btnInapoiI.Size = new System.Drawing.Size(153, 42);
            this.btnInapoiI.TabIndex = 12;
            this.btnInapoiI.Text = "Înapoi";
            this.btnInapoiI.UseVisualStyleBackColor = false;
            this.btnInapoiI.Click += new System.EventHandler(this.btnInapoiI_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(200, 20);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(574, 22);
            this.txtLName.TabIndex = 13;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(200, 52);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(574, 22);
            this.txtFName.TabIndex = 14;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtEmailI
            // 
            this.txtEmailI.Location = new System.Drawing.Point(200, 85);
            this.txtEmailI.Name = "txtEmailI";
            this.txtEmailI.Size = new System.Drawing.Size(574, 22);
            this.txtEmailI.TabIndex = 15;
            this.txtEmailI.TextChanged += new System.EventHandler(this.txtEmailI_TextChanged);
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(200, 119);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(574, 22);
            this.txtBD.TabIndex = 16;
            this.txtBD.TextChanged += new System.EventHandler(this.txtBD_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(200, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(574, 22);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(200, 188);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(574, 22);
            this.txtPhoneNum.TabIndex = 18;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            // 
            // txtStudies
            // 
            this.txtStudies.Location = new System.Drawing.Point(200, 221);
            this.txtStudies.Name = "txtStudies";
            this.txtStudies.Size = new System.Drawing.Size(574, 22);
            this.txtStudies.TabIndex = 19;
            this.txtStudies.TextChanged += new System.EventHandler(this.txtStudies_TextChanged);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(200, 254);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(574, 22);
            this.txtRole.TabIndex = 20;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // txtInstitEmail
            // 
            this.txtInstitEmail.Location = new System.Drawing.Point(200, 289);
            this.txtInstitEmail.Name = "txtInstitEmail";
            this.txtInstitEmail.Size = new System.Drawing.Size(574, 22);
            this.txtInstitEmail.TabIndex = 21;
            this.txtInstitEmail.TextChanged += new System.EventHandler(this.txtInstitEmail_TextChanged);
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(200, 324);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(574, 22);
            this.txtPsw.TabIndex = 22;
            this.txtPsw.UseSystemPasswordChar = true;
            this.txtPsw.TextChanged += new System.EventHandler(this.txtPsw_TextChanged);
            // 
            // txtCPsw
            // 
            this.txtCPsw.Location = new System.Drawing.Point(200, 360);
            this.txtCPsw.Name = "txtCPsw";
            this.txtCPsw.Size = new System.Drawing.Size(574, 22);
            this.txtCPsw.TabIndex = 23;
            this.txtCPsw.UseSystemPasswordChar = true;
            this.txtCPsw.TextChanged += new System.EventHandler(this.txtCPsw_TextChanged);
            // 
            // FormÎnregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCPsw);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtInstitEmail);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtStudies);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtEmailI);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnInapoiI);
            this.Controls.Add(this.btnInregistrareI);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblInstitEmail);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStudies);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblCPsw);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblEmailI);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblLName);
            this.Name = "FormÎnregistrare";
            this.Text = "FormÎnregistrare";
            this.Load += new System.EventHandler(this.FormÎnregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblEmailI;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblCPsw;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblStudies;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblInstitEmail;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Button btnInregistrareI;
        private System.Windows.Forms.Button btnInapoiI;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmailI;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtStudies;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtInstitEmail;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtCPsw;
    }
}