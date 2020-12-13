using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_partie1.Models
{
    public class Personne
    {

        public int age { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }

        public Personne()
        {
            this.age = 0;
            this.nom = "";
            this.prenom = "";
        }
    }   
       
    
}