using AppData.IRepositories;
using Microsoft.EntityFrameworkCore;
using ShopDoGiaDung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class AllRepositories<T> : IAllRepositories<T> where T : class
    {
        ShoppingDBContext context;
        DbSet<T> dbSet;
        public AllRepositories(ShoppingDBContext context, DbSet<T> dbSet)
        {
            this.context = context;
            this.dbSet = dbSet;
        }
        public bool CreateItem(T item)
        {
            try
            {
                dbSet.Add(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteItem(T item)
        {
            try
            {
                dbSet.Remove(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public bool UpdateItem(T item)
        {
            try
            {
                dbSet.Update(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
