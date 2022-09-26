// See https://aka.ms/new-console-template for more information
public class Evento {
    public string Titolo { get; set; }
    public DateOnly Data { get; set; }

    public int CapienzaMax {get; private set;}
    public int PostiPrenotati { get; private set; }

    public Evento(string title,DateOnly data, int capienza) {
        Titolo = title;
        Data = data;
        CapienzaMax = capienza;
        PostiPrenotati = 0;
    }
}