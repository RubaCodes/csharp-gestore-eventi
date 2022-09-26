using System.Runtime.Serialization;

public class Evento {
    /*
    * Setter / Getter
    */
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
    /*
     * Costruttore
     */
    public Evento(string title,DateTime data, int capienza) {

            Titolo = title;
            Data = data;
            CapienzaMax = capienza;
            PostiPrenotati = 0;
    }

    /*
     * Metodi
     */
    public void PrenotaPosti( int posti) {
        if (PostiPrenotati + posti > CapienzaMax || Data < DateTime.Now) {
            throw new ImpossibilePrenotareException("Impossibile Prenotare: L'evento e' terminato o non ci sono piu posti disponibili per la prenotazione");
        }
            PostiPrenotati += posti;
    }
    public void DisdiciPosti(int posti)
    {
        if (PostiPrenotati - posti < 0 || Data < DateTime.Now)
        {
            throw new ImpossibileDisdireException("Impossibile Disdire: L'evento e' terminato o il numero di posti da disdire non e' valido ");
        }
        PostiPrenotati -= posti;
    }
    public override string ToString()
    {
        return $"{Data.ToString("dd/MM/yyyy")} - {Titolo} ";
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
/*
 * eccezioni sui metodi
 */
public class ImpossibilePrenotareException : Exception
{
    public ImpossibilePrenotareException(string message) : base(message) { }
}
public class ImpossibileDisdireException : Exception
{
    public ImpossibileDisdireException(string message) : base(message) { }
}