using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PSS.Api.Models;

namespace PSS.Api.Controllers
{
    public class StorageController : ApiController
    {
        PSSEntities db = new PSSEntities();

        public IHttpActionResult Get(string StockID, string PPID, int StockState)
        {//多条件查询
            StockID = StockID ?? "";
            PPID = PPID ?? "";

            var st = db.Stocks
                .Where(s => StockID == "" || s.StockID.Contains(StockID))
                .Where(s => PPID == "" || s.PPID.Contains(PPID))
                //.Where(s => StockUser == 0 || s.StockUser == StockUser)
                .Where(s => StockState == 0 || s.StockState == StockState)
                .Select(s => new {
                    s.StockID,
                    s.PPID,
                    s.StockDate,
                    s.StockInDate,
                    s.StockUser,
                    s.StockState,
                    s.StockDesc
                });
            return Json(st);
        }//多条件查询

        public IHttpActionResult Put(Stocks sk) {

            db.Entry<Stocks>(sk).State = System.Data.EntityState.Modified;
            return Ok(db.SaveChanges());

        }

        public IHttpActionResult Get()
        {
            var st = db.ProductLend.Select(s => new
            {
                s.PPID,
                s.PPName,
                s.PPCompany,
                s.PPMan,
                s.PPTel,
                s.PPAddress
            });
            return Json(st);
        }//供应商查询

        public IHttpActionResult Delete(string id)
        {
            using (PSSEntities db = new PSSEntities())
            {
                var st = db.Stocks.Find(id);
                db.Stocks.Remove(st);
                return Ok(db.SaveChanges());
            }
        }//删除

        public void Options()
        {

        }
    }
}
