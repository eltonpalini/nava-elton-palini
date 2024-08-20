
namespace Domain
{
    public interface IAtividade
    {
        int Id { get; set; }
        string Nome { get; set; }
        bool EstaConcluida { get; set; }
    }
}
