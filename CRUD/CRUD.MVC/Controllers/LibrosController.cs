using CRUD.MVC.Data;
using CRUD.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.MVC.Controllers
{
    public class LibrosController : Controller
    {
        private readonly DataContext _context;
        public LibrosController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> listLibros = _context.Libros;
            return View(listLibros);
        }

        //HTTP GET DEL CREATE PARA MOSTRAR LA VISTA
        public IActionResult Create()
        {
            return View();
        }

        //HTTP POST DEL CREATE PARA CREAR EL LIBRO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();

                TempData["Mensaje"] = "Libro creado con exito.";
                return RedirectToAction("Index");
            }

            return View();
        }

        //HTTP GET DEL EDIT PARA OBETENER EL ID
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libros.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        //HTTP POST DEL EDIT PARA EDITAR EL LIBRO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Update(libro);
                _context.SaveChanges();

                TempData["Mensaje"] = "Libro actualizado con exito.";
                return RedirectToAction("Index");
            }

            return View();
        }

        //HTTP GET DEL DELETE PARA OBETENER EL ID
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var libro = _context.Libros.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }
    }
}
