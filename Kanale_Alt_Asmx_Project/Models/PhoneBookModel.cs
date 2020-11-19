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
        
    }
}