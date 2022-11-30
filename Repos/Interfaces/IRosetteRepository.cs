using Ramsey_Stair_CRUD_Project.Models;

namespace Ramsey_Stair_CRUD_Project.Repos.Interfaces
{
    public interface IRosetteRepository
    {
        public IEnumerable<Rosette> GetAllRosettes();
        public void DeleteRosette(Rosette r);
        public void UpdateRosette(Rosette r);
        public void InsertRosette(Rosette r);
        
    }
}
