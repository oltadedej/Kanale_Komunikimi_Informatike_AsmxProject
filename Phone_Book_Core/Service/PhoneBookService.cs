using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book_Core.Service
{
    public class PhoneBookService
    {

        public bool Connected()
        {

            bool connected = false;
            using (PHONE_BOOK_DBEntities dBEntities = new PHONE_BOOK_DBEntities())
            {

                connected = true;
            }


            return connected;
        }


        public T_PHONE_BOOK GetById(long id)
        {

            using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
            {
                return db.T_PHONE_BOOK.ToList().Where(i => i.ID == id && !i.DELETED_DATE.HasValue).FirstOrDefault();
            }


        }


        public bool Save(T_PHONE_BOOK item)
        {
            bool isInserted = false;
            if (item != null)
            {
                try
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        item.INSERTED_DATE = DateTime.Now;
                        db.T_PHONE_BOOK.Add(item);
                        db.SaveChanges();
                        isInserted = true;
                    }

                }
                catch (Exception ex)
                {

                    // write logs into file logs
                }


            }

            return isInserted;

        }


        public bool Put(T_PHONE_BOOK item)
        {
            bool isUpdated = false;
            if (item != null)
            {
                try
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        item.MODIFIED_DATE = DateTime.Now;
                        db.T_PHONE_BOOK.Add(item);
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        isUpdated = true;
                    }

                }
                catch (Exception ex)
                {

                    // write logs into file logs
                }


            }

            return isUpdated;

        }


        public bool Delete(T_PHONE_BOOK item)
        {
            bool isDeleted = false;
            if (item != null)
            {
                try
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        item.DELETED_DATE = DateTime.Now;
                        db.T_PHONE_BOOK.Add(item); 
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified; // delete logjik
                        db.SaveChanges();
                        isDeleted = true;
                    }

                }
                catch (Exception ex)
                {

                    // write logs into file logs
                }

            }

            return isDeleted;
        }

        /// <summary>
        /// Kjo metode tenton te realizoje nje delete fizik mbi bazen e te dhenave per objektin e percaktuar
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool DeleteFizik(T_PHONE_BOOK item)
        {
            bool isDeleted = false;
            if (item != null)
            {
                try
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        
                        db.T_PHONE_BOOK.Remove(item);
                        db.SaveChanges();
                        isDeleted = true;
                    }

                }
                catch (Exception ex)
                {

                    // write logs into file logs
                }

            }

            return isDeleted;
        }
    }

}
