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
    
    public partial class EmployeesBio : HR2.EF.DAL.IEFEntity
    {
        public int EmployeeBioId { get; set; }
        public string EmployeeCodeInDevice { get; set; }
        public string EmployeeName { get; set; }
        public int Privilege { get; set; }
        public int BioVersion { get; set; }
        public int BioId { get; set; }
        public string Bio { get; set; }
        public string BioPassword { get; set; }
        public string CardNumber { get; set; }
        public Nullable<int> DeviceId { get; set; }
        public Nullable<int> RFIDIssuedNoOfTimes { get; set; }
    }
}