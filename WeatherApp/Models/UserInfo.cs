//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sequencing.WeatherApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInfo
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string AuthToken { get; set; }
        public string RefreshToken { get; set; }
        public Nullable<System.DateTime> AuthDt { get; set; }
    }
}
