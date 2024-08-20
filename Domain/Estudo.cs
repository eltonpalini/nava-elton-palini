
namespace Domain
{
    public class Estudo : IAtividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EstaConcluida { get; set; } = false;
    }
}
