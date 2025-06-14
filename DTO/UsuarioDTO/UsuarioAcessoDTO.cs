namespace Encurtador.DTO.Usuario
{
    public class UsuarioAcessoDTO
    {
        public string login {  get; set; }
        public string senha { get; set; }

        public UsuarioAcessoDTO()
        {
            login = string.Empty;
            senha = string.Empty;
        }
    }
}
