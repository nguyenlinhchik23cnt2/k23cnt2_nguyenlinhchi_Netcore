using System;
using System.Collections.Generic;

namespace Nlc_2310900014.Models;

public partial class NlcEmployee
{
    public int NlcEmpId { get; set; }

    public string? NlcEmpName { get; set; }

    public string? NlcEmpLevel { get; set; }

    public DateTime? NlcEmpStartDate { get; set; }

    public bool? NlcEmpStatus { get; set; }
}
