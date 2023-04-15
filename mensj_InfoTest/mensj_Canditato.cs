using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensj_InfoTest
{
    public abstract class mensj_Canditato:IComparable<mensj_Canditato>,IEquatable<mensj_Canditato>
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
        public abstract bool isIdoneo();


        public abstract int punteggio();

        public override string ToString()
        {
            return Matricola.ToString() + ";" + Nome;
        }
        public bool Equals(mensj_Canditato c)
        {
            if( c == null ) return false;
            if ( this == c ) return true;

            return this.Matricola == c.Matricola && this.Nome == c.Nome;
        }

        public override bool Equals(object obj)
        {
            if( !(obj is mensj_Canditato) )
                return false;
               
            if( obj==null ) return false;

            return this.Equals(obj);
        }
        public int CompareTo(mensj_Canditato c)
        {
            return this.punteggio().CompareTo(c.punteggio());
        }
        public override int GetHashCode() => (Matricola, Nome).GetHashCode();
    }
}
