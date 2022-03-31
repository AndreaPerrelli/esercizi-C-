namespace esempioClasseRiferimento
{
    public class Uomo
    {
        public int età;
        public float temperatura;

        public Uomo()
        {
            età = 18;
            temperatura = 38.5f;
        }
    }

    public class TipoRiferimento
    {
        public TipoRiferimento()
        {

        }
        public static void dimostrazioneClasseRiferimento()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("esempio di manipolazione di un'istanza di una classe assegnata a due variabili diverse");

            
            Uomo mrJekil = new Uomo();
            Uomo mrHyde = mrJekil;

            Console.WriteLine("Mr Jekil ha " + mrJekil.età + " e la sua temperatura corporea è " + mrJekil.temperatura); // output : età = 18, temperatura = 38.5f
            Console.WriteLine("Mr Hyde ha " + mrHyde.età + " e la sua temperatura corporea è " + mrHyde.temperatura); // output : età = 18, temperatura = 38.5f
            Console.WriteLine(Environment.NewLine);

            // quando andiamo a inizializzare le due variabili mrJekil e mrHyde, assegnando a mrHyde la variabile mrJekil, non assegniamo il valore
            // ma il riferimento all'istanza dell'oggetto Uomo creata con l'inizializzazione e assegnazione di mrJekil.
            // Per questo motivo, possiamo vedere che quando andiamo a modificare il valore degli attributi dell'istanza della classe Uomo assegnata a mrJekil,
            // anche i valori relativi agli attributi di mrHyde cambiano di conseguenza.

            mrJekil.età = 20;
            mrJekil.temperatura = 40.5f;

            Console.WriteLine("Passano due anni...");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Mr Jekil ha " + mrJekil.età + " e la sua temperatura corporea è " + mrJekil.temperatura); // output : età = 20, temperatura = 40.5f
            Console.WriteLine("Mr Hyde ha " + mrHyde.età + " e la sua temperatura corporea è " + mrHyde.temperatura); // output : età = 20, temperatura = 40.5f

            // cambiando mrJekil, abbiamo cambiato pure mrHyde, questo poichè una classe è un tipo riferimento e non un tipo valore
        }
        public static void dimostrazioneArrayRiferimento()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("esempio di manipolazione di un array stringa creato all'assegnazione di valore ad una stringa e poi assegnato ad una nuova variabile copia della prima");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Array prima della modifica : ");


            String[] nomiArray = { "luca", "paolo", "michelle" };
            String[] nuoviNomiArray = nomiArray;

            // Quando andiamo a inizializzare le due variabili nomiArray e nuoviNomiArray, creiamo un nuovo array assegnandolo a nomiArray.
            // Successivamente, il valore assegnato a nuoviNomiArray altro non è che una copia per riferimento dell'array nomiArray.
            // Per questo motivo, possiamo vedere che cambiando il valore del primo elemento dell'array nuoviNomiArray, anche il primo elemento
            // dell'array nomiArray cambia di valore, poichè entrambi puntano allo stesso array come riferimento.


            Console.WriteLine(nomiArray[0]);
            Console.WriteLine(nuoviNomiArray[0]);

            nuoviNomiArray[0] = "dario";

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Array dopo la modifica : ");
            Console.WriteLine(nomiArray[0]);
            Console.WriteLine(nuoviNomiArray[0]);
        }
       

    }
}