using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Teoria
{
    internal class Veicolo : IVeicolo
    {

        private static int count = 0;

        public static int Count { get { return count; } }


        public static void ShowMessage(string s)
        {
            Console.WriteLine(s);
        }
        public void AddVeicolo(Veicolo obj)
        {
            count++;
        }

        public string Marca { get; set; }
        public void AccendiMotore() { }
        private void metodo01() { }

        internal void metodo02() { }

        public void metodo03() { }

        protected void metodo04() { }
    }
}
