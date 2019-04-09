using System;
using System.Collections.Generic;
using System.Text;

namespace Chohuatl.MenuItems
{
    public class CPregunta
    {
        public int clave { get; set; }
        public string pregunta { get; set; }

        public CPregunta(int cve, string pregunta1)
        {
            clave = cve;
            pregunta = pregunta1;
        }
    }
}
