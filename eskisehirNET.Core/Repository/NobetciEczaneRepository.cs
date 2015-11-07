using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class NobetciEczaneRepository : INobetciEczaneRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<NobetciEczane> GetAll()
        {
            return _context.NobetciEczaneler.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public NobetciEczane GetById(int id)
        {
            return _context.NobetciEczaneler.FirstOrDefault(x => x.NobetciID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public NobetciEczane Get(Expression<Func<NobetciEczane, bool>> expression)
        {
            return _context.NobetciEczaneler.FirstOrDefault(expression);
        }
        public IQueryable<NobetciEczane> GetMany(Expression<Func<NobetciEczane, bool>> expression)
        {
            return _context.NobetciEczaneler.Where(expression);
        }
        public void Insert(NobetciEczane obj)
        {
            _context.NobetciEczaneler.Add(obj);
        }
        public void Update(NobetciEczane obj)
        {
            _context.NobetciEczaneler.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.NobetciEczaneler.Remove(gelen);
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
