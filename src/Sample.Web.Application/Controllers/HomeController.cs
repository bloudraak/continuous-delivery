using System.Web.Mvc;

namespace Sample.Web.Application.Controllers
{
    /// <summary>
    ///     Represents the default controller in the application
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        ///     The default method for this controller
        /// </summary>
        /// <returns>
        ///     An instance of <see cref="ViewResult" />
        /// </returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}