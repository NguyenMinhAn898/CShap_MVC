using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Data.DAO
{
    public abstract class BaseDAO<T> : IDao<T>
    {
        protected Database database = Database.getDatabase;
        public abstract String tableName { get; }


        /// <summary>
        /// Insert row in table
        /// </summary>
        /// <param name="rowInsert"> new row insert table </param>
        /// <returns>True || false </returns>
        public bool insertTable(T rowInsert)
        {
            return database.insertTable(tableName, rowInsert) > 0 ? true : false;
        }

        /// <summary>
        /// Get all list row in table
        /// </summary>
        /// <returns></returns>
        public List<T> findAll()
        {
            return database.selectTable(tableName).Cast<T>().ToList();
        }


        /*
         * Get a row with id row 
         * 
         * @Param id : id row
         * @Return a object is row
         */
        public T findById(int id)
        {
            return (T)database.findTableById(tableName, id);
        }

        /*
         * Upate table 
         * 
         * @Param Ttable
         * @Return row update
         */
        public T updateTable(T rowUpdate)
        {
            return database.updateTable(tableName, rowUpdate) > 0 ? rowUpdate : default(T);
        }

        public List<object> findAllByTitle(string name)
        {
            return database.selectTable(tableName, name);
        }

        public bool deleteTable(T rowDelete)
        {
            return false;
        }
    }
}
