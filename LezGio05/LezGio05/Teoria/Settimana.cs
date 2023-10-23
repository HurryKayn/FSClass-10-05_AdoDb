using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Teoria
{

    internal class ErrCustom01 : Exception
    {
        public ErrCustom01() { }
        public ErrCustom01(string message) : base(message) { }
    }

    public class ErrCustom02 : Exception
    {
        public ErrCustom02() { }

    }
    internal class Settimana
    {
        Agenda agenda = null;
        GiornoSettimana oggi;
        public Settimana()
        {
            CalcolaMedia(100, 6);
            CalcolaMedia(150, 6);
            try
            {
                Console.WriteLine("esegue try");
            }
            finally
            {
                Console.WriteLine("esegue finally");
            }

        }
        public object GetAlunnoByName(string name)
        {
            //se non trovo l'alunno
            if (name.Trim() == "")
                throw new ErrCustom01("GinoPippo non è nel db");
            return null;
        }
        public void CalcolaMedia(int importo, int giorni)
        {
            decimal media = 0;
            if (giorni == 0) { throw new ErrCustom01(); }
            try { media = importo / giorni; }
            catch (ErrCustom01 e) { throw; }
            finally { }
            Console.WriteLine(media);

        }

    }
}
