using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class EtkinlikKategoriRepository : IEtkinlikKategoriRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<EtkinlikKategori> GetAll()
        {
            return _context.EtkinlikKategorileri.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public EtkinlikKategori GetById(int id)
        {
            return _context.EtkinlikKategorileri.FirstOrDefault(x => x.EtkinlikKategoriID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public EtkinlikKategori Get(Expression<Func<EtkinlikKategori, bool>> expression)
        {
            return _context.EtkinlikKategorileri.FirstOrDefault(expression);
        }
        public IQueryable<EtkinlikKategori> GetMany(Expression<Func<EtkinlikKategori, bool>> expression)
        {
            return _context.EtkinlikKategorileri.Where(expression);
        }
        public void Insert(EtkinlikKategori obj)
        {
            _context.EtkinlikKategorileri.Add(obj);
        }
        public void Update(EtkinlikKategori obj)
        {
            _context.EtkinlikKategorileri.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.EtkinlikKategorileri.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.NobetciEczaneler.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
