using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mensj_InfoTest
{
    public partial class Form1 : Form
    {
        public List<mensj_Canditato> lista;
        public Form1()
        {
            InitializeComponent();
            lista = new List<mensj_Canditato>();
        }
        public void Aggiungi(mensj_Canditato c)
        {
            if( c != null )
                lista.Add(c);
        }
        public string[] Visualizzazione()
        {
            string[] righe = {};
            for( int i = 0; i < lista.Count; i++ )

                righe[i] = lista[i].ToString();

            return righe;
        }
        public string Modifica(mensj_Canditato n,int matricolaV)
        {
            if ( n != null )
            {
                for ( int i = 0; i < lista.Count; i++ )
                {
                    if ( lista[i].Matricola == matricolaV )
                    { 
                        n.Matricola = matricolaV;
                        lista[i] = n;
                        return "Candidato modificato";
                    }
                }
                return "Candidato non trovato";
            }
            else
                throw new Exception("il candidato non esiste");
        }
        public void Elimina(int matricola)
        {
            for ( int i = 0; i < lista.Count; i++ )
            {
                if ( lista[i].Matricola == matricola )
                
                    lista.Remove(lista[i]);
                             
            }
      
        }
        public string[] VisuaIdonei()
        {
            string[] righe = { };
            for ( int i = 0; i < lista.Count; i++ )
            {
                if ( lista[i].isIdoneo() == true )

                    righe[i] = lista[i].ToString();
            }
            return righe;
        }
        public void sortD()
        {
            lista.Sort();
            lista.Reverse();
        }
    }
}
