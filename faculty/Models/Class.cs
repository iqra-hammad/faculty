using System;
using System.Collections.Generic;

namespace faculty.Models;

public partial class Class
{
    public int CId { get; set; }

    public string? Class1 { get; set; }

    public virtual ICollection<StudentSurveyForm> StudentSurveyForms { get; set; } = new List<StudentSurveyForm>();
}
