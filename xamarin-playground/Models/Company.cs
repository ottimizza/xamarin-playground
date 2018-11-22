using System;
using System.Collections.Generic;
using System.Text;

namespace status_report.Models
{
    class Company
    {
        private string externalId { get; set; }
        private string name { get; set; }
        private string alias { get; set; }
        private string erpCode { get; set; }
        private string status { get; set; }
        private string closingDate { get; set; }
        private string accountant { get; set; }
        private string team { get; set; }
        private DateTime statusReportDate { get; set; }
        private string statusReportDescription { get; set; }
        private DateTime nextStepDate { get; set; }
        private string nextStepDescription { get; set; }
    }
}
