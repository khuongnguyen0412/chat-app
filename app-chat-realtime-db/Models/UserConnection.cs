//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app_chat_realtime_db.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserConnection
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.Guid> ConnectionId { get; set; }
    
        public virtual User User { get; set; }
    }
}
