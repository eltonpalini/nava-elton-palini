using Domain;

namespace Application
{
    public class ServicoGerenciamentoAtividades<T> : IServicoGerenciamentoAtividades<T>
    {
        private readonly List<ListaAtividades<IAtividade>> _listaAtividades;

        public ServicoGerenciamentoAtividades()
        {
            _listaAtividades = new();
        }

        public IAtividade Concluir(int id, string nome)
        {
            var atividade = _listaAtividades.FirstOrDefault(f => f.Nome.ToLower() == nome.ToLower())?.Atividades.FirstOrDefault(f => f.Id == id);

            if (atividade != null)
            {
                atividade.EstaConcluida = true;
                return atividade;
            }
            else
                throw new Exception("Nome da atividade não localizada");
            
        }

        public List<ListaAtividades<IAtividade>> ExibirListas()
        {
            return _listaAtividades;
        }

        public void Adicionar(IAtividade atividade)
        {
            var nomeAtividade = atividade.GetType().Name;
            var _listaAtividade = _listaAtividades.FirstOrDefault(f => f.Nome == nomeAtividade);

            if (_listaAtividade is null)
            {
                _listaAtividade = new() { Nome = nomeAtividade };
                _listaAtividades.Add(_listaAtividade);
            }

            _listaAtividade.Adicionar(atividade);
        }
    }
}
