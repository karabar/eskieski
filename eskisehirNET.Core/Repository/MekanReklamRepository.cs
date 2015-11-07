using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class MekanReklamRepository : IMekanReklamRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<MekanReklam> GetAll()
        {
            return _context.MekanReklamlari.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public MekanReklam GetById(int id)
        {
            return _context.MekanReklamlari.FirstOrDefault(x => x.MekanReklamID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public MekanReklam Get(Expression<Func<MekanReklam, bool>> expression)
        {
            return _context.MekanReklamlari.FirstOrDefault(expression);
        }
        public IQueryable<MekanReklam> GetMany(Expression<Func<MekanReklam, bool>> expression)
        {
            return _context.MekanReklamlari.Where(expression);
        }
        public void Insert(MekanReklam obj)
        {
            _context.MekanReklamlari.Add(obj);
        }
        public void Update(MekanReklam obj)
        {
            _context.MekanReklamlari.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.MekanReklamlari.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.MekanReklamlari.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
