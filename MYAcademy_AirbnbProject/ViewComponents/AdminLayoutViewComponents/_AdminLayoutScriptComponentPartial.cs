using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace MYAcademy_AirbnbProject.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
