using System;
using System.Collections.Generic;

namespace faculty.Models;

public partial class Department
{
    public int DId { get; set; }

    public string? Departments { get; set; }

    public virtual ICollection<Facultysurveyform> Facultysurveyforms { get; set; } = new List<Facultysurveyform>();
}
