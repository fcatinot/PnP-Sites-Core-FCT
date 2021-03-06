//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficeDevPnP.Core.Tools.UnitTest.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestResult
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestResult()
        {
            this.TestResultMessages = new HashSet<TestResultMessage>();
        }
    
        public int Id { get; set; }
        public string TestCaseName { get; set; }
        public Outcome Outcome { get; set; }
        public System.TimeSpan Duration { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorStackTrace { get; set; }
        public System.DateTimeOffset StartTime { get; set; }
        public System.DateTimeOffset EndTime { get; set; }
        public string ComputerName { get; set; }
        public int TestRunId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestResultMessage> TestResultMessages { get; set; }
        public virtual TestRun TestRun { get; set; }
    }
}
