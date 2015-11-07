using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class MekanRepository : IMekanRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Mekan> GetAll()
        {
            return _context.Mekanlar.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Mekan GetById(int id)
        {
            return _context.Mekanlar.FirstOrDefault(x => x.MekanID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Mekan Get(Expression<Func<Mekan, bool>> expression)
        {
            return _context.Mekanlar.FirstOrDefault(expression);
        }
        public IQueryable<Mekan> GetMany(Expression<Func<Mekan, bool>> expression)
        {
            return _context.Mekanlar.Where(expression);
        }
        public void Insert(Mekan obj)
        {
            _context.Mekanlar.Add(obj);
        }
        public void Update(Mekan obj)
        {
            _context.Mekanlar.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Mekanlar.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Mekanlar.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
