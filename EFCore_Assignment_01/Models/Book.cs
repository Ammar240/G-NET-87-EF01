using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Assignment_01.Models;

internal class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int ISPN { get; set; }
    public int NumberOfPages { get; set; }
    public int Year { get; set; }
    public bool InStock { get; set; }
    public Category Category { get; set; }
}
