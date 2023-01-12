using Ramsey_Stair_CRUD_Project.Models;
using System.Data;
using System.Drawing;

namespace Ramsey_Stair_CRUD_Project.Service
{
    public class SecurityService
    {  

        UserDAO userDAO = new UserDAO();
        public SecurityService()
        {
           
        }

        public bool IsValid(User user)
        {
            return userDAO.FindUserByNameAndPassword(user);
        }
    
    }
}
