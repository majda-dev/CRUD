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
    public partial class Gestion_Joueur : Form
    {
        public Gestion_Joueur()
        {
            InitializeComponent();
        }

        private void Gestion_Joueur_Load(object sender, EventArgs e)
        {
            LoadDataGridViews.LoadFromTableDB(guna2DataGridView1, "SELECT joueur.id, joueur.nom, joueur.prenom, joueur.position_joueur, equipe.nom FROM equipe INNER JOIN joueur ON  equipe.id = joueur.id_equipe");
            Equipe();
        }
        private void Equipe()
        {
            String query = "select * from equipe";
            OleDbDataReader rs = database.ExecuteQuery(query);
            while (rs.Read())
            {
                equips equipe = new equips();
                equipe.id = rs[0].ToString();
                equipe.nom = rs[1].ToString();
                brhmComboBox1.Items.Add(equipe);
            }
            database.close();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            string id = guna2DataGridView1.Rows[indice].Cells[0].Value.ToString();
            string nom = guna2DataGridView1.Rows[indice].Cells[1].Value.ToString();
            string prenom = guna2DataGridView1.Rows[indice].Cells[2].Value.ToString();
            string posistion = guna2DataGridView1.Rows[indice].Cells[3].Value.ToString();
            string equipe = guna2DataGridView1.Rows[indice].Cells[4].Value.ToString();

            brhmTextBox1.Texts = nom;
            brhmTextBox2.Texts = prenom;
            brhmTextBox3.Texts = posistion;
           brhmComboBox1.Texts = equipe;
        }

        private void brhmButton4_Click(object sender, EventArgs e)
        {
            vider();
        }
        private void vider()
        {
            brhmTextBox1.Texts = "";
            brhmTextBox2.Texts = "";
            brhmTextBox3.Texts = "";
            brhmComboBox1.Texts = "";

        }

        private void brhmButton3_Click(object sender, EventArgs e)
        {
            int indice = guna2DataGridView1.CurrentRow.Index;
            String query = "DELETE from joueur WHERE id =" + guna2DataGridView1.Rows[indice].Cells[0].Value;
            int r = database.insert(query);
            DataGridViewRow selectedrow = guna2DataGridView1.CurrentRow;
            guna2DataGridView1.Rows.Remove(selectedrow);
            if (r == 1)
            {
                MessageBox.Show("joueur bien supprimer");
                vider();
            }
            else
            {
                MessageBox.Show("erreur!!!");
            }
        }

        private void brhmButton1_Click(object sender, EventArgs e)
        {
            equips E = (equips)brhmComboBox1.SelectedItem;
            String query = "insert into joueur (`nom`,`prenom`,`position_joueur`,`id_equipe`) values('" + brhmTextBox1.Texts + "','" + brhmTextBox2.Texts + "','" + brhmTextBox3.Texts + "','" + E.id + "')";
            int r = database.insert(query);

            

            if (r == 1)
            {
                String connectionString = database.connectionString;
                OleDbConnection db = new OleDbConnection(connectionString);
                db.Open();

                String query1 = "select MAX(id) from joueur";
                OleDbCommand cmd1 = new OleDbCommand(query1, db);
                int maxId = (int)cmd1.ExecuteScalar();

                guna2DataGridView1.Rows.Add(maxId, brhmTextBox1.Texts, brhmTextBox2.Texts, brhmTextBox3.Texts,E.nom);
                MessageBox.Show("Joueur est bien ajouter");
            }
            else
            {
                MessageBox.Show("Joueur d'ajout d'étudiant ");
            }
        }

        private void brhmButton2_Click(object sender, EventArgs e)
        {
            equips E = (equips)brhmComboBox1.SelectedItem;
            int indice = guna2DataGridView1.CurrentRow.Index;
            string query = "UPDATE joueur SET nom='" + brhmTextBox1.Texts + "', prenom='" + brhmTextBox2.Texts + "', position_joueur='" + brhmTextBox3.Texts + ", id_equipe=" + E.id + " WHERE id=" + guna2DataGridView1.Rows[indice].Cells[0].Value + "";
            int r = database.insert(query);

            if (r == 1)
            {
                guna2DataGridView1.Rows[indice].Cells[1].Value = brhmTextBox1.Texts;
                guna2DataGridView1.Rows[indice].Cells[2].Value = brhmTextBox2.Texts;
                guna2DataGridView1.Rows[indice].Cells[3].Value = brhmTextBox3.Texts;
                guna2DataGridView1.Rows[indice].Cells[3].Value = brhmComboBox1.Texts;
                MessageBox.Show("L'étudiant a été modifié avec succès.");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'étudiant.");
            }
        }
    }
}
