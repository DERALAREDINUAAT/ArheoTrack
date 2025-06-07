using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArheoTrack
{
    public partial class FormDetaliiFosila : Form
    {
        private readonly string connectionString = "Data Source=DARIA;Initial Catalog=ArheoTrack;Integrated Security=True;";
        private readonly int fosilaId;

        public FormDetaliiFosila(int id)
        {
            InitializeComponent();
            fosilaId = id;
            LoadDetalii();
        }

        private void LoadDetalii()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"
        SELECT F.Nume, F.Locatie, F.Latitudine, F.Longitudine, F.Descriere,
               D.Masuratori, D.AnalizaChimica, D.RezultatDatare, F.ImagineURL
        FROM Fosile F
        LEFT JOIN DateStiintifice D ON F.Id = D.FosilaId
        WHERE F.Id = @id", conn);

            cmd.Parameters.AddWithValue("@id", fosilaId);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblNume.Text = reader.GetString(0);
                lblLocatie.Text = reader.GetString(1);
                lblLat.Text = reader[2].ToString();
                lblLon.Text = reader[3].ToString();
                txtDescriere.Text = reader[4].ToString();
                txtMasuratori.Text = reader[5].ToString();
                txtAnaliza.Text = reader[6].ToString();
                txtDatare.Text = reader[7].ToString();

                string imageUrl = reader[8]?.ToString();
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    try
                    {
                        pictureFosila.Load(imageUrl);
                    }
                    catch
                    {
                        MessageBox.Show("Imaginea nu a putut fi încărcată.", "Eroare imagine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtDatare_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDetaliiFosila_Load(object sender, EventArgs e)
        {

        }

        private void pictureFosila_Click(object sender, EventArgs e)
        {

        }
    }
}