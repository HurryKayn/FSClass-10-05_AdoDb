using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Teoria
{
    enum GiornoSettimana
    {
        Lunedi,
        Martedi,
        Mercoledi,
        Giovedi,
        Venerdi,
        Sabato,
        Domenica

    }
    internal class Agenda
    {
        GiornoSettimana oggi;

        public Agenda()
        {
            oggi = GiornoSettimana.Lunedi;
            var numeroGiornoSettimana = (int)oggi;
            GiornoSettimana diNuovoOggi = (GiornoSettimana)numeroGiornoSettimana;


        }

    }
}
