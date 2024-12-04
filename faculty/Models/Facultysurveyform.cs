using System;
using System.Collections.Generic;

namespace faculty.Models;

public partial class Facultysurveyform
{
    public int FId { get; set; }

    public string? FName { get; set; }

    public int? FNumber { get; set; }

    public int? Dept { get; set; }

    public string? Designation { get; set; }

    public DateOnly? Dateofjoining { get; set; }

    public virtual Department? DeptNavigation { get; set; }
}
