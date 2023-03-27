using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensj_InfoTest
{
    abstract class mensj_Canditato
    {
        private int mensj_matricola;
        private string mensj_nome;

        public int Matricola
        {
            set { mensj_matricola = value; }
            get { return mensj_matricola; }
        }
        public string Nome
        {
            set { mensj_nome = value; }
            get { return mensj_nome; }
        }
        public mensj_Canditato()
        {
            Matricola = 0;
            Nome = "N/A";
        }
        public mensj_Canditato(int m)
        {
            Matricola = m;
            Nome = "N/A";
        }
        public mensj_Canditato(string n)
        {
            Nome = n;
            Matricola = 0;
        }
        public mensj_Canditato(int m, string n)
        {
            Matricola = m;
            Nome = n;
        }
        public bool isIdoneo()
        {
            return true;
        }
        public int punteggio()
        {
            return 0;
        }

    }
}
