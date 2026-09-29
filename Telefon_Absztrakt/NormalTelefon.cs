using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Absztrakt
{
    public class NormalTelefon : Telefon
    {
        public int maxtoltottseg;
        public int aktualistoltottseg;
        public NormalTelefon(int ar, List<string> tudja, int maxtoltottseg, int aktualistoltottseg) : base(ar, tudja)
        {
            this.maxtoltottseg = maxtoltottseg;
            this.aktualistoltottseg = aktualistoltottseg;
        }
        public int meddigbirja()
        {
            return (int)(((double)aktualistoltottseg) / maxtoltottseg * 100);
        }
    }
}
