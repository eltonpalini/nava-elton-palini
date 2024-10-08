﻿
namespace Domain
{
    public class ListaAtividades<IAtividade>
    {
        public string Nome { get; set; }
        public List<IAtividade> Atividades { get; set; } = new();


        public void Adicionar(IAtividade item)
        {
            Atividades.Add(item);
        }

        public void Remover(IAtividade item)
        {
            Atividades.Remove(item);
        }

        public List<IAtividade> Listar()
        {
            return Atividades;
        }
    }
}
