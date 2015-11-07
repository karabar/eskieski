using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class EtkinlikRepository : IEtkinlikRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Etkinlik> GetAll()
        {
            return _context.Etkinlikler.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Etkinlik GetById(int id)
        {
            return _context.Etkinlikler.FirstOrDefault(x => x.EtkinlikID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Etkinlik Get(Expression<Func<Etkinlik, bool>> expression)
        {
            return _context.Etkinlikler.FirstOrDefault(expression);
        }
        public IQueryable<Etkinlik> GetMany(Expression<Func<Etkinlik, bool>> expression)
        {
            return _context.Etkinlikler.Where(expression);
        }
        public void Insert(Etkinlik obj)
        {
            _context.Etkinlikler.Add(obj);
        }
        public void Update(Etkinlik obj)
        {
            _context.Etkinlikler.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Etkinlikler.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Etkinlikler.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
