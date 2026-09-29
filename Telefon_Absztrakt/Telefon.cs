using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Absztrakt
{
    public abstract class Telefon
    {
        public int ar;
        public List<string> tudja;

        protected Telefon(int ar, List<string> tudja)
        {
            this.ar = ar;
            this.tudja = tudja;
        }

        public bool tud(string tudas)
        {
            return tudja.Contains(tudas);
        }
    }
}
