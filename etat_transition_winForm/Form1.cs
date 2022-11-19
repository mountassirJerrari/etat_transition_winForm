using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace etat_transition_winForm
{
    public partial class Form1 : Form
    {
        string currentState = "default";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlServerConnection.loadEtudiant(cbxListeEtudiant);
            txtPrenom.DataBindings.Add(new Binding("Text", cbxListeEtudiant.DataSource, "prenom"));
            txtNome.DataBindings.Add(new Binding("Text", cbxListeEtudiant.DataSource, "nome"));
            normalState();

        }

        private void cbxListeEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoute_Click(object sender, EventArgs e)
        {
            insertState();
            currentState = "insert";
           
        }

        private void btnModifie_Click(object sender, EventArgs e)
        {
            
            if (cbxListeEtudiant.Items.Count > 0)
            {
                updateState();
                currentState = "update";
            }
            else
            {
                MessageBox.Show("aucun element a supprimé");
            }

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (cbxListeEtudiant.Items.Count>0)
            {
                deleteState();
                currentState = "delete";
            }
            else
            {
                MessageBox.Show("aucun element a supprimé");
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(currentState == "insert")
            {
                if (txtNome.Text != String.Empty && txtPrenom.Text != String.Empty)
                {
                    SqlServerConnection.insertEtudiant(txtNome.Text, txtPrenom.Text);
                    SqlServerConnection.loadEtudiant(cbxListeEtudiant);
                    normalState(txtNome.Text);
                    lblNom.Text = String.Empty;
                    lblPrenom.Text = String.Empty;
                  



                }
                else
                {
                    lblNom.Text = " required";
                    lblPrenom.Text = "required";
                }
                   

            }

            if(currentState ==  "delete")
            {
                if (MessageBox.Show("voulez vraiment supprimer cette etudiant", "confirmation dailogue",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes && cbxListeEtudiant.Items.Count>0)
                {
                    SqlServerConnection.deleteEtudiant(cbxListeEtudiant.SelectedValue.ToString());
                    SqlServerConnection.loadEtudiant(cbxListeEtudiant);
                    normalState();
                    txtNome.DataBindings.Clear();
                    txtPrenom.DataBindings.Clear();
                    txtPrenom.DataBindings.Add(new Binding("Text", cbxListeEtudiant.DataSource, "prenom"));
                    txtNome.DataBindings.Add(new Binding("Text", cbxListeEtudiant.DataSource, "nome"));
                }
                



            }
            if (currentState=="update")
            {
                SqlServerConnection.updateEtudiant(cbxListeEtudiant.SelectedValue.ToString(), txtNome.Text, txtPrenom.Text);
                SqlServerConnection.loadEtudiant(cbxListeEtudiant);
                normalState();
                txtNome.DataBindings.Clear();
                txtPrenom.DataBindings.Clear();
                txtPrenom.DataBindings.Add(new Binding("Text", cbxListeEtudiant.DataSource, "prenom"));
                txtNome.DataBindings.Add(new Binding("Text", cbxListeEtudiant.DataSource, "nome"));
            }
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            normalState();
        }

        // les fonctions la bas decrient les different etat d l application winform 
        private void normalState(string  current_etudiant_nome = "")
        {
           
            if (current_etudiant_nome != ""  )
            {
                cbxListeEtudiant.SelectedIndex = cbxListeEtudiant.FindStringExact(current_etudiant_nome);
            }
            cbxListeEtudiant.Enabled = true;
            btnAjoute.Enabled = true;
            btnModifie.Enabled = true;
            btnSupp.Enabled = true;
            btnSave.Enabled = false;
            btnAnnule.Enabled = false;
            txtNome.Enabled = false;
            txtPrenom.Enabled = false;
               
        }
        private void insertState()
        {
            cbxListeEtudiant.SelectedIndex = -1;
            txtPrenom.Text = String.Empty;
            txtNome.Text = String.Empty;
            cbxListeEtudiant.SelectedItem = null;
            cbxListeEtudiant.Enabled = false;
            btnAjoute.Enabled = false;
            btnModifie.Enabled = false;
            btnSupp.Enabled= false;
            btnSave.Enabled = true;
            btnAnnule.Enabled = true;
            txtNome.Enabled = true;
            txtPrenom.Enabled=true;
            
        }
        private void updateState()
        {
            cbxListeEtudiant.Enabled = false;

            btnAjoute.Enabled = false;
            btnModifie.Enabled = false;
            btnSupp.Enabled = false;
            btnSave.Enabled = true;
            btnAnnule.Enabled = true;
            txtNome.Enabled = true;
            txtPrenom.Enabled = true;
        }
       
        private void deleteState()
        {
            cbxListeEtudiant.Enabled = false;
            btnAjoute.Enabled = false;
            btnModifie.Enabled = false;
            btnSupp.Enabled = false;
            btnSave.Enabled = true;
            btnAnnule.Enabled = true;
            txtNome.Enabled = false;
            txtPrenom.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
