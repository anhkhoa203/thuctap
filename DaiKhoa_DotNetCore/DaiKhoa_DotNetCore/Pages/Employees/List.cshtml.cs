using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DaiKhoa_DotNetCore.Data;

namespace DaiKhoa_DotNetCore.Pages.Employees
{
    [Authorize(Policy = "AdminOnly")]
    public class ListModel : PageModel
    {
        private readonly RazorPagesDB dBcontext;
        public List<Models.Domain.Employee> Employees { get; set; }
        public ListModel(RazorPagesDB DBcontext)
        {
            this.dBcontext = DBcontext;
        }
        public void OnGet()
        {
            Employees = dBcontext.Employees.ToList();
        }
    }
}
