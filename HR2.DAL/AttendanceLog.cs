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
    
    public partial class AttendanceLog : HR2.EF.DAL.IEFEntity
    {
        public int AttendanceLogId { get; set; }
        public System.DateTime AttendanceDate { get; set; }
        public int EmployeeId { get; set; }
        public string InTime { get; set; }
        public string InDeviceId { get; set; }
        public string OutTime { get; set; }
        public string OutDeviceId { get; set; }
        public double Duration { get; set; }
        public int LateBy { get; set; }
        public int EarlyBy { get; set; }
        public int IsOnLeave { get; set; }
        public Nullable<int> LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public Nullable<double> LeaveDuration { get; set; }
        public Nullable<double> LeaveStatus { get; set; }
        public string LeaveRemarks { get; set; }
        public int IsonSpecialOff { get; set; }
        public string SpecialOffType { get; set; }
        public string SpecialOffRemark { get; set; }
        public Nullable<int> SpecialOffDuration { get; set; }
        public int WeeklyOff { get; set; }
        public int Holiday { get; set; }
        public string PunchRecords { get; set; }
        public string PunchDirections { get; set; }
        public string PunchDevicesName { get; set; }
        public int ShiftId { get; set; }
        public double Present { get; set; }
        public double Absent { get; set; }
        public string DetailedStatus { get; set; }
        public string Status { get; set; }
        public string DetailedStatusCode { get; set; }
        public string StatusCode { get; set; }
        public string P1Status { get; set; }
        public string P2Status { get; set; }
        public string P3Status { get; set; }
        public int OverTime { get; set; }
        public int OverTimeE { get; set; }
        public int MissedOutPunch { get; set; }
        public Nullable<int> MissedInPunch { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> IsOnRestrictedHoliday { get; set; }
        public Nullable<int> IsOnCompOff { get; set; }
        public Nullable<int> IsPartialDay { get; set; }
        public string ReportPunchRecords { get; set; }
        public Nullable<int> SMSFlag { get; set; }
        public Nullable<double> CompOff { get; set; }
        public string ApplicableSession { get; set; }
        public Nullable<int> LateByAdjustment { get; set; }
        public Nullable<int> EarlyByAdjustment { get; set; }
        public Nullable<int> LateComEarlygoingAdjustment { get; set; }
    }
}