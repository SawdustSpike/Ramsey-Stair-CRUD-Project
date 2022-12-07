using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface INicheRepository
    {
        public IEnumerable<Niche> GetAllNiches(int id);
        public void DeleteNiche(Niche m);
        public void UpdateNiche(Niche m);
        public void InsertNiche(Niche m);
        public OrderFull GetLotNum(int id);
    }
}
