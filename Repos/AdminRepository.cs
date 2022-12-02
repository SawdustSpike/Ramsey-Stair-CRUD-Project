using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class AdminRepository : IAdminRepository
    {
       
            private readonly IDbConnection _conn;

            public AdminRepository(IDbConnection conn)
            {
                _conn = conn;
            }

            public void DeleteAdmin(Admin a)
            {
                _conn.Execute("DELETE FROM Admin WHERE AdminID = @id;", new { id = a.AdminID });
            }

            public IEnumerable<Admin> GetAllAdmins()
            {
                return _conn.Query<Admin>("SELECT * FROM Admin;");
            }

            public void InsertAdmin(Admin a)
            {
            _conn.Execute("INSERT INTO Admins (MeasureDone, MeasureDate, MeasureState, InstallDate, InvoiceNum, InvoiceDate, InstallDone)" +
                "Values @ (@MeasureDone, @MeasureDate, @MeasureState, @InstallDate, @InvoiceNum, @InvoiceDate, @InstallDone);",
                new { MeasureDone = a.MeasureDone, MeasureDate = a.MeasureDate, MeasureState = a.MeasureState, InstallDate = a.InstallDate, InvoiceNum = a.InvoiceNum, InvoiceDate = a.InvoiceDate, InstallDone = a.InstallDone });
            }

            public void UpdateAdmin(Admin a)
            {
                _conn.Execute("UPDATE Admins" +
                    "SET MeasureDone =@MeasureDone, " +
                    "MeasureDate=@MeasureDate, " +
                    "MeasureState =@MeasureState, " +
                    "InstallDate=@InstallDate, " +
                    "InvoiceNum=@InvoiceNum, " +
                    "InvoiceDate =@InvoiceDate, " +
                    "InstallDone=@InstallDone;",
                    new { MeasureDone = a.MeasureDone, 
                        MeasureDate = a.MeasureDate, 
                        MeasureState = a.MeasureState, 
                        InstallDate = a.InstallDate, 
                        InvoiceNum = a.InvoiceNum, 
                        InvoiceDate = a.InvoiceDate, 
                        InstallDone = a.InstallDone });



        }
        }
}
