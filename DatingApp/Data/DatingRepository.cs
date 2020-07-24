using DatingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public class DatingRepository : IDatingRepository
    {
        private readonly ApplicationDataContext _appContext;

        public DatingRepository(ApplicationDataContext Context)
        {
            _appContext = Context;
        }

        public void Add<T>(T entity) where T : class
        {
            _appContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _appContext.Remove(entity);
        }

        public Task<User> GetUser(int id)
        {
            var user = _appContext.Users.Include(p => p.Photos).FirstOrDefaultAsync(u=>u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _appContext.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _appContext.SaveChangesAsync() > 0;
        }
    }
}
