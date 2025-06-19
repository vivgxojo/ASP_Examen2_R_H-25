using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_Examen2_R_H_25.Models
{
    public interface IIdeesRep
    {
        IEnumerable<Idee> MesIdees { get; }

        /// <summary>
        /// Ajouter une idée à la collection
        /// </summary>
        /// <param name="idee">L'idée à ajouter</param>
        public void Ajouter(Idee idees);

        /// <summary>
        /// Modifier une idée de la collection
        /// </summary>
        /// <param name="idees">L'idée à modifier</param>
        public void Modifier(Idee idees);

        /// <summary>
        /// Supprimer une idée de la collection
        /// </summary>
        /// <param name="id">L'id de l'idée à supprimer</param>
        public void Supprimer(int id);
    }
}
