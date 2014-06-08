using Entities;
using PagedList;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            const int pageSize = 20;

            var unitOfWork = new UnitOfWork();

            int totalCustomerCount;

            var customers =
                unitOfWork.Repository<Customers>()
                    .Query()
                    .Include(i => i.CustomerDemographics)
                    .OrderBy(q => q
                        .OrderBy(c => c.ContactName)
                        .ThenBy(c => c.CompanyName))
                    .Filter(q => q.ContactName != null)
                    .GetPage(pageNumber, pageSize, out totalCustomerCount);

            ViewBag.Customers = new StaticPagedList<Customers>(
                customers, pageNumber, pageSize, totalCustomerCount);

            unitOfWork.Save();

            return View();
        }
    }
}