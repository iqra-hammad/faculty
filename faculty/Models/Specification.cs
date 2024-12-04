using System;
using System.Collections.Generic;

namespace faculty.Models;

public partial class Specification
{
    public int SId { get; set; }

    public string? SName { get; set; }

    public virtual ICollection<StudentSurveyForm> StudentSurveyForms { get; set; } = new List<StudentSurveyForm>();
}
