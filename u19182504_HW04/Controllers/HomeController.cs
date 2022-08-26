using System;
using System.Web.Mvc;
using u19182504_HW04.myModels;

namespace u19182504_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DataInput()
        {
            ViewBag.Message = "Collect citizen information";

            return View();
        }
        [HttpPost]
        public ActionResult DataInput(FormCollection form)
        {
            string citizenType = Request["typeList"];
            string firstname = Request["fname"];
            string lastname = Request["lname"];
            string idNum = Request["IDplaceholder"];
            string city = Request["CityPlaceHolder"];
            string dist = Request["schoolDistance"];


            if (citizenType == "Scholar(16+)")
            {
                Scholar scholar = new Scholar();
                scholar._citizenType = citizenType;
                scholar._firstName = firstname;
                scholar._lastName = lastname;
                scholar._nationalID = Convert.ToInt32(idNum);
                scholar._distance = Convert.ToInt32(dist);
                scholar._city = city;
                if (scholar._distance < 5)
                {
                    scholar._transportType = "Cycling";
                }
                else if (scholar._distance > 5 & scholar._distance < 10)
                {
                    scholar._transportType = "Bus";
                }
                else if (scholar._distance > 10 & scholar._distance < 20)
                {
                    scholar._transportType = "Train";
                }
                scholar.travelID();
                //string msg = scholar.citizenIdentity();
                ListRepository.Scholars.Add(scholar);
                return View("Scholar", scholar);
            }

            else if (citizenType == "Workforce")
            {
                Workforce worker = new Workforce();
                worker._citizenType = citizenType;
                worker._firstName = firstname;
                worker._lastName = lastname;
                worker._nationalID = Convert.ToInt32(idNum);
                worker._distance = Convert.ToInt32(dist);
                worker._city = city;
                if (worker._distance < 5)
                {
                    worker._transportType = "Cycling";
                }
                else if(worker._distance > 5 & worker._distance < 10)
                {
                    worker._transportType = "Bus";
                }
                else if(worker._distance > 10 & worker._distance < 20)
                {
                    worker._transportType = "Train";
                }
                worker.travelID();
                ListRepository.Labourers.Add(worker);
                return View("Workforce", worker);
            }
            else if (citizenType == "Elder")
            {
                Elder oldman = new Elder();
                oldman._citizenType = citizenType;
                oldman._firstName = firstname;
                oldman._lastName = lastname;
                oldman._nationalID = Convert.ToInt32(idNum);
                ListRepository.Elders.Add(oldman);
                return View("Elder");
            }
                ViewBag.Message = "Collect citizen information";

                return View();
        }
            public ActionResult Scholar(Scholar scholar)
            {
                ViewBag.Message = "Scholar information";
                
                return View(scholar);
            }

            public ActionResult Workforce(Workforce workforce)
            {
                ViewBag.Message = "Worker information";

                return View();
            }

            public ActionResult Elder()
            {
                ViewBag.Message = "Elder information";

                return View();
            }
            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
    }