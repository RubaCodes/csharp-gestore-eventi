
public class Evento {
    private string _titolo ;
    private DateTime _data ;
    private int _capienzaMax;

    /*
    * Setter / Getter
    */
    public string Titolo { 
        get {
            return this._titolo;
        } 
        set {
            this._titolo = value;
        } 
    }
    public DateTime Data {
        get {
            return _data;
        }
        set {

            _data = value;
        } 
    }

    public int PostiPrenotati {get; private set;}
    public int CapienzaMax
    { 
        get {
            return _capienzaMax;
            } 
        private set {

            _capienzaMax = value;
        } 
    }
    /*
     * Costruttore
     */
    public Evento(string title, DateTime data, int capienza) {
            if (title == "")
            {
                throw new EmptyTitle("Il Titolo inserito non puo' essere vuoto");
            }
            Titolo = title;
            if (data < DateTime.Now)
            {
                throw new DateExeption("La data deve essere successiva al data odierna");
            }
            Data = data;
            if (capienza < 1)
            {
                throw new CapienzaMin("La Capienza massima dell' evento deve essere maggiore di 0");
            }
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

    public int PostiLiberi() {
        return CapienzaMax - PostiPrenotati;
    }
    public override string ToString()
    {
        string data = Data.ToString("dd/MM/yyyy");
        return $"{data} - {this.Titolo} ";
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