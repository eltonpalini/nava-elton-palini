using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ServicoGerenciamentoAtividades<T> : IServicoGerenciamentoAtividades<T>
    {
        private readonly List<ListaAtividades<IAtividade>> _listaAtividades;

        public ServicoGerenciamentoAtividades()
        {
            _listaAtividades = new();
        }

        public void Concluir(int id, string nome)
        {
            var atividade = _listaAtividades.FirstOrDefault(f => f.Nome.ToLower() == nome.ToLower())?.Atividades.FirstOrDefault(f => f.Id == id);

            if (atividade != null)
                atividade.EstaConcluida = true;
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

            _listaAtividade.Atividades.Add(atividade);
        }
    }
}
