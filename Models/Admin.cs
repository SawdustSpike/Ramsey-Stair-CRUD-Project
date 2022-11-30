namespace Ramsey_Stair_CRUD_Project.Models
{
    public class Admin
    {
        public int AdminID { get; set; }
        public bool MeasureDone { get; set; } = false;
        public string MeasureDate { get; set; }
        public string MeasureState { get; set; }
        public string InstallDate { get; set; }
        public bool InstallDone { get; set; } = false;
        public int InvoiceNum { get; set; }
        public string InvoiceDate { get; set; }




    }
}
