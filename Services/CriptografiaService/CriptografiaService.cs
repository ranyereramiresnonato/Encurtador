namespace Encurtador.Services.CriptografiaService
{
    public class CriptografiaService : ICriptografiaService
    {
        public string GerarSenhaBCrypt(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
    }
}
