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
    
    public partial class SaleReturn
    {
        public string SRID { get; set; }
        public string CusID { get; set; }
        public string DepotID { get; set; }
        public Nullable<System.DateTime> SRDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SRState { get; set; }
        public string SRDesc { get; set; }
    }
}
