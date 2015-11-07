using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class HaberTipRepository : IHaberTipRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<HaberTip> GetAll()
        {
            return _context.HaberTipleri.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public HaberTip GetById(int id)
        {
            return _context.HaberTipleri.FirstOrDefault(x => x.HaberTipID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public HaberTip Get(Expression<Func<HaberTip, bool>> expression)
        {
            return _context.HaberTipleri.FirstOrDefault(expression);
        }
        public IQueryable<HaberTip> GetMany(Expression<Func<HaberTip, bool>> expression)
        {
            return _context.HaberTipleri.Where(expression);
        }
        public void Insert(HaberTip obj)
        {
            _context.HaberTipleri.Add(obj);
        }
        public void Update(HaberTip obj)
        {
            _context.HaberTipleri.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.HaberTipleri.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.HaberTipleri.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
