using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using web_dat_phong_khach_san.Models;

namespace web_dat_phong_khach_san.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLKSDataContext _db = new QLKSDataContext("Data Source=COMPUTEROFLONG;Initial Catalog=QL_KHACHSAN;Integrated Security=True");

        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult DatPhong(DATPHONG_WEB obj)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _db.DATPHONG_WEBs.InsertOnSubmit(obj);
                    _db.SubmitChanges();

                    TempData["success"] = "Đặt phòng thành công";
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "Có lỗi xảy ra: " + ex.Message;
                    TempData["error"] = "Đặt phòng thất bại";
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Thông tin không hợp lệ.";
            }

            return RedirectToAction("Index");
        }

    }
}