using Microsoft.AspNetCore.Mvc;

namespace Nlclesson04.Models
{
    public class NlcBook
    {
        public string NlcId { get; set; }
        public string NlcTitle { get; set; }
        public string NlcDescription { get; set; }
        public string NlcImage {  get; set; }
        public float NlcPrice { get; set; }
        public int NlcPage {  get; set; }
    }
}
