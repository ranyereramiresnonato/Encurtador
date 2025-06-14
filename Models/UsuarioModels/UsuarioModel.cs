namespace Encurtador.Models.Usuario
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }

        public UsuarioModel()
        {
            login = string.Empty;
            senha = string.Empty;
            nome = string.Empty;
        }
    }
}
