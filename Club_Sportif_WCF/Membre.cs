using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Club_Sportif_WCF
{
    public class Membre
    {
        private int _ID,_Poid,_Taille,_IDEquipe;
        private string _Nom, _Prenom, _Nai,_Mail;

        [DataMember]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [DataMember]
        public int IDEquipe
        {
            get { return _IDEquipe; }
            set { _IDEquipe = value; }
        }

        [DataMember]
        public string Nom 
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        [DataMember]
        public string Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }

    [DataMember]
        public string Nai
        {
            get { return _Nai; }
            set { _Nai = value; }
        }

        [DataMember]
        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        [DataMember]
        public int Poid
        {
            get { return _Poid; }
            set { _Poid = value; }
        }

        [DataMember]
        public int Taille
        {
            get { return _Taille; }
            set { _Taille = value; }
        }
    }
}