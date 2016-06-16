using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebDeveloper.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T: class
    {
        public int Add(T entity)
        {
            using (var dbcontext = new WebContextDb())
            {
                dbcontext.Entry(entity).State = EntityState.Added;
                return dbcontext.SaveChanges();
            }
        }

        public int Delete(T entity)
        {
            using (var dbcontext = new WebContextDb())
            {
                dbcontext.Entry(entity).State = EntityState.Deleted;
                return dbcontext.SaveChanges();
            }
        }

        public List<T> GetList()
        {
            using (var dbcontext = new WebContextDb())
            {
                return dbcontext.Set<T>().ToList();
            }
        }

        public int Update(T entity)
        {
            using (var dbcontext = new WebContextDb())
            {
                dbcontext.Entry(entity).State = EntityState.Modified;
                return dbcontext.SaveChanges();
            }
        }
    }
}
