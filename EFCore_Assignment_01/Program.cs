using EFCore_Assignment_01.Contexts;

namespace EFCore_Assignment_01;

internal class Program
{
    static void Main(string[] args)
    {
        using AppDbContext db = new AppDbContext();
    }
}
