using DTL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAL.Util
{
    public abstract class AbstractContext<T> : Context where T : class 
    {
        /// <summary>
        /// Create - Add object
        /// </summary>
        /// <param name="obj">Object </param>
        /// <returns>Quantity Added</returns>
        public int Create(T obj)
        {
            try
            {
                Entry<T>(obj).State = EntityState.Added;
                return SaveChanges();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Create - Add multiple objects
        /// </summary>
        /// <param name="iObj">IEnumerable of objects</param>
        /// <returns>Quantity Added</returns>
        public int Create(IEnumerable<T> iObj)
        {
            try
            {
                foreach (var item in iObj)
                {
                    Entry<T>(item).State = EntityState.Added;
                }

                return SaveChanges();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete - Remove object
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Quantity Removed</returns>
        public int Delete(T obj)
        {
            try
            {
                Entry<T>(obj).State = EntityState.Deleted;
                return SaveChanges();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete - Remove multiple objects
        /// </summary>
        /// <param name="iObj">IEnumerable of objects</param>
        /// <returns>Quantity Removed</returns>
        public int Delete(IEnumerable<T> iObj)
        {
            try
            {
                foreach (var item in iObj)
                {
                    Entry<T>(item).State = EntityState.Deleted;
                }

                return SaveChanges();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select all rows of table
        /// </summary>
        /// <returns>IEnumerable of object</returns>
        public IEnumerable<T> Select()
        {
            try
            {
                return Set<T>();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select all rows on condition
        /// </summary>
        /// <param name="where">Expression</param>
        /// <returns>IEnumeable of object</returns>
        public IEnumerable<T> Select(Expression<Func<T, bool>> where)
        {
            try
            {
                return Set<T>().Where(where);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Select all rows on condition and set specific element
        /// </summary>
        /// <param name="where">Expression</param>
        /// <param name="select">Expression</param>
        /// <returns>IEnumerable</returns>
        public IEnumerable<T> Select(Expression<Func<T, bool>> where, Expression<Func<T, T>> select)
        {
            try
            {
                return Set<T>().Where(where).Select(select);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update object
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Quantity updated</returns>
        public int Update(T obj)
        {
            try
            {
                Entry<T>(obj).State = EntityState.Modified;
                return SaveChanges();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update objects
        /// </summary>
        /// <param name="iObj">IEnumerable of object</param>
        /// <returns>Quantity updated</returns>
        public int Update(IEnumerable<T> iObj)
        {
            try
            {
                foreach (var item in iObj)
                {

                    Entry<T>(item).State = EntityState.Modified;

                }
                return SaveChanges();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
