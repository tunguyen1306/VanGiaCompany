//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebVanGia.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSysUserRoleGroup
    {
        public long group_role_id { get; set; }
        public string group_role_name { get; set; }
        public string group_role_description { get; set; }
        public System.DateTime group_role_create { get; set; }
        public Nullable<long> group_role_parent { get; set; }
        public Nullable<int> group_role_type { get; set; }
        public long update_by { get; set; }
        public long create_by { get; set; }
        public int id_company { get; set; }
        public Nullable<int> group_role_status { get; set; }
        public Nullable<int> id_page { get; set; }
    }
}
