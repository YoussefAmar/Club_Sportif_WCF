using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Club_Sportif_WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Membre> GetMembre(int IDe)
        {
            string chConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/BD_Club_Sportif.mdf") + ";Integrated Security=True;Connect Timeout=30";


            List<Membre> ListeMembre = new List<Membre>();

            SqlConnection conn = new SqlConnection(chConn);

            conn.Open();

            SqlCommand com = new SqlCommand("SELECT * FROM Membre WHERE IdEquipe_Membre =" + IDe.ToString(), conn);

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Membre p = new Membre();

                    p.ID = Int32.Parse(dr["IdMembre"].ToString());
                    p.Nom = dr["Nom"].ToString();
                    p.Prenom = dr["Prenom"].ToString();
                    p.Nai = dr["Naissance"].ToString();
                    p.Mail = dr["Mail"].ToString();
                    p.IDEquipe = IDe;
                    p.Poid = Int32.Parse(dr["Poids"].ToString());
                    p.Taille = Int32.Parse(dr["Taille"].ToString());

                    ListeMembre.Add(p);

            }

            dr.Close();

            conn.Close();
            
            return ListeMembre;

        }

    }
}
