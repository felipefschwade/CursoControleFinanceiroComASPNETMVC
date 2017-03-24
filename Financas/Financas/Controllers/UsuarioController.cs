using Financas.DAO;
using Financas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financas.Controllers
{
    public class UsuarioController : Controller
    {
        public UsuarioController(UsuarioDAO dao)
        {
            this.Dao = dao;
        }

        public UsuarioDAO Dao { get; private set; }

        // GET: Usuario
        public ActionResult Index()
        {
            return View(Dao.ListaTodos());
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario Usuario)
        {
            if (ModelState.IsValid)
            {
                Dao.Adiciona(Usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", Usuario);
            }
        }

    }
}