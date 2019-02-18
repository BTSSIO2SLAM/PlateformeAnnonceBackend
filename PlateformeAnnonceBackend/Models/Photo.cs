using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlateformeAnnonceBackend.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string titre { get; set; }
        public string url { get; set; }
        public virtual Annonce Annonce { get; set; }
    }
}