using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class UserRepository :IUserRepository
    {
        private readonly IDbConnection _conn;

        public UserRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteUser(User u)
        {
            _conn.Execute("DELETE FROM User WHERE UserID = @id;", new { id = u.UserID });
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _conn.Query<User>("SELECT * FROM User;");
        }

        public void InsertUser(User u)
        {
            _conn.Execute("INSERT INTO User (UserName) VALUES (@UserName);",
                new { userName = u.UserName });
        }

        public void UpdateUser(User u)
        {
            _conn.Execute("UPDATE User SET UserName = @UserName;", new { userName = u.UserName });
        }
    }
}
