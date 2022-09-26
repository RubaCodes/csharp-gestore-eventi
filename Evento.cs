// See https://aka.ms/new-console-template for more information
public class Evento {
    public string Titolo { 
        get {
            return Titolo;
        } 
        set {
            if (Titolo == "") {
                throw new EmptyTitle("Il Titolo inserito non puo' essere vuoto");
            }
            Titolo = value;
        } 
    }
    public DateTime Data {
        get {
            return Data;
        }
        set {
            if (Data < DateTime.Now) {
                throw new DateExeption("La data deve essere successiva al data odierna");
            }
            Data = value;
        } 
    }

    public int PostiPrenotati {get; private set;}
    public int CapienzaMax
    { 
        get {
            return CapienzaMax;
            } 
        private set {
            if (CapienzaMax < 1) {
                throw new CapienzaMin("La Capienza massima dell' evento deve essere maggiore di 0"); 
            }
            CapienzaMax = value;
        } 
    }

    public Evento(string title,DateTime data, int capienza) {

            Titolo = title;
            Data = data;
            CapienzaMax = capienza;
            PostiPrenotati = 0;
    }
}


/*
 * Eccezioni
 */
public class EmptyTitle : Exception {
    public EmptyTitle(string message) : base(message) { }
}
public class CapienzaMin : Exception
{
    public CapienzaMin(string message) : base(message) { }
}
public class DateExeption : Exception
{
    public DateExeption(string message) : base(message) { }
}
