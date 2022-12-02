namespace Ramsey_Stair_CRUD_Project.Models
{
    public class Mantle
    {
        public int MantleID { get; set; }
        public string? MantleType { get; set; }
        public string? MantleNotes { get; set; }
        public int MantleQuantity { get; set; } = 0;
        public int HouseID { get; set; }

    }
}
