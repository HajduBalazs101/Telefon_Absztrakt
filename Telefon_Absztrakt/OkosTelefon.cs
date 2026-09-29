using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Absztrakt
{
    public class OkosTelefon : NormalTelefon
    {
        public string OS;

        public OkosTelefon(int ar, List<string> tudja, int maxtoltottseg, int aktualistoltottseg, string OS) : base(ar, tudja, maxtoltottseg, aktualistoltottseg)
        {
            this.OS = OS;
            this.tudja.Add("Internet");
        }
        public bool Telepitheto(string OS)
        {
            return this.OS.Equals(OS);
        }
    }
}
