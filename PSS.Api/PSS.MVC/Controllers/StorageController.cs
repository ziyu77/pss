using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web;
using System.Web.Mvc;

namespace PSS.MVC.Controllers
{
    public class StorageController : Controller
    {
        // GET: Storage
        public ActionResult Purchase()
        {//采购订单查询
            return View();
        }
        public ActionResult PurchaseAdd()
        {//添加采购订单
            return View();
        }

        public ActionResult shoppage() {
            //商家模式窗口
            return View();
        }

        public ActionResult edit()
        {
            //修改模式窗口
            return View();
        }
    }
}