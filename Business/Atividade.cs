using System.Collections.Generic;

namespace btgTest
{
    public class Lista{

        public string Nome { get ; set; }
        public List<Atividade> Atividade { get ; set; } 
    }

    public class Atividade : IAtividade {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool EstaConcluida { get ; set; }
    }
}

