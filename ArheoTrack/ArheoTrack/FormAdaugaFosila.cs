using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArheoTrack
{
    public partial class FormAdaugaFosila : Form
    {
        private readonly string connectionString = "Data Source=DARIA;Initial Catalog=ArheoTrack;Integrated Security=True;";
        private readonly int userId;

        public FormAdaugaFosila(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            this.Load += FormAdaugaFosila_Load;
        }

        private void FormAdaugaFosila_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id, Nume FROM Specii", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            cmbSpecie.DataSource = dt;
            cmbSpecie.DisplayMember = "Nume";
            cmbSpecie.ValueMember = "Id";
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                string.IsNullOrWhiteSpace(txtLocatie.Text) ||
                cmbSpecie.SelectedValue == null)
            {
                MessageBox.Show("Completează toate câmpurile obligatorii (Nume, Locație, Specie).");
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Fosile 
                    (Nume, Locatie, Latitudine, Longitudine, DataDescoperire, Descriere, ImagineURL, SpecieId, CreatDe) 
                    VALUES (@nume, @loc, @lat, @lon, @data, @desc, @img, @specie, @userId)", conn);

                cmd.Parameters.AddWithValue("@nume", txtNume.Text);
                cmd.Parameters.AddWithValue("@loc", txtLocatie.Text);
                cmd.Parameters.AddWithValue("@lat", txtLatitudine.Text);
                cmd.Parameters.AddWithValue("@lon", txtLongitudine.Text);
                cmd.Parameters.AddWithValue("@data", dateTimeDescoperire.Value);
                cmd.Parameters.AddWithValue("@desc", txtDescriere.Text);
                cmd.Parameters.AddWithValue("@img", txtImagineURL.Text);
                cmd.Parameters.AddWithValue("@specie", Convert.ToInt32(cmbSpecie.SelectedValue));
                cmd.Parameters.AddWithValue("@userId", userId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fosilă adăugată cu succes!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void btnAnuleaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
