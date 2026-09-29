namespace Telefon_Absztrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon t1 = new NormalTelefon(1, new List<string>() { "Hívás"}, 100, 30);
            Console.WriteLine($"{t1.ar} Ft \n{string.Join(",", t1.tudja)} \n{((NormalTelefon)t1).meddigbirja()} %");

            Console.WriteLine(t1.tud("SMS")? "Tud sms-ezni" : "Nem tud sms-ezni");
        }
    }
}
