using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using AppCore.Interfaces;
using AppCore;
using System.Linq;
using System.Net.Http.Headers;
using AppCore.Models;

namespace Infrastructure.Repos
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> GetAllByStatus(STATUS status = STATUS.ALL)
        {
            if (status == STATUS.ALL) return this.GetAll();
            else return null;
        }

        public T GetBy(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Add(T entity)
        {
            var tracked = _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return tracked.Entity;
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public bool Exists(int id)
        {
            return this.GetBy(id) != null;
        }

        public void Activate(T entity)
        {
            
        }

        public void Disable(T entity)
        {
            
        }
    }
}
