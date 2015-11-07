using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class MekanKategoriRepository : IMekanKategoriRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<MekanKategori> GetAll()
        {
            return _context.MekanKategorileri.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public MekanKategori GetById(int id)
        {
            return _context.MekanKategorileri.FirstOrDefault(x => x.MekanKatgoriID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public MekanKategori Get(Expression<Func<MekanKategori, bool>> expression)
        {
            return _context.MekanKategorileri.FirstOrDefault(expression);
        }
        public IQueryable<MekanKategori> GetMany(Expression<Func<MekanKategori, bool>> expression)
        {
            return _context.MekanKategorileri.Where(expression);
        }
        public void Insert(MekanKategori obj)
        {
            _context.MekanKategorileri.Add(obj);
        }
        public void Update(MekanKategori obj)
        {
            _context.MekanKategorileri.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.MekanKategorileri.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.MekanKategorileri.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
