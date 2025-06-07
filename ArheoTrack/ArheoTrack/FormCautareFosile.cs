using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArheoTrack
{
    public partial class FormCautareFosile : Form
    {
        private readonly string connectionString = "Data Source=DARIA;Initial Catalog=ArheoTrack;Integrated Security=True;";

        public FormCautareFosile()
        {
            InitializeComponent();
            LoadFosile();
        }

        private void LoadFosile(string filtru = "")
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT Id, Nume, Locatie, DataDescoperire FROM Fosile";

            if (!string.IsNullOrEmpty(filtru))
            {
                query += " WHERE Nume LIKE @filtru OR Locatie LIKE @filtru";
            }

            using SqlCommand cmd = new SqlCommand(query, conn);

            if (!string.IsNullOrEmpty(filtru))
            {
                cmd.Parameters.AddWithValue("@filtru", "%" + filtru + "%");
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFosile.DataSource = dt;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string textCautare = txtCautare.Text.Trim();
            LoadFosile(textCautare);
        }
    }
}
