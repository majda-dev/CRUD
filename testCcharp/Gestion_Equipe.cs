using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCcharp
{
    public partial class Gestion_Equipe : Form
    {
        public Gestion_Equipe()
        {
            InitializeComponent();
        }

        private void Gestion_Equipe_Load(object sender, EventArgs e)
        {
            LoadDataGridViews.LoadFromTableDB(guna2DataGridView1, "SELECT * from equipe");
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            string id = guna2DataGridView1.Rows[indice].Cells[0].Value.ToString();
            string nom = guna2DataGridView1.Rows[indice].Cells[1].Value.ToString();
            string description = guna2DataGridView1.Rows[indice].Cells[2].Value.ToString();
            string capacite = guna2DataGridView1.Rows[indice].Cells[3].Value.ToString();

            brhmTextBox1.Texts = nom;
            brhmTextBox2.Texts = description;
            brhmTextBox3.Texts = capacite;

            //if (e.RowIndex >= 0 && e.RowIndex < guna2DataGridView1.Rows.Count)
            //{
            //    int indice = e.RowIndex;
            //    String id = guna2DataGridView1.Rows[indice].Cells[0].Value.ToString();
            //    String nom = guna2DataGridView1.Rows[indice].Cells[1].Value.ToString();
            //    String description = guna2DataGridView1.Rows[indice].Cells[2].Value.ToString();
            //    String capacite = guna2DataGridView1.Rows[indice].Cells[3].Value.ToString();

            //    brhmTextBox1.Texts = nom;
            //    brhmTextBox2.Texts = description;
            //    brhmTextBox3.Texts = capacite;
            //}

        }

        private void brhmButton1_Click(object sender, EventArgs e)
        {
            
            String query = "insert into equipe (`nom`,`description`,`capacite`) " + "values('" + brhmTextBox1.Texts + "','" + brhmTextBox2.Texts + "','" + brhmTextBox3.Texts + "')";
            int r = database.insert(query);

            if (r == 1)
            {
                String connectionString = database.connectionString;
                OleDbConnection db = new OleDbConnection(connectionString);
                db.Open();

                String query1 = "select MAX(id) from equipe";
                OleDbCommand cmd1 = new OleDbCommand(query1, db);
                int maxId = (int)cmd1.ExecuteScalar();

                guna2DataGridView1.Rows.Add(maxId, brhmTextBox1.Texts, brhmTextBox2.Texts, brhmTextBox3.Texts);
                MessageBox.Show("Equipe est bien ajouter");
            }
            else
            {
                MessageBox.Show("erreur d'ajout d'Equipe ");
            }
        }

        private void brhmButton3_Click(object sender, EventArgs e)
        {
            int indice = guna2DataGridView1.CurrentRow.Index;
            String query = "DELETE from equipe WHERE id =" + guna2DataGridView1.Rows[indice].Cells[0].Value;
            int r = database.insert(query);
            DataGridViewRow selectedrow = guna2DataGridView1.CurrentRow;
            guna2DataGridView1.Rows.Remove(selectedrow);
            if (r == 1)
            {
                MessageBox.Show("Equipe bien supprimer");
                vider();
            }
            else
            {
                MessageBox.Show("erreur!!!");
            }
            
        }
        private void vider()
        {
            brhmTextBox1.Texts = "";
            brhmTextBox2.Texts = "";
            brhmTextBox3.Texts = "";

        }

        private void brhmButton4_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void brhmButton2_Click(object sender, EventArgs e)
        {
            int indice = guna2DataGridView1.CurrentRow.Index;
            string query = "UPDATE equipe SET nom='" + brhmTextBox1.Texts + "', description='" + brhmTextBox2.Texts + "', capacite='" + brhmTextBox3.Texts + "' WHERE id=" + guna2DataGridView1.Rows[indice].Cells[0].Value + "";
            int r = database.insert(query);

            if (r == 1)
            {
                guna2DataGridView1.Rows[indice].Cells[1].Value = brhmTextBox1.Texts;
                guna2DataGridView1.Rows[indice].Cells[2].Value = brhmTextBox2.Texts;
                guna2DataGridView1.Rows[indice].Cells[3].Value = brhmTextBox3.Texts;
                MessageBox.Show("L'étudiant a été modifié avec succès.");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'étudiant.");
            }
        }
    }
}
