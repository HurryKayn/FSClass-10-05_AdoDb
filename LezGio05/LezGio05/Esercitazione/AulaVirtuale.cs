using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Esercitazione
{
    public enum eSesso {  None = 0, Maschio =2, Femmina = 3,Altro =4 }
    
    class ErroreConnessione : Exception
    {
        public ErroreConnessione() { }
        public ErroreConnessione(string nome) : base("errore connessione alunno" + nome) { }
    }
    
    public class AulaVirtuale
    {
        private static AulaVirtuale Aula { get; }
        static AulaVirtuale()
        {
            if (Aula == null)Aula = new AulaVirtuale();
        }
        public static Alunno IngressoAlunno(string name)
        {
            try
            {
                Alunno alunno = new Alunno();
                alunno.FirstName = name;
                alunno.Eta = new Random().Next(19, 35);
                int i = new Random().Next(1, 4);
                alunno.Sesso = (eSesso)i;

                i = new Random().Next();
                if (i % 2 == 0)
                {

                }
                else { throw new ErroreConnessione(alunno.FirstName); }
                return alunno;
            }
            catch(Exception e)
            {
                fileLogo[Count] = e.Message;
                Count++;
            }
            return null;

        }
        public static void uscitaAlunno(string name)
        {
            
        }
    }
}
}
