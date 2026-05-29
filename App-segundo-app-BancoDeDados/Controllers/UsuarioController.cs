using App_segundo_app_BancoDeDados.Models;
using App_segundo_app_BancoDeDados.Repositorio;
using App_segundo_app_BancoDeDados.Repositorio.contrato;
using Microsoft.AspNetCore.Mvc;

namespace App_segundo_app_BancoDeDados.Controllers
{
    public class UsuarioController : Controller
    {

        private IUsuarioRepositorio _usuarioRepository;

        public UsuarioController(IUsuarioRepositorio usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            return View(_usuarioRepository.ObterTodosUsuarios());
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
                _usuarioRepository.Cadastrar(usuario);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            return View(_usuarioRepository.ObterUsuario(id));
        }
        [HttpPost]
        public IActionResult Atualizar(Usuario usuario)
        {
            return View();
        }
        

    }
}
