using Microsoft.EntityFrameworkCore;
using DaiKhoa_DotNetCore.Models.Domain;

namespace DaiKhoa_DotNetCore.Data
{
    public class RazorPagesDB : DbContext
    {
        public RazorPagesDB(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
