namespace Ramsey_Stair_CRUD_Project.Models
{
    public class TubFront
    {
        public int TubFrontID { get; set; }
        public double? TubFrontLength { get; set; }
        public double? TubFrontHeight { get; set; }
        public int TubFrontQuantity { get; set; } = 0;
        public int HouseID { get; set; }
    }
}
