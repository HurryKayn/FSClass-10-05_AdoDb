using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Esercitazione
{

 
    public class Alunno:Persona,IAlunno
    {
        private bool presenza = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Eta { get; set; }
        public bool Collegato { get; set; }

        public eSesso Sesso { get; set; }

        public bool Presenza
        {
            get { return presenza; }
            set { presenza = value; }
        }
        public void IngressoAlunno(int i,string name)
        {
            if (i % 2 == 0)
            {
                presenza = true;
                Console.WriteLine("Alunno" + i + "e' entrato");

            }
            else
                Console.WriteLine("Alunno" + i + " errore");
          
        }

        public void UscitaAlunno()
        {
            presenza = false;
        }
    }
}
