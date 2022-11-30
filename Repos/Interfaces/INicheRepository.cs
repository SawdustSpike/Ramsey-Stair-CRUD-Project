using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface INicheRepository
    {
        public IEnumerable<Niche> GetAllNiches();
        public void DeleteNiche(Niche n);
        public void UpdateNiche(Niche n);
        public void InsertNiche(Niche n);
    }
}
