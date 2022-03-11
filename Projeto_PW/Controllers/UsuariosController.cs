using Microsoft.AspNetCore.Mvc;
using Projeto_PW.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_PW.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly Contexto db;
        //Classe COnstructor
        public UsuariosController(Contexto banco)
        {
            db = banco;
        }
        public IActionResult Index()
        {
            return View(db.USUARIOS.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuario dadosTela)
        {
            db.USUARIOS.Add(dadosTela);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
