using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class YasamKategoriRepository : IYasamKategoriRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<YasamKategori> GetAll()
        {
            return _context.YasamKategorileri.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public YasamKategori GetById(int id)
        {
            return _context.YasamKategorileri.FirstOrDefault(x => x.YasamKategoriID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public YasamKategori Get(Expression<Func<YasamKategori, bool>> expression)
        {
            return _context.YasamKategorileri.FirstOrDefault(expression);
        }
        public IQueryable<YasamKategori> GetMany(Expression<Func<YasamKategori, bool>> expression)
        {
            return _context.YasamKategorileri.Where(expression);
        }
        public void Insert(YasamKategori obj)
        {
            _context.YasamKategorileri.Add(obj);
        }
        public void Update(YasamKategori obj)
        {
            _context.YasamKategorileri.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.YasamKategorileri.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.YasamKategorileri.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
