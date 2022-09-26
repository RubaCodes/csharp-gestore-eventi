
public class ProgrammaEventi {
    public string Titolo { get; set; }
    public List<Evento> eventi;

     public ProgrammaEventi(string titolo) {
        Titolo = titolo;
        eventi = new List<Evento>();
    }
    public void AggiungiEvento(Evento evento) {
        eventi.Add(evento);
    }
    public List<Evento> EventiInData(string data)
    {
        string[] dataEsplosa = data.Split('/');
        int dd = Convert.ToInt32(dataEsplosa[0]);
        int mm = Convert.ToInt32(dataEsplosa[1]);
        int yyyy = Convert.ToInt32(dataEsplosa[2]);
        DateTime dataSentinella = new DateTime(yyyy, mm, dd);

        List<Evento> risultati = eventi.FindAll(e => e.Data == dataSentinella);
        return risultati;
    }

    public static void PrintList(List<Evento> listaEventi) {
        Console.WriteLine("Informazioni lista eventi");
        foreach (Evento evento in listaEventi)
        {
            Console.WriteLine(evento.ToString());
        }
    }

}