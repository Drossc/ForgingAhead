using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ForgingAhead.Models;
using System.Linq;

namespace ForgingAhead.Controllers
{
    public class EquipmentController:Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(Equipment equipment)
        {
            _context.Equipment.Add(equipment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var model = _context.Equipment.ToList();
            return View(model);
        }

        public IActionResult GetActive()
        {
            var model = _context.Equipment.Where(e => e.IsActive).ToList();
            return View(model);
        }

        public IActionResult Details(string name)
        {
            var model = _context.Equipment.FirstOrDefault(e => e.Name == name);
            return View(model);
        }

        public IActionResult Update(Equipment equipment)
        {
            _context.Entry(equipment).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            var original = _context.Equipment.FirstOrDefault(e => e.Name == name);
            if (original != null)
            {
                _context.Equipment.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
