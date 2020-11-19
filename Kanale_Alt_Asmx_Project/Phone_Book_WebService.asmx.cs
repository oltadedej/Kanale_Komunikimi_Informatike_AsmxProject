using Kanale_Alt_Asmx_Project.Models;
using Phone_Book_Core;
using Phone_Book_Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Kanale_Alt_Asmx_Project
{
    /// <summary>
    /// Summary description for Phone_Book_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Phone_Book_WebService : System.Web.Services.WebService
    {
        private readonly PhoneBookService service = new PhoneBookService();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public bool ConnectedDb()
        {
            return service.Connected();
        }


        [WebMethod]
        public PhoneBookModel GetByID(long id)
        {
            //return service.Connected();

            return new PhoneBookModel();
        }

    }
}
