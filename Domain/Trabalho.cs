
namespace Domain
{
    public class Trabalho : IAtividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EstaConcluida { get; set; } = false;
    }
}
