using System;

namespace btgTest
{
    public interface IGerenciadorAtividades 
    {
        void AdicionarAtividade(Lista lista, Atividade atividade);
        void ConcluirAtividade(Lista lista, int id);   
    }
}