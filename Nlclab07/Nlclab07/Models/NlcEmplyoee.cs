using System;

namespace Nlclab07.Models
{
    public class NlcEmployee
    {
        public int NlcId { get; set; }
        public string NlcName { get; set; }
        public DateTime NlcBirthDay { get; set; }
        public string NlcEmail { get; set; }
        public string NlcPhone { get; set; }
        public decimal NlcSalary { get; set; }
        public bool NlcStatus { get; set; }
    }
}
