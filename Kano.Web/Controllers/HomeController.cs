using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kano.Web.Models;
using DataAccess;
using DataAccess.Model;
using DataAccess.Model.Map;
using System.Reflection.Metadata.Ecma335;

namespace Kano.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        
        public ActionResult GetListData(DataTableModel param)
        {
            
            var options = new ReadOptions();

            options.PageSize = param.Length;
            options.Start = param.Start;
            var service = new ReadCSVToDataTable(options);

            var query = service.Read();

            return Json(new
            {
                sEcho = param.Draw,   
                aaData = query.Data,
                recordsTotal = query.TotalRecord,
                recordsFiltered = query.TotalRecord
            }) ;
        }

        public ActionResult Detail(string id)
        {
            var service = new ReadCSVPerRow(id);
            var data = service.Read();


            return View(data);
        }

        public ActionResult Create()
        {
            Company model = new Company();

            return View(model);
        }

        public ActionResult Update(Company company)
        {

            var service = new UpdateToCSV(company);

            service.Update();


            return RedirectToAction("Detail", "Home", new { id = company.CMGUnmaskedID });
        }

        public ActionResult Save(Company company)
        {
            var service = new WriteToCSV(company);
            if(company.CMGUnmaskedID == null || company.CMGUnmaskedID == string.Empty || company.CMGUnmaskedID == " ")
            {
                return RedirectToAction("Create", "Home");
            }
            var res = service.Insert();


            if(res.Result)
            {
                return RedirectToAction("Detail", "Home", new { id = company.CMGUnmaskedID });
            }else
            {
                return View(company);
            }
            
        }
    }
}
