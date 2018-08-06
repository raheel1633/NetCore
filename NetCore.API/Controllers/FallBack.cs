using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.API.Controllers
{
    public class FallBack : Controller
    {
        public IActionResult Index() {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory()
            ,"wwwroot","Index.html"),"text/HTML");
        }
    }
}