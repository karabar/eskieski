using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class EczaneRepository : IEczaneRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Eczane> GetAll()
        {
            return _context.Eczaneler.Select(x => x); //Bütün Eczaneler Geriye Dönecek
        }
        public Eczane GetById(int id)
        {
            return _context.Eczaneler.FirstOrDefault(x => x.EczaneID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Eczane Get(Expression<Func<Eczane, bool>> expression)
        {
            return _context.Eczaneler.FirstOrDefault(expression);
        }
        public IQueryable<Eczane> GetMany(Expression<Func<Eczane, bool>> expression)
        {
            return _context.Eczaneler.Where(expression);
        }
        public void Insert(Eczane obj)
        {
            _context.Eczaneler.Add(obj);
        }
        public void Update(Eczane obj)
        {
            _context.Eczaneler.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if(gelen != null)
            {
                _context.Eczaneler.Remove(gelen);
            }
            
        }

        public int Count()
        {
            return _context.Eczaneler.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
