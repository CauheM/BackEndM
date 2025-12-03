using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    public class Escola : Controller
    {
        private readonly ILogger<Escola> _logger;

        public static List<Aluno> ListadeAluno = new List<Aluno>
        {
            new Aluno{ID = 1, Nome = "Ronaldo", Nota = 7}
        };
        public Escola(ILogger<Escola> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
             return View();
        }

        [HttpPost]
        public IActionResult Salvar(Aluno alunocadastrado)
        {
          alunocadastrado.ID = ListadeAluno.Max(f => f.ID) + 1;

          ListadeAluno.Add(alunocadastrado);

          return RedirectToAction(nameof (Listar));
        }
        public IActionResult Listar()
        {
            ViewBag.alunos = ListadeAluno;
            return View();
        }
           
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}