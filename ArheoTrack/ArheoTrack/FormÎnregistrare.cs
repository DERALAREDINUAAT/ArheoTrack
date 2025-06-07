using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArheoTrack
{
    public partial class FormÎnregistrare : Form
    {
        public FormÎnregistrare()
        {
            InitializeComponent();
        }

        private void lblBD_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLName_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmailI_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailI_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormÎnregistrare_Load(object sender, EventArgs e)
        {

        }

        private void txtBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhoneNum_Click(object sender, EventArgs e)
        {

        }

        private void lblStudies_Click(object sender, EventArgs e)
        {

        }

        private void txtStudies_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInstitEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtInstitEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPsw_Click(object sender, EventArgs e)
        {

        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCPsw_Click(object sender, EventArgs e)
        {

        }

        private void txtCPsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInapoiI_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnInregistrareI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text) ||
                string.IsNullOrWhiteSpace(txtEmailI.Text) ||
                string.IsNullOrWhiteSpace(txtPsw.Text) ||
                string.IsNullOrWhiteSpace(txtCPsw.Text))
            {
                MessageBox.Show("Te rog completează toate câmpurile obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPsw.Text != txtCPsw.Text)
            {
                MessageBox.Show("Parolele nu coincid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DARIA;Initial Catalog=ArheoTrack;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Utilizatori (Nume, Prenume, Email, Parola, NumarTelefon, Adresa, DataNastere, Studii, EmailInstitutional, Rol)
                VALUES (@Nume, @Prenume, @Email, @Parola, @NumarTelefon, @Adresa, @DataNastere, @Studii, @EmailInstitutional, @Rol)", conn);

                    cmd.Parameters.AddWithValue("@Nume", txtLName.Text);
                    cmd.Parameters.AddWithValue("@Prenume", txtFName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmailI.Text);
                    cmd.Parameters.AddWithValue("@Parola", txtPsw.Text);  // Ar fi ideal să o criptezi
                    cmd.Parameters.AddWithValue("@NumarTelefon", txtPhoneNum.Text);
                    cmd.Parameters.AddWithValue("@Adresa", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@DataNastere", txtBD.Text);
                    cmd.Parameters.AddWithValue("@Studii", txtStudies.Text);
                    cmd.Parameters.AddWithValue("@EmailInstitutional", txtInstitEmail.Text);
                    cmd.Parameters.AddWithValue("@Rol", txtRole.Text);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Înregistrare realizată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Golește câmpurile
                        txtFName.Clear();
                        txtLName.Clear();
                        txtEmailI.Clear();
                        txtPsw.Clear();
                        txtCPsw.Clear();
                        txtPhoneNum.Clear();
                        txtAddress.Clear();
                        txtBD.Clear();
                        txtStudies.Clear();
                        txtInstitEmail.Clear();
                        txtRole.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Eroare la înregistrare. Încearcă din nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectare sau salvare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
