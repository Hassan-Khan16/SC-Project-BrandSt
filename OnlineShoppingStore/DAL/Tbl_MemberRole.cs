//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoppingStore.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_MemberRole
    {
        public int MemberRoleID { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> MemberId { get; set; }
    
        public virtual Tbl_Members Tbl_Members { get; set; }
        public virtual Tbl_Roles Tbl_Roles { get; set; }
    }
}
