using System.Diagnostics;
using ASP_Examen2_R_H_25.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Examen2_R_H_25.Controllers
{
    public class IdeeController : Controller
    {
        private IIdeesRep _listeIdees;

        // TODO : Initialiser la liste d'Id�es � l'aide du service

        // TODO : Action Index -> Afficher la liste d'id�e dans la vue fournie.

        /// <summary>
        /// Afficher le formulaire d'ajout
        /// </summary>
        /// <returns>La page de formulaire</returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View("Formulaire"); // TODO : Cr�er cette vue, assurez-vous d'appliquer la validation c�t� client.
        }

        /// <summary>
        /// Ajouter une id�e
        /// </summary>
        /// <param name="idee">L'id�e cr��e � partir des donn�es du formulaire</param>
        /// <returns>La liste d'id�e ou le formulaire avec messages d'erreurs</returns>
        [HttpPost]
        public ActionResult Create(Idee idee)
        {
            //TODO : Appliquer la validation c�t� serveur

            _listeIdees.Ajouter(idee);
            return View("Liste", _listeIdees.MesIdees);

        }

        // TODO : Modifier -> Cr�er les actions et vues n�cessaires pour pouvoir modifier les id�es,
        // assurez-vous d'appliquer la validation des 2 c�t�s.

        /// <summary>
        /// Supprimer une id�e
        /// </summary>
        /// <param name="id">Id de l'id�e � supprimer</param>
        /// <returns>La liste</returns>
        public ActionResult Delete(int id)
        {
            _listeIdees.Supprimer(id);
            return View("Liste", _listeIdees.MesIdees);

        }
    }
}
