
namespace Domain
{
    public class Lazer : IAtividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EstaConcluida { get; set; } = false;
    }
}
