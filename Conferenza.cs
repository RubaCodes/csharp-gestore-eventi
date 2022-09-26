

public class Conferenza : Evento
{
    private string _relatore;
    private double _prezzo;
    public string Relatore { get; set; }
    public double Prezzo { get; set; }

    public Conferenza(string title, DateTime data, int capienza, string relatore, double prezzo) : base(title, data, capienza) {
        if (relatore == "") {
            throw new InvalidRelatoreException("Il nome del realtore non puo' essere vuoto");
        }
        Relatore = relatore;
        if (prezzo < 1) {
            throw new InvalidPriceException("Il prezzo dell confernza non e' valido");
        }
        Prezzo = prezzo;
    }
    public string prezzoFormattato() {
        return Prezzo.ToString("0.00");
    }
    public string dataFormattata() {
        return Data.ToString("dd/mm/yyyy");
    }
    public override string ToString()
    {
        return $"{base.ToString()} - {this.Relatore} - {this.prezzoFormattato()}$ ";
    }
}

public class InvalidPriceException : Exception {
    public InvalidPriceException(string message) : base(message)
    {
    }
}
public class InvalidRelatoreException : Exception
{
    public InvalidRelatoreException(string message) : base(message)
    {
    }
}