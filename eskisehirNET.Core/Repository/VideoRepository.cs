using eskisehirNET.Core.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using eskisehirNET.Data.Model;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;

namespace eskisehirNET.Core.Repository
{
    public class VideoRepository : IVideoRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public IEnumerable<Video> GetAll()
        {
            return _context.Videolar.Select(x => x); //Bütün Nöbetçi Eczaneler Geriye Dönecek
        }
        public Video GetById(int id)
        {
            return _context.Videolar.FirstOrDefault(x => x.VideoID == id); //Bu id yi bulursa geriye dönecek bulamazsa null dönecek
        }
        public Video Get(Expression<Func<Video, bool>> expression)
        {
            return _context.Videolar.FirstOrDefault(expression);
        }
        public IQueryable<Video> GetMany(Expression<Func<Video, bool>> expression)
        {
            return _context.Videolar.Where(expression);
        }
        public void Insert(Video obj)
        {
            _context.Videolar.Add(obj);
        }
        public void Update(Video obj)
        {
            _context.Videolar.AddOrUpdate(obj);
        }
        public void Delete(int id)
        {
            var gelen = GetById(id);
            if (gelen != null)
            {
                _context.Videolar.Remove(gelen);
            }

        }

        public int Count()
        {
            return _context.Videolar.Count();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
