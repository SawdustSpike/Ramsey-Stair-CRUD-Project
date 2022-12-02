namespace Ramsey_Stair_CRUD_Project.Models
{
    public class WallAccess
    {
        public int WallAccessID { get; set; }        
        public double? WallAccessHeight { get; set; }
        public double? WallAccessWidth { get; set; }
        public string? WallAccessNotes { get; set; }
        public int? WallAccessQuantity { get; set; } = 0;
        public int? HouseID { get; set; }

    }
}
