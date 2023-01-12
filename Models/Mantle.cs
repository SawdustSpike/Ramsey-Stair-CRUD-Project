using System.ComponentModel.DataAnnotations;

namespace Ramsey_Stair_CRUD_Project.Models
{
    public class Mantle
    {
        public int MantleID { get; set; }
        [StringLength(20)]
        public string? MantleType { get; set; }
        [StringLength(100)]
        public string? MantleNotes { get; set; }
        public int MantleQuantity { get; set; } = 0;
        public int HouseID { get; set; }

    }
}
