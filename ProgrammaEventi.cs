





/*
 * Eccezioni
 */
/*
 * eccezioni sui metodi
 */
public class ProgrammaEventi {
    public string Titolo { get; set; }
    public List<Evento> eventi;

     public ProgrammaEventi(string titolo) {
        Titolo = titolo;
        eventi = new List<Evento>();
    }
}