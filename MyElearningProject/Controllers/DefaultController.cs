﻿using MyElearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyElearningProject.DAL.Entities;

namespace MyElearningProject.Controllers
{
    public class DefaultController : Controller
    {
        ElearningContext context = new ElearningContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult FeaturePartial()
        {
            var values = context.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutMatterPartial()
        {
            var values = context.AboutMatters.ToList();
            return PartialView(values);
        }

        public PartialViewResult CategoryPartial()
        {
            var values = context.Categories.Where(x=>x.Status==true).ToList();
            ViewBag.c1 = context.Courses.Where(x => x.CourseID == 1).Select(y => y.Title).FirstOrDefault();
            ViewBag.c2 = context.Courses.Where(x => x.CourseID == 4).Select(y => y.Title).FirstOrDefault();
            ViewBag.c3 = context.Courses.Where(x => x.CourseID == 5).Select(y => y.Title).FirstOrDefault();
            ViewBag.c4 = context.Courses.Where(x => x.CourseID == 9).Select(y => y.Title).FirstOrDefault();
            return PartialView(values);
        }

        public PartialViewResult CoursePartial()
        {
            var values = context.Courses.ToList();
            return PartialView(values);
        }

        public PartialViewResult InstructorPartial()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }

        public PartialViewResult TestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }

     
        public PartialViewResult SubscribePartial()
        {
            var values = context.Subscribes.ToList();
            return PartialView(values);
        }

      
    }
}