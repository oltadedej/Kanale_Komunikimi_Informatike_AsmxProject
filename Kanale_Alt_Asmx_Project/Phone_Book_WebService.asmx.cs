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
            PhoneBookModel model = new PhoneBookModel();

            model.Preselect(service.GetById(id));

            return model;
        }


        [WebMethod]
        public string Save(PhoneBookModel model)
        {
            T_PHONE_BOOK item = new T_PHONE_BOOK();

            model.Fill(item);

            if(model != null)
            {
                if (service.Save(item))
                {
                    return "Elementi u shtua me sukses";

                }
                else
                {
                    return "Probleme gjate shtimit";
                }
            }

            else
            {
                return "Specifikoni nje objekt te vlefshem";
            }
            
        }

        [WebMethod]
        public string Put(PhoneBookModel model)
        {
            if (model != null && model.Id.HasValue)
            {

                //Test2
                T_PHONE_BOOK item = service.GetById(model.Id.Value);

                if (item != null)
                { 
                    //Test4 --> Test2-->Test4
                    model.Fill(item);
                
                    if (service.Put(item))
                    {
                        return "Elementi u modifikua me sukses";

                    }
                    else
                    {
                        return "Probleme gjate modifikimie";
                    }
                }
                else
                {
                    return "Elementi nuk u gjet ne bazen e te dhenave";
                }
              
            }

            else
            {
                return "Specifikoni nje objekt te vlefshem";
            }

        }

        [WebMethod]
        public string Delete (long id)
        {
            if (id > 0)
            {
                T_PHONE_BOOK item = service.GetById(id);
                if (item != null)
                {
                    if (service.Delete(item))
                    {
                        return "Elementi u fshi me sukses";
                    }
                    else
                    {
                        return "Probleme gjate fshirjes";
                    }
                }
                else
                {
                    return "Elementi nuk u gjet ne bazen e te dhenave";
                }
            }
            else
            {
                return "Specifikoni nje id te vleshfshme";
            }
        }


    }
}
