﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Esercitazione
{
    internal class Docente : Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Eta { get; set; }
        public bool Collegato { get; set; }

        public void RivelazionePresenze()
        {
            throw new NotImplementedException();
        }
    }
}
