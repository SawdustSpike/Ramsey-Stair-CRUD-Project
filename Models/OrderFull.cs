using Google.Protobuf;

namespace Ramsey_Stair_CRUD_Project.Models
{
    public class OrderFull
    {
        public int OrderID { get; set; }
        public bool MeasureDone { get; set; } // = false;
        public string MeasureDate { get; set; }
        public string MeasureState { get; set; }
        public string InstallDate { get; set; }
        public bool InstallDone { get; set; } //= false;
        public int InvoiceNum { get; set; }
        public string InvoiceDate { get; set; }
        public int PitchBal { get; set; }
        public int FlatBal { get; set; }
        public int BalTypeID { get; set; }
        public int HouseID { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string Model { get; set; }
        public string SubDiv { get; set; }
        public int BuilderID { get; set; }
        public string HardwareColor { get; set; }
        public int Pitch { get; set; }
        public int PitchSleeve { get; set; }
        public int MiscPitch { get; set; }
        public int Hippo { get; set; }
        public int Flat { get; set; }
        public int FlatSleeve { get; set; }
        public int MiscFlat { get; set; }
        public int MiscFlatSleeve { get; set; }
        public int PitchRose { get; set; }
        public int FlatRose { get; set; }
        public IEnumerable<Rail> Railines { get; set; }
        public IEnumerable<TubFront> TubFronts { get; set; }
        public IEnumerator<WallAccess> WallAcsesses { get; set; }
        public IEnumerable<Niche> Niches { get; set; }



    }
}
