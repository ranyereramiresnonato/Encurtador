namespace Encurtador.DTO.Usuario
{
    public class UsuarioAlteracaoNomeDTO : UsuarioAcessoDTO
    {
        public string novoNome {  get; set; }

        public UsuarioAlteracaoNomeDTO()
        {
            novoNome = string.Empty;
        }
    }
}
