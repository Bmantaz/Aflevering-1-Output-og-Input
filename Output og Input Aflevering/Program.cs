
namespace Output_og_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Brug af Console.WriteLine() - udskriver med linjeskift
            Console.WriteLine("Hej! Velkommen til Bjarkes 10 spørgsmål");

            Console.WriteLine("Tryk på space-tasten for at fortsætte...");

            //tast indtil space-tasten er trykket
            while (true)
            {
                // Vent på et tastetryk
                var key = Console.ReadKey(true);

                // Hvis det er space-tasten, kører koden videre
                if (key.Key == ConsoleKey.Spacebar)
                {
                    break;
                }
            }

            Console.WriteLine("Du trykkede på space-tasten!");
            Console.WriteLine("Lad os komme igang!");

            Console.WriteLine("Hvad hedder du? ");
            String navn = Console.ReadLine(); // Læser brugerens svar

            Console.WriteLine("Hvor gammel er du " + navn + "? ");
            String alder = Console.ReadLine();

            Console.WriteLine("Hvilken vej bor du på, " + navn + " på " + alder + "? ");
            String vej = Console.ReadLine();

            // Brug af Console.Write() - udskriver uden linjeskift
            Console.Write("nummer? ");
            string nummer = Console.ReadLine();

            Console.WriteLine("Så du hedder " + navn + " Du er " + alder + " og bor på " + vej + " nr " + nummer + "?");

            Console.WriteLine("Jeg vil gerne vide lidt mere om dig");

            Console.WriteLine("Hvad hedder din mor? ");
            String mor = Console.ReadLine();

            Console.WriteLine("okay, så din mor hedder " + mor + "");
            Console.Write("Hvad med din far? ");
            String far = Console.ReadLine();

            Console.WriteLine("Så din mor hedder " + mor + " og din far hedder " + far + ".");

            Console.WriteLine("Jeg vil gerne vide lidt mere om dig");
            Console.WriteLine("Hvad er din yndlingsfarve?");
            string farve = Console.ReadLine();

            Console.WriteLine("sjovt " + farve + " er også min yndlingsfarve");

            Console.WriteLine("Ejer du et instrument?");
            String guitar = Console.ReadLine();

            Console.WriteLine("Sejt! Jeg er bare et chat vindue så jeg kan ikke eje " + guitar + " desværre");



            Console.WriteLine("Her til slut vil jeg forsøge at stille dig et ja/nej spørgsmål, med flere udfald!");
            Console.WriteLine("Jeg vil gerne vide, om du har et kæledyr. ");

            
            Console.Write("Lad os finde ud af det sammen! ");

            
            Console.WriteLine("Har du et kæledyr? (ja/nej): ");
            string svar = Console.ReadLine(); 

            
            if (svar.ToLower() == "ja")
            {
                Console.WriteLine("Det lyder fantastisk! Hvad slags kæledyr har du?");
                string kæledyr = Console.ReadLine(); 
                Console.WriteLine("Så du har " + kæledyr + ". Det er super! ");
            }
            else if (svar.ToLower() == "nej")
            {
                Console.WriteLine("Ingen kæledyr? Det er helt i orden!");
            }
            else
            {
                Console.WriteLine("Jeg er ikke sikker på, hvad du mener. Skriv 'ja' eller 'nej'.");
            }
            // Brug af Console.ReadKey() - venter på, at brugeren trykker på en tast
            Console.WriteLine("Tak for at dele! Tryk på en vilkårlig tast for at afslutte.");
            Console.ReadKey(); // Venter på en tast



        }
    }
}
