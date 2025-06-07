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
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnAutentificare1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string parola = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection("Data Source=DARIA;Initial Catalog=ArheoTrack;Integrated Security=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Rol FROM Utilizatori WHERE Email=@mail AND Parola=@parola", conn);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@parola", parola);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string rol = reader.GetString(1);
                    this.Hide();
                    FormMain fm = new FormMain(rol, id);
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email sau parolă incorectă.");
                }
            }
        }

        private void txtEmailAfter_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnAmUitatParola_Click(object sender, EventArgs e)
        {
            // Dacă textBox-ul nu este vizibil, afișează-l și setează focusul
            if (!txtEmailAfter.Visible)
            {
                MessageBox.Show("Te rog să introduci adresa de e-mail.");

                // Afișăm caseta și ne asigurăm că e curată
                txtEmailAfter.Visible = true;
                txtEmailAfter.Clear();

                // IMPORTANT: Dezactivează Temporar Focusul de pe alt control
                ActiveControl = txtEmailAfter; // Mută focusul explicit

                btnAmUitatParola.Text = "Trimite";
                return;
            }

            // Dacă este deja vizibil, tratăm ca acțiune de "Trimite"
            string email = txtEmailAfter.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Te rog introdu o adresă de e-mail.");
                txtEmailAfter.Focus();
                return;
            }

            MessageBox.Show($"O parolă nouă a fost trimisă la {email}");

            // Resetăm totul
            txtEmailAfter.Visible = false;
            txtEmailAfter.Clear();
            btnAmUitatParola.Text = "Am uitat parola";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}