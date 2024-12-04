using System;
using System.Collections.Generic;

namespace faculty.Models;

public partial class Contactform
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Usercontactnumber { get; set; }

    public string? Useremail { get; set; }

    public string? Message { get; set; }
}
