using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezGio05.Esercitazione
{
    internal interface IDocente
    {
        public bool RivelaionePresenze {  get; set; }
    }

    public class Docente : Persona, IDocente
    {
        public bool RivelaionePresenze { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
