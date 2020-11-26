using Phone_Book_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanale_Alt_Asmx_Project.Models
{
    [Serializable]
    public class PhoneBookModel
    {

        public long? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? IdPhoneType { get; set; }
        public DateTime?  DeletedDate { get; set; }
        public DateTime?  ModifiedDate { get; set; }
        public DateTime?  InsertedDate { get; set; }
        public string  Number { get; set; }




        public void Fill(T_PHONE_BOOK itemtoFill)
        {
            itemtoFill.NAME = this.Name;
            itemtoFill.SURNAME = this.Surname;
            itemtoFill.ID_PHONE_TYPE = this.IdPhoneType;
            itemtoFill.NUMBER = this.Number;

        }


        public void Preselect(T_PHONE_BOOK item)
        {
            if (item != null)
            {
                this.Name = item.NAME;
                this.Surname = item.SURNAME;
                this.IdPhoneType = item.ID_PHONE_TYPE;
                this.Number = item.NUMBER;
            }
        }
        
    }
}