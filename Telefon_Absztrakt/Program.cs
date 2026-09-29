namespace Telefon_Absztrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon t1 = new NormalTelefon(1, new List<string>() { "Hívás"}, 100, 30);
            Console.WriteLine($"{t1.ar} Ft \n{string.Join(",", t1.tudja)} \n{((NormalTelefon)t1).meddigbirja()} %");

            Console.WriteLine(t1.tud("SMS")? "Tud sms-ezni" : "Nem tud sms-ezni");


            OkosTelefon o1 = new OkosTelefon(200000, new List<string>() { "Hívás", "SMS", "Bluetooth", "WiFi" }, 3000, 1700, "IOS");
            Console.WriteLine($"{o1.ar} Ft \n{string.Join(",", o1.tudja)} \n{o1.meddigbirja()} %");
            Console.WriteLine(o1.Telepitheto("Android")? "Telepíthető" : "Nem telepíthető");
        }
    }
}
