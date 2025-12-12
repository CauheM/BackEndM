using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnectMoura.Contexts;
using DevConnectMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevConnectMoura.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _Context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _Context = context;
        }

        [HttpGet]
        public IActionResult Cadastro() 
        {
            TempData["UsuárioNovoCadastrado"] = "";
            ViewBag.UsuárioNovoCadastrado = "";
            return View();
        }
 
        [HttpPost]
        public async Task<IActionResult> Cadastro(IFormCollection form) 
        {
            TbUsuario NovoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form ["Senha"].ToString()

            };

            if (form.Files.Count > 0)
            {
                IFormFile file = form.Files[0];
                String folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                NovoUsuario.FotoPerfilUrl = file.FileName;

            }
            else
            {
                NovoUsuario.FotoPerfilUrl = "Darwin Nunez (1).jpg";
            }

            try
            {
               _Context.TbUsuario.Add(NovoUsuario);
               await _Context.SaveChangesAsync(); 
               TempData["UsuarioNovoCadastrado"] = "Usuario cadastrado com sucesso!";
               ViewBag.UsuqrioNovoCadastrado = "";
               return RedirectToAction("Index", "Home");   
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Erro ao cadastrar usuario!";
                return View();
            }
        }

        public IActionResult TelaPerfil()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        
    }
}