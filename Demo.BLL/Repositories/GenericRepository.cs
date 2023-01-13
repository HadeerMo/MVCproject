using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly MVCAppDbContext _DbContext;
        public GenericRepository(MVCAppDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<int> Add(T item)
        {
            await _DbContext.Set<T>().AddAsync(item);
            return await _DbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(T item)
        {
            _DbContext.Set<T>().Remove(item);
            return await _DbContext.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            if (typeof(T) == typeof(Employee))
            {
                return (T)Convert.ChangeType(await _DbContext.Set<Employee>().Include(E => E.Department).Where(E => E.Id == id).FirstOrDefaultAsync(), typeof(T));
            }

            return await _DbContext.Set<T>().FindAsync(id);
        }


        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Employee))
                return (IEnumerable<T>)await _DbContext.Employees.Include(E => E.Department).ToListAsync();
            return await _DbContext.Set<T>().ToListAsync();
        }

        public async Task<int> Update(T item)
        {
            _DbContext.Set<T>().Update(item);
            return await _DbContext.SaveChangesAsync();
        }
    }
}
