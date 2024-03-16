using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LocationController1cs : Controller
    {
        private readonly Se1708Context _context;
        public LocationController1cs(Se1708Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult QuanHuyenList(int LocationId)
        {
            var QuanHuyens = _context.Locations.OrderBy(x=>x.LocationId)
                .Where(x=> x.ParentCode == LocationId && x.Levels ==2)
                .OrderBy(x=>x.Name)
                .ToList();
            return Json(QuanHuyens);                           
                ;
        }
        public ActionResult PhuongXaList(int LocationId)
        {
            var PhuongXas = _context.Locations.OrderBy(x => x.LocationId)
                .Where(x => x.ParentCode == LocationId && x.Levels == 3)
                .OrderBy(x => x.Name)
                .ToList();
            return Json(PhuongXas);
            ;
        }
    }
}
