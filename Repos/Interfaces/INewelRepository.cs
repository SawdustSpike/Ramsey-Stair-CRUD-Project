using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface INewelRepository
    {
        public IEnumerable<Newels> GetAllNewels();
        public void DeleteNewels(Newels newelLine);
        public void UpdateNewels(Newels newels);
        public void InsertNewels(Newels newelToInsert);

    }
}
