using Microsoft.AspNetCore.Mvc;
using Parcelhubweb.Models;

namespace Parcelhubwebsite.Controllers
{
    public class ParcelController : Controller
    {
        public IActionResult Pickup()
        {
            return View();
        }

        public IActionResult DropOff()
        {
            return View();
        }

        public IActionResult AddParcel()
        {
            return View();
        }

        public IActionResult RemoveParcel()
        {
            return View();
        }

        // ✅ Pick Up Success Method
        public IActionResult PickUpSuccess(string tracking)
        {
            if (string.IsNullOrEmpty(tracking))
            {
                return RedirectToAction("Pickup"); // Redirect back if no tracking number is provided
            }

            ViewBag.TrackingNumber = tracking;
            return View();
        }

        // ✅ Drop Off Success Method
        public IActionResult DropOffSuccess(string tracking, string sender, string receiver, string weight, string size, string company, string location)
        {
            ViewBag.TrackingNumber = tracking;
            ViewBag.Sender = sender;
            ViewBag.Receiver = receiver;
            ViewBag.Weight = weight;
            ViewBag.Size = size;
            ViewBag.Company = company;
            ViewBag.Location = location;

            return View();
        }

        // ✅ Add Parcel Success Method
        public IActionResult AddParcelSuccess(string tracking, string sender, string receiver, string company)
        {
            ViewBag.TrackingNumber = tracking;
            ViewBag.Sender = sender;
            ViewBag.Receiver = receiver;
            ViewBag.Company = company;

            return View();
        }

        public ActionResult ParcelCalculator()
        {
            return View();
        }

        // POST action for ParcelCalculator
        [HttpPost]
        public ActionResult ParcelCalculator(double Weight, string Size)
        {
            var model = new ParcelCalculatorModel
            {
                Weight = Weight,
                Size = Size
            };

            model.CalculatePrice(); // Ensure your model has this method

            return View(model);
        }
    }
}