﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ForgingAhead.Models;
using System.Linq;
using System.Data.SqlClient;

namespace ForgingAhead.Controllers
{
    public class CharacterController:Controller
    {
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Create(Character character)
        {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Characters";
            var model = _context.Characters.ToList();
            return View(model);
        }

        public IActionResult GetActive()
        {
            var model = _context.Characters.Where(e => e.IsActive).ToList();
            return View(model);
        }

        public IActionResult Details(string name)
        {
            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
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
            var original = _context.Characters.FirstOrDefault(e => e.Name == name);
            if (original != null)
            {
                _context.Characters.Remove(original);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string name)
        {
            ViewData["Title"] = "Edit" + name;
            var model = _context.Characters.FirstOrDefault(e => e.Name == name);
            return View(model);
        }
    }
}
