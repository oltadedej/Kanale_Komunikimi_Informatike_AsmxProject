using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book_Core.Service
{
    public class PhoneBookService
    {

     public   bool Connected()
        {

            bool connected = false;
            using (PHONE_BOOK_DBEntities dBEntities = new PHONE_BOOK_DBEntities())
            {

                connected = true;
            }


            return connected;
        }
    }
}
