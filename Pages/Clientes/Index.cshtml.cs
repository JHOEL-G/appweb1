using appweb1.Data;
using appweb1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _ctx;
        public IndexModel(AppDbContext ctx)
        {
            _ctx=ctx;
        }
        public List<Clinete> Clinetes { get; set; }

        public void OnGet()
        {
            Clinetes = _ctx.clientes.ToList();
        }
    }
}
