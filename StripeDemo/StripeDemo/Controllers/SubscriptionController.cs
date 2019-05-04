using Microsoft.AspNetCore.Mvc;

namespace StripeDemo.Controllers {
    public class SubscriptionController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}