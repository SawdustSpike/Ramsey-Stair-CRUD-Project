using Dapper;
using Ramsey_Stair_CRUD_Project.Models;
using Ramsey_Stair_CRUD_Project.Repos.Interfaces;
using System.Data;

namespace Ramsey_Stair_CRUD_Project.Repos
{
    public class OrderFullRepository : IOrderFullRepository
    {
        private readonly IDbConnection _conn;

        public OrderFullRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public void DeleteOrderFull(OrderFull order)
        {
            
           _conn.Execute("DELETE FROM orderfull WHERE HouseID = @id;", new { id = order.HouseID });
         
        }

        public IEnumerable<OrderFull> GetAllOrderFull()
        {
            return _conn.Query<OrderFull>("SELECT * FROM orderfull;");
        }

        public IEnumerable<Rail> GetAllRail(int id)
        {
            
         return _conn.Query<Rail>("SELECT * FROM Rail WHERE HouseID = @id;", new { id = id});
        }

        public IEnumerable<BalusterStyle> GetBalusterStyle()
        {
           
          return _conn.Query<BalusterStyle>("SELECT * FROM balusterstyle;");
        }

        public IEnumerable<Builder> GetBuilders()
        {
            
          return _conn.Query<Builder>("SELECT * FROM builder;");
        }

        public string PickBuilder(int id)
        {
            var builders = GetBuilders(); 
            foreach (Builder b in builders)
            {
                if (id == b.BuilderID)
                {
                    return b.BuilderName;
                }
            }
            return "Builder Not Found";
        }
        public string PickBaluster(int id)
        {
            var balusters = GetBalusterStyle();
            foreach (BalusterStyle b in balusters)
            {
                if (id == b.BalStyleID)
                {
                    return b.BalStyle;
                }
            }
            return "Baluster Style Not Found";
        }
        public Dictionary<int, string> PickRailStyle()
        {
            var RailStyles = GetRailStyle();
            var res = new Dictionary<int, string>();
            foreach (RailStyle r in RailStyles)
            {
                res.Add(r.RailStyleID, r.RailStyles);
            }
            return res;
        }

        public Dictionary<int,string> PickRailType()
        {
            var RailTypes = GetRailType();
            var res = new Dictionary<int,string>();
            foreach (RailType r in RailTypes)
            {
                res.Add(r.RailTypeID, r.RailTypes);
            }
            return res;
        }

        public Dictionary<int, string> PickCapType()
        {
            var CapTypes = GetCapType();
            var res = new Dictionary<int, string>();
            foreach (CapType c in CapTypes)
            {
                res.Add(c.CaptypeID, c.CapTypes);
            }
            return res;
        }

        public IEnumerable<CapType> GetCapType()
        {
          
        return _conn.Query<CapType>("SELECT CapTypeID, CapType as CapTypes FROM captype;");
        }       
       
        public IEnumerable<Mantle> GetMantles(int id)
        {
           
        return _conn.Query<Mantle>("SELECT * FROM mantle WHERE HouseID = @id;", new {id = id});
        }

        public IEnumerable<Niche> GetNiches(int id)
        {
           
         return _conn.Query<Niche>("SELECT * FROM Niche WHERE HouseID = @id;", new {id = id});
        }

        public IEnumerable<RailStyle> GetRailStyle()
        {
          
          return _conn.Query<RailStyle>("SELECT RailStyleID, RailStyle as RailStyles FROM railstyle;");
        }

        public IEnumerable<RailType> GetRailType()
        {
           
         return _conn.Query<RailType>("SELECT RailTypeID, RailType as RailTypes FROM railtype;");
        }

        public IEnumerable<TubFront> GetTubFronts(int id)
        {
            
            return _conn.Query<TubFront>("SELECT * FROM tubfront WHERE HouseID = @id;", new {id = id});
        }

