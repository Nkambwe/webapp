using Microsoft.AspNetCore.Mvc;

namespace App.Controllers {
    public class NextController : Controller {

        public IActionResult Index() {
            return View();
        }

        public IActionResult LoadView(string partialName) {
            return new PartialViewResult {
                ViewName = partialName
            };
        }

        public IActionResult LoadPageView(string partialName) {
            return new PartialViewResult {
                ViewName = partialName
            };
        }
    }
}
