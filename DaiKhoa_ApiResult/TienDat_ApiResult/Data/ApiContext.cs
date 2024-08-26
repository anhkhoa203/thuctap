using Microsoft.EntityFrameworkCore;
using DaiKhoa_ApiResult.Models;
namespace DaiKhoa_ApiResult.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ApiContext(DbContextOptions<ApiContext> optison) : base(optison)
        {

        }
    }
}
