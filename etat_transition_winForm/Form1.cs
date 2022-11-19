﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SqlServerConnection.loadEtudiant(cbxListeEtudiant, txtNome ,txtPrenom);
           
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
            updateState();
            currentState = "update";

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            updateState();
            currentState = "delete";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(currentState == "insert")
            {
                if (txtNome.Text != String.Empty && txtPrenom.Text != String.Empty)
                {
                    SqlServerConnection.insertEtudiant(txtNome.Text, txtPrenom.Text);
                    SqlServerConnection.loadEtudiant(cbxListeEtudiant, txtNome, txtPrenom);
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
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            normalState();
        }
        private void normalState(string  current_etudiant_nome = "")
        {
           
            if (current_etudiant_nome != ""  )
            {
                cbxListeEtudiant.SelectedIndex = cbxListeEtudiant.FindStringExact(current_etudiant_nome);
            }else
            {
                txtPrenom.Text = String.Empty;
                txtNome.Text = String.Empty;
            }
            cbxListeEtudiant.Enabled = true;
            btnAjoute.Enabled = true;
            btnModifie.Enabled = true;
            btnSupp.Enabled = true;
            btnSave.Enabled = false;
            btnAnnule.Enabled = false;
            txtNome.Enabled = false;
            txtPrenom.Enabled = false;
            lblNom.Text = String.Empty;
            lblPrenom.Text= String.Empty;   
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
        private void modifyState()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
