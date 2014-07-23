using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Promises.Controllers
{
    public class PromiseController : Controller
    {
        // GET: Promise
        public ActionResult Index()
        {
            const bool Paid = false; 
            if (!Paid)
            {
                //delay 1 second...
                Thread.Sleep(1000);
                Debug.WriteLine("why delay? PAY TODAY!"); //couldn't help it.
            }
            var rand = new Random(DateTime.Now.Second);
            if (rand.Next(2) == 1)
            {
                return Json(new
                {
                    title = "Awesome sawse!",
                    locations = new List<string>()
                    {
                        "/Promise/Get/1",
                        "/Promise/Get/2",
                        "/Promise/Get/3",
                        "/Promise/Get/4",
                        "/Promise/Get/5",
                        "/Promise/Get/6",
                        "/Promise/Get/7",
                        "/Promise/Get/8",
                        "/Promise/Get/9"
                    }
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return HttpNotFound();
            }
        }

        private readonly List<string> Contents = new List<string>()
        {
            "Content 1: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 2: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 3: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 4: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 5: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 6: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 7: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 8: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna.",
            "Content 9: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sed lacus justo. Praesent enim quam, elementum vitae mauris id, accumsan accumsan tortor. Nunc pellentesque lorem tortor, sit amet adipiscing justo rhoncus vitae. Etiam rutrum felis vitae mattis adipiscing. Cras dictum erat in lacus bibendum ultrices. Maecenas turpis nulla, imperdiet in pretium vel, gravida eget nisl. Duis libero magna, tincidunt in mollis ut, pulvinar at ante. Integer eget sapien tortor. Maecenas adipiscing nunc non ipsum consectetur, sed congue ligula suscipit. Etiam id eleifend odio. Aenean vitae massa elit. Maecenas lorem nibh, tempus eu turpis non, placerat congue leo. Sed sed ante magna."
        }; 
        public ActionResult Get(int id)
        {
            if (id > 0 && id < Contents.Count)
            {
                // wait any time between 1 and 5 seconds before responding.
                var r = new Random(DateTime.Now.Second);
                Thread.Sleep(r.Next(1000, 5000));

                return Json(Contents[id], JsonRequestBehavior.AllowGet);
            }

            return HttpNotFound();
        }
    }
}