using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArheoTrack
{
    public partial class FormMain : Form
    {
        private readonly string connectionString = "Data Source=DARIA;Initial Catalog=ArheoTrack;Integrated Security=True;";
        private readonly string userRole;
        private readonly int userId;

        public FormMain(string role, int id)
        {
            InitializeComponent();
            userRole = role;
            userId = id;
            LoadFosile();
        }

        private void LoadFosile()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT Id, Nume, Locatie, DataDescoperire FROM Fosile"; // Simplu ca să meargă
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridFosile.DataSource = dt;

            // Setează coloana Id să fie ascunsă, ca să nu se vadă dar să poți lua Id-ul selectat
            if (dataGridFosile.Columns["Id"] != null)
                dataGridFosile.Columns["Id"].Visible = false;
        }


        private void btnAdaugaFosila_Click(object sender, EventArgs e)
        {
            if (userRole != "cercetator" && userRole != "administrator")
            {
                MessageBox.Show("Nu aveți permisiunea pentru această acțiune.");
                return;
            }

            FormAdaugaFosila formAdauga = new FormAdaugaFosila(userId);
            formAdauga.ShowDialog();

            // După ce închizi form-ul, reîncarcă lista ca să vezi fosila nouă
            LoadFosile();
        }

        private void btnVizualizeazaDetalii_Click(object sender, EventArgs e)
        {
            if (dataGridFosile.SelectedRows.Count == 0)
            {
                MessageBox.Show("Te rog selectează o fosilă din listă.");
                return;
            }

            int idFosila = Convert.ToInt32(dataGridFosile.SelectedRows[0].Cells["Id"].Value);
            FormDetaliiFosila formDetalii = new FormDetaliiFosila(idFosila);
            formDetalii.ShowDialog();
        }


        // 4. Ștergere logică (optional, recomandat) - schimbă query la DELETE cu UPDATE IsDeleted
        private void btnStergeFosila_Click(object sender, EventArgs e)
        {
            if (userRole != "administrator")
            {
                MessageBox.Show("Doar administratorul poate șterge înregistrări.");
                return;
            }

            if (dataGridFosile.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridFosile.SelectedRows[0].Cells["Id"].Value);

                DialogResult dr = MessageBox.Show("Ești sigur că vrei să ștergi fosila?", "Confirmare", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    // Ștergere logică
                    SqlCommand cmd = new SqlCommand("UPDATE Fosile SET IsDeleted = 1 WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    LoadFosile();
                }
            }
            else
            {
                MessageBox.Show("Te rog selectează o fosilă.");
            }
        }

        private void dataGridFosile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
