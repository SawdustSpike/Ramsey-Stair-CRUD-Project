namespace Ramsey_Stair_CRUD_Project.Models
{
    public class WallAccess
    {
        public int WallAccessID { get; set; }
        //public bool WallAccessSTD { get; set; }
        public double? WallAccessHeight { get; set; }
        public double? WallAccessWidth { get; set; }
        public string? WallAccessNotes { get; set; }
        public int? WallAccessQuantity { get; set; }
        public int? HouseID { get; set; }

    }
}
