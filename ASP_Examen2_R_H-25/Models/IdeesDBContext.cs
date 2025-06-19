namespace ASP_Examen2_R_H_25.Models
{
    public class IdeesDBContext : DbContext
    {
        // TODO : Installer les 2 package NuGet nécessaires pour Entity Framerowk

        public IdeesDBContext(DbContextOptions<IdeesDBContext> options)
        : base(options)
        {
        }

        // TODO : Créer la table Idee

        // TODO : Créer une migration
    }
}
