namespace Encurtador.DTO.Usuario
{
    public class UsuarioAlteracaoSenhaDTO : UsuarioAcessoDTO
    {
        public string novaSenha {  get; set; }

        public UsuarioAlteracaoSenhaDTO()
        {
            novaSenha = string.Empty;
        }
    }
}
