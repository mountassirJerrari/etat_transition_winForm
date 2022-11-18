using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etat_transition_winForm

{
    internal class SqlServerConnection
    {
        static string chaine = @"Data Source=DESKTOP-CQ7KNB1\SQLEXPRESS;Initial Catalog=student;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        static public void insertEtudiant (string nome , string prenom)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into etudiant(nome, prenom) values('" + nome + "','" + prenom + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        internal static void loadEtudiant(ComboBox cbx)
        {
            cnx.Open();
            cmd.CommandText = "select * from etudiant";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = "nome";
            cbx.ValueMember = "prenom";
            cnx.Close();
        }
        static void focus(string id , TextBox txtNome , TextBox txtPrenom)
        {
            cnx.Open();
            cmd.CommandText = "select * from etudiant where id = "+id ;
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
           
            cnx.Close();
        }
    }
}
