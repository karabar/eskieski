using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class FilmlerRepository : IFilmlerRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Filmler> GetAll()
        {
            return _context.Filmler.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Filmler GetById(int id)
        {
            return _context.Filmler.FirstOrDefault(x => x.FilmID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Filmler Get(Expression<Func<Filmler, bool>> expression)
        {
            return _context.Filmler.FirstOrDefault(expression);
        }
        public IQueryable<Filmler> GetMany(Expression<Func<Filmler, bool>> expression)
        {
            return _context.Filmler.Where(expression);
        }
        public void Insert(Filmler obj)
        {
            _context.Filmler.Add(obj);
        }
        public void Update(Filmler obj)
        {
            _context.Filmler.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Filmler.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Filmler.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
