using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Absztrakt
{
    public class OkosTelefon : NormalTelefon
    {
        public int os;

        public OkosTelefon(int ar, List<string> tudja, int maxtoltottseg, int aktualistoltottseg, int os) : base(ar, tudja, maxtoltottseg, aktualistoltottseg)
        {
            this.os = os;
        }
    }
}
