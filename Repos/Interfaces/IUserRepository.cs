using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public void DeleteUser(User u);
        public void UpdateUser(User u);
        public void InsertUser(User u);
    }
}
