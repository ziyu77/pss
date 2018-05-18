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

        public IHttpActionResult Get(string StockID, string PPID, int StockUser, int StockState)
        {
            StockID = StockID ?? "";
            PPID = PPID ?? "";
            
            var st = db.Stocks
                .Where(s => StockID =="" || s.StockID.Contains(StockID))
                .Where(s => PPID == "" || s.PPID.Contains(PPID))
                .Where(s => StockUser == 0 || s.StockUser == StockUser)
                .Where(s => StockState == 0 || s.StockState == StockState)
                .Select(s => new{
                    s.StockID,
                    s.PPID,
                    s.StockDate,
                    s.StockInDate,
                    s.StockUser,
                    s.StockState,
                    s.StockDesc
                });
            return Json(st);
        }
    }
}
