using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GestionVente
{
    public class Basededonnee
    {
        //Paramètre de classe sur la connexion
        private MySqlConnection laConnexion;
        //construction de la chaîne de connexion pour se connecter sur la base de données
        string maChaineConnexion = "";

        public Basededonnee()
        {
            maChaineConnexion = "server=" + nomServeur + ";Database=" + nomBDD +
            ";port=" + numeroPort + ";uid=" + nomUtilisateur + ";pwd=" + MDP;

            laConnexion = new MySqlConnection();
            laConnexion.ConnectionString = maChaineConnexion;
            laConnexion.Open();
        }
    }
}
