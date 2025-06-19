using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace ASP_Examen2_R_H_25.Models
{
    public class Idee
    {
        /* 
            TODO : Ajouter les annotations pour les spécifications suivantes : 
            
            -   Afficher l'entête Numéro au lieu de Id.
            -	La date et le titre sont obligatoires.
            -	Spécifiez le format d’affichage pour la date (aaaa-mm-jj) et le coût (2 décimales).
            -	Le coût doit être entre 0 $ et 1 000 000 $.
            -	Valider le nom de la personne à l’aide d’une expression régulière
            -   L'entête Coût doit s'afficher avec son accent.
        */

        public int? Id { get; set; }

        public DateTime? Date { get; set; }

        public string? Titre { get; set; }

        public string? Description { get; set; }

        public string? Nom { get; set; }

        public int? Cout { get; set; }
       
    }
}