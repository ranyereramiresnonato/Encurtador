namespace Encurtador.DTO.Usuario
{
    public class UsuarioAlteracaoLoginDTO : UsuarioAcessoDTO
    {
        public string novoLogin {  get; set; }

        public UsuarioAlteracaoLoginDTO()
        {
            novoLogin = string.Empty;
        }
    }
}
