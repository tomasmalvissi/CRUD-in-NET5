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

        public IActionResult Create()
        {
            return View();
        }
    }
}
