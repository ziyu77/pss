//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckDepot
    {
        public string CDID { get; set; }
        public string DepotID { get; set; }
        public Nullable<System.DateTime> CDDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public string CDDesc { get; set; }
        public Nullable<int> CDState { get; set; }
    }
}
