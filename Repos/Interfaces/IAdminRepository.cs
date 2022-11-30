using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IAdminRepository
    {
        public IEnumerable<Admin> GetAllAdmins();
        public void DeleteAdmin(Admin a);
        public void UpdateAdmin(Admin a);
        public void InsertAdmin(Admin a);
    }
}
