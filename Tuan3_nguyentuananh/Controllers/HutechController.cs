using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan3_nguyentuananh.Models;
using PagedList;

namespace Tuan3_nguyentuananh.Controllers
{
    public class HutechController : Controller
    {
        // GET: Hutech
       MydataDataContext data = new MydataDataContext();
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var all_sach = (from s in data.Saches select s).OrderBy(m => m.masach);
            int pageSize = 3;
            int pageNum = page ?? 1;
            return View(all_sach.ToPagedList(pageNum, pageSize));
        }
    }
}