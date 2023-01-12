using Google.Protobuf;
using System.ComponentModel.DataAnnotations;

namespace Ramsey_Stair_CRUD_Project.Models
{
    public class OrderFull
    {
        [Required]
        [StringLength(20)]
        public string? LotNum { get; set; }
        public bool MeasureDone { get; set; } = true;
        [StringLength(15)]
        public string MeasureDate { get; set; }
        [StringLength(15)]
        public string? MeasureState { get; set; }
        public bool OnHold { get; set; }
        [StringLength(15)]
        public string InstallDate { get; set; }
        public bool InstallDone { get; set; } = false;
        public int? InvoiceNum { get; set; }
        [StringLength(15)]
        public string InvoiceDate { get; set; }
        public int? PitchBal { get; set; } = 0;
        public int FlatBal { get; set; } = 0;
        public int? BalStyleID { get; set; } 
        public int? HouseID { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(500)]
        public string? Notes { get; set; }
        [StringLength(20)]
        public string? Model { get; set; }
        [StringLength(20)]
        public string? SubDiv { get; set; }
        public int? BuilderID { get; set; }
        [StringLength(20)]
        public string? HardwareColor { get; set; }
        [StringLength(20)]
        public string StainColor { get; set; }
        public bool WI { get; set; } = false;
        public int PitchNewel { get; set; } = 0;
        public int PitchSleeve { get; set; } = 0;
        public int MiscPitch { get; set; } = 0;
        public int Hippo { get; set; } = 0;
        public int FlatNewel { get; set; } = 0;
        public int FlatSleeve { get; set; } = 0;
        public int MiscFlat { get; set; } = 0;
        public int MiscFlatSleeve { get; set; } = 0;
        public int PitchRose { get; set; } = 0;
        public int FlatRose { get; set; } = 0;
        public IEnumerable<Rail>? Railines { get; set; }
        public IEnumerable<TubFront>? TubFronts { get; set; }
        public IEnumerable<WallAccess>? WallAccesses { get; set; }
        public IEnumerable<Niche>? Niches { get; set; }
        public IEnumerable<Mantle>? Mantles { get; set; }    
    }
}
