using EzPOS.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPOS.Services.Products
{
    public class UnitService
    {
        private POSContext context;

        public UnitService(POSContext context)
        {
            this.context = context;
        }

        public void SaveUnit(Unit unit)
        {
            if (unit.Id == 0)
            {
                context.Units.Add(unit);
                unit.CreateBy = Session.LoginUser.Username;
                unit.CreateDate = DateTime.Now;
                context.Entry(unit).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                context.Units.Attach(unit);
                unit.UpdateBy = Session.LoginUser.Username;
                unit.UpdateDate = DateTime.Now;
                context.Entry(unit).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
        }

        public IEnumerable<Unit> GetAllActiveUnits()
        {
            return context.Units.ToList();
        }

        public Unit GetUnitById(int id)
        {
            return context.Units.First(x => x.Id == id);
        }

        public void DeleteUnit(int id)
        {
            var unit = context.Units.First(x => x.Id == id);
            context.Units.Remove(unit);
            context.SaveChanges();
        }
    }
}
