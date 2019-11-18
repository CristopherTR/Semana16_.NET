using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Semana16.Models;

namespace Semana16.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autorizacion(Semana16.Models.Usuario usuarioModel)
        {
            using (DBSemana16Entities db = new DBSemana16Entities()) 
            {
                var userDetails = db.Usuarios.Where(x => x.UsuarioNom == usuarioModel.UsuarioNom && x.UsuarioContraseña == usuarioModel.UsuarioContraseña).FirstOrDefault();
                if(userDetails == null)
                {
                    usuarioModel.LoginErrorMensaje = "Escriba el usuario y la contraseña";
                    return View("Index",usuarioModel);
                }
                else{
                    Session["usuarioID"] = userDetails.UsuarioID;
                    Session["usuarioNom"] = userDetails.UsuarioNom;
                    return RedirectToAction("Index", "Inicio");
                }
            }
        }
        public ActionResult CerrarSesion()
        {
            int usuId = (int)Session["usuarioID"];
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}