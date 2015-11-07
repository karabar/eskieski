using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class HaberKategoriRepository : IHaberKategoriRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<HaberKategori> GetAll()
        {
            return _context.HaberKategorileri.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public HaberKategori GetById(int id)
        {
            return _context.HaberKategorileri.FirstOrDefault(x => x.HaberKategoriID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public HaberKategori Get(Expression<Func<HaberKategori, bool>> expression)
        {
            return _context.HaberKategorileri.FirstOrDefault(expression);
        }
        public IQueryable<HaberKategori> GetMany(Expression<Func<HaberKategori, bool>> expression)
        {
            return _context.HaberKategorileri.Where(expression);
        }
        public void Insert(HaberKategori obj)
        {
            _context.HaberKategorileri.Add(obj);
        }
        public void Update(HaberKategori obj)
        {
            _context.HaberKategorileri.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.HaberKategorileri.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.HaberKategorileri.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
