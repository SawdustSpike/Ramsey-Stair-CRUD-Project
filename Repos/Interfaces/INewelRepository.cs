using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface INewelRepository
    {
        public IEnumerable<Newel> GetAllNewels();
        public void DeleteNewel(Newel n);
        public void UpdateNewel(Newel n);
        public void InsertNewel(Newel n);

    }
}
