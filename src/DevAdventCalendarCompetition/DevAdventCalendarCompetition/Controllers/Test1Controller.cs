﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DevAdventCalendarCompetition.Models;
using DevAdventCalendarCompetition.Data;

namespace DevAdventCalendarCompetition.Controllers
{
    public class Test1Controller: BaseTestController
    {
        public Test1Controller(ApplicationDbContext context) : base(context)
        {
        }

        [CanStartTest(TestNumber = 1)]
        public ActionResult Index()
        {
            var test = _context.Tests.FirstOrDefault(el => el.Number == 1);
            return View(test);
        }

        [HttpPost]
        [CanStartTest(TestNumber = 1)]
        public ActionResult Index(string answer = "")
        {
            var fixedAnswer = answer.ToUpper().Replace(" ", "");

            if (fixedAnswer != "0100111101000010010010100100010101000011010101000100100101010110010010010101010001011001")
            {
                ModelState.AddModelError("", "Answer is not correct. Try again.");
                var test = _context.Tests.First(el => el.Number == 1);
                return View("Index", test);
            }

            return SaveAnswerAndRedirect(1);
        }
    }
}