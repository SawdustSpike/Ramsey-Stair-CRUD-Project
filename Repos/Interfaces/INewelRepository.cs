using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface INewelRepository
    {
        public IEnumerable<Newels> GetAllNewels();
        public void DeleteNewels(Newels n);
        public void UpdateNewels(Newels n);
        public void InsertNewels(Newels n);

    }
}
