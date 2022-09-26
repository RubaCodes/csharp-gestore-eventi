
public class ProgrammaEventi {
    /*
     * GETTER SETTER
     */
    private string Titolo { get;  set; }
    private List<Evento> eventi;

    /*
     * METODI
     */
     public ProgrammaEventi(string titolo) {
        Titolo = titolo;
        eventi = new List<Evento>();
    }
    public void AggiungiEvento(Evento evento) {
        eventi.Add(evento);
    }
    public List<Evento> EventiInData(string data)
    {
        DateTime dataSentinella = Evento.StringToDate(data);

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

    public int ConteggioEventi() {
        return this.eventi.Count;
        // oppure fatta a mano
        int count = 0;
        foreach (Evento evento in this.eventi) {
            count++;
        }
        return count;
    }
    public void SvuotaLista() {
        //eventi.Clear();
        //oppure fatta a mano
        int size = this.eventi.Count;
        for (int i = 0; i < size; i++)
        {
            this.eventi.RemoveRange(0, size - 1);
        }
    }
    public string  InfoProgrammi()
    {
        Console.WriteLine("Informazioni programma eventi");
        string risultato = "";
        foreach (Evento evento in this.eventi)
        {
            risultato += evento.ToString();
            risultato += '\n';
        }
        return risultato;
    }

}