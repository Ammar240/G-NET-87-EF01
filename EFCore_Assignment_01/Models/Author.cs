using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Assignment_01.Models;

internal class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string ShortBiography { get; set; }
    public DateOnly DateOfBirth { get; set; }

}
