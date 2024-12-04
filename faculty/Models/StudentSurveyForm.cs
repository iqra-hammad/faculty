using System;
using System.Collections.Generic;

namespace faculty.Models;

public partial class StudentSurveyForm
{
    public int SId { get; set; }

    public string? SName { get; set; }

    public int? Rollnumber { get; set; }

    public int? Specification { get; set; }

    public int? Class { get; set; }

    public string? Section { get; set; }

    public DateOnly? Dateofadmission { get; set; }

    public virtual Class? ClassNavigation { get; set; }

    public virtual Specification? SpecificationNavigation { get; set; }
}
