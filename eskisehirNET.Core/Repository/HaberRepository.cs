using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class HaberRepository : IHaberRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Haber> GetAll()
        {
            return _context.Haberler.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Haber GetById(int id)
        {
            return _context.Haberler.FirstOrDefault(x => x.HaberID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Haber Get(Expression<Func<Haber, bool>> expression)
        {
            return _context.Haberler.FirstOrDefault(expression);
        }
        public IQueryable<Haber> GetMany(Expression<Func<Haber, bool>> expression)
        {
            return _context.Haberler.Where(expression);
        }
        public void Insert(Haber obj)
        {
            _context.Haberler.Add(obj);
        }
        public void Update(Haber obj)
        {
            _context.Haberler.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Haberler.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Haberler.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
