using Encurtador.DataBase;
using Encurtador.DTO.Usuario;
using Encurtador.Models.Usuario;
using Encurtador.Repositories.UsuarioRepository;
using Encurtador.Services.CriptografiaService;
using Microsoft.EntityFrameworkCore;

namespace Encurtador.Repositories.UsuarioRepositorie
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;
        private readonly ICriptografiaService _criptografiaService;
        public UsuarioRepository(
            AppDbContext context,
            ICriptografiaService CriptografiaService
            )
        {
            _context = context;
            _criptografiaService = CriptografiaService;
        }

        public async Task Adicionar(UsuarioModel usuario)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.login == usuario.login);
            if (user != null)
                throw new Exception("Login já utilizado por outro usuário.");

            usuario.senha = _criptografiaService.GerarSenhaBCrypt(usuario.senha);
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarLogin(UsuarioAlteracaoLoginDTO usuario)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.login == usuario.login);
            if (user == null)
                throw new Exception("Usuário com login atual não encontrado.");

            var loginExistente = await _context.Usuarios.AnyAsync(x => x.login == usuario.novoLogin);
            if (loginExistente)
                throw new Exception("Novo login já está em uso.");

            user.login = usuario.novoLogin;
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarNome(UsuarioAlteracaoNomeDTO usuario)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.login == usuario.login);
            if (user == null)
                throw new Exception("Usuário com login atual não encontrado.");

            user.nome = usuario.novoNome;
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(string login)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.login == login);
            if(user == null)
                throw new Exception("Usuário com login atual não encontrado.");

            _context.Usuarios.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
