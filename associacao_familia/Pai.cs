using System;
using System.Collections.Generic;

namespace associacao_familia
{
    public class Pai
    {
        public string nome { get; set; }
        public string idade { get; set; }

        public List<Filhos> listaFilhos = new List<Filhos>();


        public Pai()
        {
        }
    }
}
