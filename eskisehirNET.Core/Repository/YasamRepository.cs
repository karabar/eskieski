using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class YasamRepository : IYasamRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Yasam> GetAll()
        {
            return _context.Yasamlar.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Yasam GetById(int id)
        {
            return _context.Yasamlar.FirstOrDefault(x => x.YasamID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Yasam Get(Expression<Func<Yasam, bool>> expression)
        {
            return _context.Yasamlar.FirstOrDefault(expression);
        }
        public IQueryable<Yasam> GetMany(Expression<Func<Yasam, bool>> expression)
        {
            return _context.Yasamlar.Where(expression);
        }
        public void Insert(Yasam obj)
        {
            _context.Yasamlar.Add(obj);
        }
        public void Update(Yasam obj)
        {
            _context.Yasamlar.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Yasamlar.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Yasamlar.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
