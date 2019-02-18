using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace PlateformeAnnonceBackend.Models
{
    public class Annonce
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Date { get; set; }
        public string Contenu { get; set; }
        public string Prix { get; set; }
        public string UrlPhoto { get; set; }
    }
}