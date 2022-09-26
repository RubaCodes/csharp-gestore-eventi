//inizializzaione evento
using System;

Console.WriteLine("Inserire nome dell'evento:");
string nomeEvento = Console.ReadLine();
Console.WriteLine("Inserire la data dell'evento (gg/mm/yyyy):");
string dataEvento = Console.ReadLine();
Console.WriteLine("Inserire il numero di posti dell'evento:");
int capienza = Convert.ToInt32(Console.ReadLine());

//manipolazione data
string[] dataEsplosa = dataEvento.Split('/');
int dd = Convert.ToInt32(dataEsplosa[0]);
int mm = Convert.ToInt32(dataEsplosa[1]);
int yyyy = Convert.ToInt32(dataEsplosa[2]);

try
{
    Evento evento = new Evento(nomeEvento, new DateTime(yyyy, mm, dd), capienza);
    Console.WriteLine("Quanti posti vuoi prenotare?");
    int postiDaPrenotare = Convert.ToInt32(Console.ReadLine());
    evento.PrenotaPosti(postiDaPrenotare);
    Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
    Console.WriteLine("Numero di Posti liberi: " + evento.PostiLiberi());
    bool continua = true;
    while (continua) {
        Console.WriteLine("Vuoi disdire dei posti ? (si/no)");
        string risposta = Console.ReadLine();
        switch (risposta) {
            case "si":
                Console.WriteLine("Indica il numero di posti da disdire:");
                int postiDaDisdire = Convert.ToInt32(Console.ReadLine());
                evento.DisdiciPosti(postiDaDisdire);
                Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
                Console.WriteLine("Numero di Posti liberi: " + evento.PostiLiberi());
                break;
            case "no":
                Console.WriteLine("Ok va bene!");
                Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
                Console.WriteLine("Numero di Posti liberi: " + evento.PostiLiberi());
                continua = false;
                break;
        }
    }
    /*
     *  TEST CERCA EVENTI PER DATA, FUNZIONA
     */
    Evento evento2 = new Evento("nome", new DateTime(2023,12,12),200);
    ProgrammaEventi programma = new ProgrammaEventi("Nuovo Programma");
    programma.AggiungiEvento(evento);
    programma.AggiungiEvento(evento2);
    List<Evento> risultati = programma.EventiInData("12/12/2023");
    //test print statico, funziona
    ProgrammaEventi.PrintList(risultati);
    Console.WriteLine(programma.ConteggioEventi());
    programma.SvuotaLista();
    Console.WriteLine(programma.ConteggioEventi());

}
catch (CapienzaMin e)
{
    Console.WriteLine(e.Message);
}
catch (EmptyTitle e)
{
    Console.WriteLine(e.Message);
}
catch (DateExeption e)
{
    Console.WriteLine(e.Message);
}
catch (ImpossibilePrenotareException e) {
    Console.WriteLine(e.Message);
}
catch (ImpossibileDisdireException e)
{
    Console.WriteLine(e.Message);
}


