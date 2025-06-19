using System.Diagnostics;
using ASP_Examen2_R_H_25.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Examen2_R_H_25.Controllers
{
    public class IdeeController : Controller
    {
        private IIdeesRep _listeIdees;

        // TODO : Initialiser la liste d'Idées à l'aide du service

        // TODO : Action Index -> Afficher la liste d'idée dans la vue fournie.

        /// <summary>
        /// Afficher le formulaire d'ajout
        /// </summary>
        /// <returns>La page de formulaire</returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View("Formulaire"); // TODO : Créer cette vue, assurez-vous d'appliquer la validation côté client.
        }

        /// <summary>
        /// Ajouter une idée
        /// </summary>
        /// <param name="idee">L'idée créée à partir des données du formulaire</param>
        /// <returns>La liste d'idée ou le formulaire avec messages d'erreurs</returns>
        [HttpPost]
        public ActionResult Create(Idee idee)
        {
            //TODO : Appliquer la validation côté serveur

            _listeIdees.Ajouter(idee);
            return View("Liste", _listeIdees.MesIdees);

        }

        // TODO : Modifier -> Créer les actions et vues nécessaires pour pouvoir modifier les idées,
        // assurez-vous d'appliquer la validation des 2 côtés.

        /// <summary>
        /// Supprimer une idée
        /// </summary>
        /// <param name="id">Id de l'idée à supprimer</param>
        /// <returns>La liste</returns>
        public ActionResult Delete(int id)
        {
            _listeIdees.Supprimer(id);
            return View("Liste", _listeIdees.MesIdees);

        }
    }
}
