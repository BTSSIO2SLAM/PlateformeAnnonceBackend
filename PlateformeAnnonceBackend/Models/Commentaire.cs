using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeAnnonceBackend.Models
{
    public class Commentaire
    {
        public int ID { get; set; }
        public string Contenu { get; set; }
        public virtual Annonce Annonce { get; set; }
        public virtual Notation Notation { get; set; }
        public virtual Utilisateur utilisateur { get; set; }
    }
}