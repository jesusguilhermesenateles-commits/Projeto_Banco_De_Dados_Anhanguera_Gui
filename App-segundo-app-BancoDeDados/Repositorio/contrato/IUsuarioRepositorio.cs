using App_segundo_app_BancoDeDados.Models;

namespace App_segundo_app_BancoDeDados.Repositorio.contrato
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> ObterTodosUsuarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int Id);

        void Excluir(int Id);
    }
}
