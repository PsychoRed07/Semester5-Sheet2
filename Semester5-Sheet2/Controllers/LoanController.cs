using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semester5_Sheet2.Views
{
    public class LoanController : Controller
    {
        // GET: Loan
        public ActionResult Loan()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Loan(double? intinv,double? intrate, double? years)
        {
            ViewData["intinv"] = intinv;
            ViewData["intrate"] = intrate;
            ViewData["years"] = years;

            double? inv = intinv;

            if (intinv == null && intrate == null && years == null)
            {
            }
            else
            {
                if (ViewData["intinv"] != null)
                {
                    if (ViewData["intrate"] != null)
                    {
                        if (ViewData["years"] != null)
                        {

                            for (int i = 0; i < years; i++)
                            {

                                inv += inv * (intrate / 100);

                            }
                            ViewData["inv"] = "Given " +years+ " years, an investment of $"+intinv+", and an annual investement of " +intrate+ "%, you wiil have "+ Convert.ToDecimal(inv).ToString("C");
                        }
                        else
                        {
                            ViewData["inv"] = "Invalid years";
                        }
                    }
                    else
                    {
                        ViewData["inv"] = "Invalid Interest rate";
                    }
                }
                else
                {
                    ViewData["inv"] = "Invalid Initial Investement";
                }
            }

            return View();

        }
    }
}