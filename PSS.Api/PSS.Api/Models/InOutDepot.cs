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
    
    public partial class InOutDepot
    {
        public int IODID { get; set; }
        public string DepotID { get; set; }
        public Nullable<int> IODType { get; set; }
        public string IODNum { get; set; }
        public Nullable<System.DateTime> IODDate { get; set; }
        public Nullable<int> IODUser { get; set; }
        public string IODDesc { get; set; }
    }
}
