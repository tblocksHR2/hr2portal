//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR2.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomizeStatusCode : HR2.EF.DAL.IEFEntity
    {
        public int CustomizeStatusCodeId { get; set; }
        public string MainStatusCode { get; set; }
        public string CustomStatusCode { get; set; }
    }
}