        public IEnumerable<WallAccess> GetWallAccesses(int id)
        {

            return _conn.Query<WallAccess>("SELECT * FROM wallaccess WHERE HouseID = @id;", new {id = id});
        }
  
        public void UpdateLotNum(OrderFull o)
        {
            _conn.Execute("UPDATE orderfull SET LotNum = @LotNum WHERE HouseID = @id;", new { LotNum = o.LotNum, id = o.HouseID });
        }
        public OrderFull FullOrder(int id) 
        {
            return _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE HouseID = @id;", new { id = id });
        }
        
        public void InsertHouse(OrderFull o)
        {
            _conn.Execute("INSERT INTO orderfull (LotNum)" +
                "VALUES (@LotNum);",
                new { lotNum = o.LotNum });

        }

        public OrderFull GetOrderFull(int id)
        {
            return _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE HouseID = @id;", new { id = id });
        }

        public int? GetHouseID(string lotNum)
        {
            var order = _conn.QuerySingle<OrderFull>("SELECT * FROM orderfull WHERE LotNum = @lotNum;", new { lotNum = lotNum });
            return order.HouseID;
        }      

        public void UpdateHouseDetails(OrderFull o)
        {
            _conn.Execute("UPDATE orderfull SET " +
                "MeasureDone = @measuredone, " +
                "MeasureDate = @measuredate," +
                "MeasureState = @measurestate," +
                "OnHold = @onhold,"+
                "InstallDone = @installdone," +
                "InstallDate = @installdate," +
                "InvoiceNum = @invoicenum," +
                "InvoiceDate = @invoicedate," +
                "BuilderID = @builderID," +
                "Address = @address," +
                "SubDiv= @subdiv," +
                "HardwareColor = @hardwarecolor," +
                "StainColor = @staincolor," +
                "WI = @wi," +
                "Notes = @notes " +
                "WHERE HouseID = @houseID;", new
                {
                    measuredone = o.MeasureDone,
                    measuredate = o.MeasureDate,
                    measurestate = o.MeasureState,
                    onhold = o.OnHold,
                    installdone = o.InstallDone,
                    installdate = o.InstallDate,
                    invoicenum = o.InvoiceNum,
                    invoicedate = o.InvoiceDate,
                    builderID = o.BuilderID,
                    address = o.Address,
                    subdiv = o.SubDiv,
                    hardwarecolor = o.HardwareColor,
                    staincolor = o.StainColor,
                    WI = o.WI,
                    notes = o.Notes,
                    houseID = o.HouseID
                });
        }

        public void UpdateMillWork(OrderFull o)
        {
            _conn.Execute("UPDATE orderfull SET " +
               "PitchNewel = @PitchNewel, " +
               "PitchSleeve = @PitchSleeve," +
               "MiscPitch = @MiscPitch," +
               "Hippo = @Hippo," +
               "FlatNewel = @FlatNewel," +
               "FlatSleeve = @FlatSleeve," +
               "MiscFlat = @MiscFlat," +
               "MiscFlatSleeve= @MiscFlatSleeve," +
               "PitchBal = @PitchBal," +
               "FlatBal = @FlatBal," +
               "PitchRose = @PitchRose," +
               "FlatRose = @FlatRose, " +
               "balStyleID = @balstyleID " +
               "WHERE HouseID = @houseID;", new
               {
                    PitchNewel = o.PitchNewel,
                    PitchSleeve = o.PitchSleeve,
                    MiscPitch = o.MiscPitch,
                    Hippo = o.Hippo,
                    FlatNewel = o.FlatNewel,
                    FlatSleeve = o.FlatSleeve,
                    MiscFlat = o.MiscFlat,
                    MiscFlatSleeve= o.MiscFlatSleeve,
                    PitchBal = o.PitchBal,
                    FlatBal = o.FlatBal,
                    PitchRose = o.PitchRose,
                    FlatRose = o.FlatRose,
                    balStyleID = o.BalStyleID,
                    houseID = o.HouseID
               });
        }
    }
}
