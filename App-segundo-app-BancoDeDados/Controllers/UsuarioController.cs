using App_segundo_app_BancoDeDados.Models;
using App_segundo_app_BancoDeDados.Repositorio;
using App_segundo_app_BancoDeDados.Repositorio.contrato;
using Microsoft.AspNetCore.Mvc;

namespace App_segundo_app_BancoDeDados.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController (IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View(_usuarioRepositorio.ObterTodosUsuarios);
        }
        [HttpGet]
        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.Cadastrar(usuario);
                return RedirectToAction("index");
            }
            return View();
        }
    }
}
