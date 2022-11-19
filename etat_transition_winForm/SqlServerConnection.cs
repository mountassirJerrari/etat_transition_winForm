using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 //pour separer la logic de notre application

//   cette class gere les communcation avec la BD  
namespace etat_transition_winForm

{
    internal class SqlServerConnection
    {
        //attributs statics pour etabir la connecton
        static string chaine = @"Data Source=DESKTOP-CQ7KNB1\SQLEXPRESS;Initial Catalog=student;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        // function qui fait insertion
        static public void insertEtudiant (string nome , string prenom)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into etudiant(nome, prenom) values('" + nome + "','" + prenom + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
           
        }
        //la suppression
        internal static void deleteEtudiant(string id)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from etudiant  where id ="+id+";";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        //function etulisé pour charger les etudiant de la base de donné vers le combobox
        internal static void loadEtudiant(ComboBox cbx )
        {
            cnx.Open();
            cmd.CommandText = "select * from etudiant";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = "nome";
            cbx.ValueMember = "id";
            
           

            cnx.Close();
        }
        //function pour la madification
        internal static void updateEtudiant(string id, string nome, string prenom)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE etudiant SET nome = '"+nome+ "' , prenom = '"+prenom+"' WHERE id="+id+";";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
