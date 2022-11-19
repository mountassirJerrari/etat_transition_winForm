namespace etat_transition_winForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxListeEtudiant = new System.Windows.Forms.ComboBox();
            this.btnAjoute = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifie = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxListeEtudiant
            // 
            this.cbxListeEtudiant.FormattingEnabled = true;
            this.cbxListeEtudiant.Location = new System.Drawing.Point(291, 128);
            this.cbxListeEtudiant.MaxDropDownItems = 5;
            this.cbxListeEtudiant.Name = "cbxListeEtudiant";
            this.cbxListeEtudiant.Size = new System.Drawing.Size(205, 21);
            this.cbxListeEtudiant.TabIndex = 0;
            this.cbxListeEtudiant.SelectedIndexChanged += new System.EventHandler(this.cbxListeEtudiant_SelectedIndexChanged);
            // 
            // btnAjoute
            // 
            this.btnAjoute.Location = new System.Drawing.Point(38, 301);
            this.btnAjoute.Name = "btnAjoute";
            this.btnAjoute.Size = new System.Drawing.Size(75, 23);
            this.btnAjoute.TabIndex = 1;
            this.btnAjoute.Text = "ajouter";
            this.btnAjoute.UseVisualStyleBackColor = true;
            this.btnAjoute.Click += new System.EventHandler(this.btnAjoute_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(233, 301);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(75, 23);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModifie
            // 
            this.btnModifie.Location = new System.Drawing.Point(132, 301);
            this.btnModifie.Name = "btnModifie";
            this.btnModifie.Size = new System.Drawing.Size(75, 23);
            this.btnModifie.TabIndex = 4;
            this.btnModifie.Text = "modifier";
            this.btnModifie.UseVisualStyleBackColor = true;
            this.btnModifie.Click += new System.EventHandler(this.btnModifie_Click);
            // 
            // btnAnnule
            // 
            this.btnAnnule.Location = new System.Drawing.Point(444, 301);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(75, 23);
            this.btnAnnule.TabIndex = 5;
            this.btnAnnule.Text = "annuler";
            this.btnAnnule.UseVisualStyleBackColor = true;
            this.btnAnnule.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(89, 181);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(159, 20);
            this.txtPrenom.TabIndex = 7;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.ForeColor = System.Drawing.Color.Red;
            this.lblNom.Location = new System.Drawing.Point(86, 103);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 13);
            this.lblNom.TabIndex = 8;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.ForeColor = System.Drawing.Color.Red;
            this.lblPrenom.Location = new System.Drawing.Point(86, 165);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(0, 13);
            this.lblPrenom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "nom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "prenom :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnModifie);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAjoute);
            this.Controls.Add(this.cbxListeEtudiant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxListeEtudiant;
        private System.Windows.Forms.Button btnAjoute;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifie;
        private System.Windows.Forms.Button btnAnnule;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

