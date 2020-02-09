using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HarpMeNow
{
    
    public class Harp
    {
        [BsonId]
        public Guid Id { get; set; }
        public DateTime Stamp { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public eKey Key { get; set; }
        public List<AirSlotAttributesClass> AirSlots { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class HarpGrid : Harp
    {

    }

    public class SQLDataClass
    {
        public string DatabaseName = string.Empty;

        bool asc = true;
        public SQLDataClass(string dbName)
        {
            DatabaseName = dbName;

        }

        public void SortGrid(DataGridView grid, int ColumnIndex)
        {

            List<HarpGrid> list = grid.DataSource as List<HarpGrid>;
            List<HarpGrid> SortedList = list;
            string cnn = grid.Columns[ColumnIndex].Name;
            string direction = asc ? "Ascending" : "Descending";
            asc = !asc;

            SortedList = Sort_List(direction, cnn, list);
            grid.DataSource = null;
            grid.DataSource = SortedList;
            //grid.Columns[0].Visible = false;
            //grid.Refresh();
        }

        
        public List<Harp> GetAll()
        {
            var list = new List<Harp>();
            using (var db = new LiteDatabase($@"{DatabaseName}"))
            {
                var col = db.GetCollection<Harp>("datas");
                foreach (Harp _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        
       
        public List<Harp> GetInstument(string name)
        {
            var list = new List<Harp>();

            using (var db = new LiteDatabase($@"{DatabaseName}"))
            {
                var col = db.GetCollection<Harp>("datas");
                foreach (Harp _id in col.Find(x => (x.Name == name)))
                {
                    list.Add(_id);
                }
            }

            return list;
        }
        public List<Harp> GetID(Guid id)
        {
            var list = new List<Harp>();

            using (var db = new LiteDatabase($@"{DatabaseName}"))
            {
                var col = db.GetCollection<Harp>("datas");
                foreach (Harp _id in col.Find(x => (x.Id == id)))
                {
                    list.Add(_id);
                }
            }

            return list;
        }
        public List<AirSlotAttributesClass> GetSlotID(int slot)
        {
            var list = new List<AirSlotAttributesClass>();

            using (var db = new LiteDatabase($@"{DatabaseName}"))
            {
                var col = db.GetCollection<AirSlotAttributesClass>("datas");
                foreach (AirSlotAttributesClass _id in col.Find(x =>  (x.Slot == slot)))
                {
                    list.Add(_id);
                }
            }

            return list;
        }
        /*
        public List<HarpGrid> GetAllToday4Level(eMessageLevel level)
        {
            var list = new List<HarpGrid>();
            using (var db = new LiteDatabase($@"{DatabaseName}"))
            {
                var col = db.GetCollection<DataClass>("datas");
                string today = DateTimeExtensions.Instance().TodayStart();
                foreach (Harp _id in col.Find(x => DateTimeExtensions.Instance().Compare(x.Stamp, today) <= 0 && x.MessageLevel == level))
                {
                    list.Add(new HarpGrid(_id, DatabaseName));
                }
            }
            return list;
        }
        public List<HarpGrid> GetAllToday()
        {
            var list = new List<HarpGrid>();
            using (var db = new LiteDatabase($@"{DatabaseName}"))
            {
                var col = db.GetCollection<DataClass>("datas");
                string today = DateTimeExtensions.Instance().TodayStart();
                foreach (Harp _id in col.Find(x => DateTimeExtensions.Instance().Compare(x.Stamp, today) <= 0))
                {
                    list.Add(new HarpGrid(_id, DatabaseName));
                }
            }
            return list;
        }
        */


        public List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
        public List<T> Sort_Slot_BreathDirection_AirSlotsList<T>(string sortDirection, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, "Slot") ascending, GetDynamicSortProperty(n, "BreathDirection") ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, "Slot") descending, GetDynamicSortProperty(n, "BreathDirection") descending
                               select n).ToList();

            }
            return data_sorted;
        }
        List<Harp> lst = new List<Harp>();

        public void ClearDatas()
        {
            lst.Clear();
        }


        public object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }


        public List<AirSlotAttributesClass> GetSortAirSlots(List<AirSlotAttributesClass> list)
        {                        
            return Sort_Slot_BreathDirection_AirSlotsList("Ascending", list);
        }

        public int FindCountEntry(Harp sql)
        {
            int count = 0;
            using (var db = new LiteDatabase(DatabaseName))
            {
                var datas = db.GetCollection<Harp>("datas");
                datas.EnsureIndex(x => x.Id);
                var r = datas.Find(x => x.Id == sql.Id);
                count = r.Count();
            }
            return count;
        }
        public bool DeleteEntry(Guid id)
        {
            using (var db = new LiteDatabase(DatabaseName))
            {

                var historys = db.GetCollection<Harp>("datas");

                return historys.Delete(id);
            }
        }

        public bool InsertDatas(Harp datas)
        {
            try
            {
                //BsonMapper.Global.Entity<IdentityServer4.Models.IdentityResources.OpenId>().Id(oid => oid.Name);
                using (var db = new LiteDatabase(DatabaseName))
                {

                    var dataobject = db.GetCollection<Harp>("datas");
                    dataobject.EnsureIndex(x => x.Name);
                    var results = dataobject.Find(X=> X.Name == datas.Name);
                    if (results.Count() > 0)
                    {
                        dataobject.Update(datas);
                    }
                    else
                    {
                        dataobject.Insert(datas);
                        dataobject.EnsureIndex(x => x.Id);
                        dataobject.EnsureIndex(x => x.Name);
                        dataobject.EnsureIndex(x => x.Stamp);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateDatas(Harp datas)
        {
            try
            {
                //BsonMapper.Global.Entity<IdentityServer4.Models.IdentityResources.OpenId>().Id(oid => oid.Name);
                using (var db = new LiteDatabase(DatabaseName))
                {
                    var dataobject = db.GetCollection<Harp>("datas");
                    dataobject.EnsureIndex(x => x.Id);                    
                    dataobject.Update(datas);                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateSlotDatas(AirSlotAttributesClass datas)
        {
            try
            {
                //BsonMapper.Global.Entity<IdentityServer4.Models.IdentityResources.OpenId>().Id(oid => oid.Name);
                using (var db = new LiteDatabase(DatabaseName))
                {
                    var dataobject = db.GetCollection<AirSlotAttributesClass>("datas");
                    dataobject.EnsureIndex(x => x.Slot);
                    dataobject.Update(datas);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
