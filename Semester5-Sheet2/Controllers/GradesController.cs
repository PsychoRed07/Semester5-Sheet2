using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semester5_Sheet2.Views
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Grades()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Grades(int? t1, int? t2, int? t3)
        {

            ViewData["t1"] = t1;
            ViewData["t2"] = t2;
            ViewData["t3"] = t3;

            int? final = t1;

            if (t1 == null && t2 == null && t3 == null)
            {
            }
            else
            {
                if (ViewData["t1"] != null)
                {
                    if (ViewData["t2"] != null)
                    {
                        if (ViewData["t3"] != null)
                        {

                            final = (t1 + t2 + t3) / 3;

                            if (final < 60)
                            {
                                ViewData["final"] = "F";
                                ViewData["Color"] = "style=color:red;";
                            }
                            else if (final < 70)
                            {
                                ViewData["final"] = "D";
                                ViewData["Color"] = "style=color:red;";
                            }
                            else if (final < 80)
                            {
                                ViewData["final"] = "C";
                                ViewData["Color"] = "style=color:yellow;";
                            }
                            else if (final < 90)
                            {
                                ViewData["final"] = "B";
                                ViewData["Color"] = "style=color:green;";
                            }
                            else if (final <= 100)
                            {
                                ViewData["final"] = "A";
                                ViewData["Color"] = "style=color:green;";
                            }
                            else {
                                ViewData["final"] = "Invalid Data Entry";
                            }

                            ViewData["grade"] = "Grade : ";
                        }
                        else
                        {
                            ViewData["final"] = "Invalid Test 3";
                        }
                    }
                    else
                    {
                        ViewData["final"] = "Invalid Test 2";
                    }
                }
                else
                {
                    ViewData["final"] = "Invalid Test 1";
                }
            }


            return View();
        }
    }
}