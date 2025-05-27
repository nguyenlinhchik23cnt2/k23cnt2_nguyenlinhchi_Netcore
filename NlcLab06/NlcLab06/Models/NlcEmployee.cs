namespace NlcLab06.Models
{
    public class NlcEmployee
    {
        public int NlcId { get; set; }            // Mã nhân viên nội bộ
         
        public string NlcName { get; set; }
        public DateTime NlcBirthDay { get; set; }
        public string NlcEmail { get; set; }
        public string NlcPhone { get; set; }
        public decimal NlcSalary { get; set; }
        public string NlcStatus { get; set; }

    }

}
