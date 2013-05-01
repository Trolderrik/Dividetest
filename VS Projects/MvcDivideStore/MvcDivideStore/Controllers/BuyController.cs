using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDivideStore.Controllers
{
    public class BuyController : Controller
    {
        //
        // GET: /Buy/

        public String Index(String something)
        {
            string message = HttpUtility.HtmlEncode("This is buy page " + something);

            return message;
        }

    }
}
