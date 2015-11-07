using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class SeanslarRepository : ISeanslarRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Seanslar> GetAll()
        {
            
            return _context.Seanslar.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Seanslar GetById(int id)
        {
            
            return _context.Seanslar.FirstOrDefault(x => x.SeansID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Seanslar Get(Expression<Func<Seanslar, bool>> expression)
        {
            return _context.Seanslar.FirstOrDefault(expression);
        }
        public IQueryable<Seanslar> GetMany(Expression<Func<Seanslar, bool>> expression)
        {
            return _context.Seanslar.Where(expression);
        }
        public void Insert(Seanslar obj)
        {
            _context.Seanslar.Add(obj);
        }
        public void Update(Seanslar obj)
        {
            _context.Seanslar.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Seanslar.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Seanslar.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
