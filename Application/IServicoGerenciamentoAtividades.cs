using Domain;

namespace Application
{
    public interface IServicoGerenciamentoAtividades<T>
    {
        void Concluir(int id, string nome);
        List<ListaAtividades<IAtividade>> ExibirListas();
        void Adicionar(IAtividade atividade);
    }
}
