using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace btgTest
{
    public class GerenciadorAtividades : IGerenciadorAtividades {
        
        public void Run(){

        }

        public void AdicionarAtividade(Lista lista, Atividade atividade){
            lista.Atividade.Add(atividade);   

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(lista, options);

            Console.WriteLine(jsonString);
        }

        public void ConcluirAtividade(Lista lista, int id){
            lista.Atividade.FirstOrDefault(x=> x.Id == id).EstaConcluida = true;

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(lista, options);

            Console.WriteLine(jsonString);
        }
    }
}