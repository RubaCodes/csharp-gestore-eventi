//inizializzaione programma eventi
Console.WriteLine("Inserisci il nome del tuo programma Eventi:");
string nomeProgramma = Console.ReadLine();
Console.WriteLine("Indica il numero di eventi da inserire:");
int numeroEventi = Convert.ToInt32(Console.ReadLine());
//
ProgrammaEventi programma = new ProgrammaEventi(nomeProgramma);

int currentSize = 0;
while(currentSize < numeroEventi)
{
    try { 
    Console.WriteLine($"Inserire nome del {currentSize+1} evento:");
    string nomeEvento = Console.ReadLine();
    Console.WriteLine("Inserire la data dell'evento (gg/mm/yyyy):");
    string dataEvento = Console.ReadLine();
    Console.WriteLine("Inserire il numero di posti dell'evento:");
    int capienza = Convert.ToInt32(Console.ReadLine());

    Evento evento = new Evento(nomeEvento, Evento.StringToDate(dataEvento), capienza);
    programma.AggiungiEvento(evento);
        currentSize++;
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
    catch (ImpossibilePrenotareException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (ImpossibileDisdireException e)
    {
        Console.WriteLine(e.Message);
    }

    //Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
}

Console.WriteLine("Il numero di eventi in programma e' " + programma.ConteggioEventi());
Console.WriteLine("Ecco il tuo programma eventi");
Console.WriteLine(programma.InfoProgrammi());
//stampa con metodo statico della lista di risultati
Console.WriteLine("\n" + "Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy)");
string dataRicerca = Console.ReadLine();
//gestione lista vuota
if (programma.EventiInData(dataRicerca).Count == 0)
{
    Console.WriteLine("Nessun evento previsto per il giorno " + dataRicerca);
}
else {
    ProgrammaEventi.PrintList(programma.EventiInData(dataRicerca));
}
//svuotamento della lista
//programma.SvuotaLista();

/*
 * BONUS CONFERENZA
 */
Console.WriteLine('\n'+ "---- BONUS ----"  + '\n');
Console.WriteLine("Aggiungiamo anche una conferenza");
//campi di input
Console.WriteLine("Inserisci il nome della conferenza");
string nomeConferenza = Console.ReadLine();
Console.WriteLine("Inserisci la data della conferenza");
string dataConferenza = Console.ReadLine();
Console.WriteLine("Inserisci il numero di posti della conferenza");
int postiConferenza = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci il nome del relatore della conferenza");
string nomeRelatore = Console.ReadLine();
Console.WriteLine("Inserisci prezzo della conferenza");
double prezzoConferenza = Convert.ToDouble(Console.ReadLine());
try
{
    Conferenza nuovaConferenza = new Conferenza(nomeConferenza, Evento.StringToDate(dataConferenza), postiConferenza, nomeRelatore, prezzoConferenza);
    programma.AggiungiEvento(nuovaConferenza);
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
catch (ImpossibilePrenotareException e)
{
    Console.WriteLine(e.Message);
}
catch (ImpossibileDisdireException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPriceException e) {
    Console.WriteLine(e.Message);
}
catch (InvalidRelatoreException e)
{
    Console.WriteLine(e.Message);
}
//
Console.WriteLine(programma.InfoProgrammi());

//stampa con metodo statico della lista di risultati
//gestione lista vuota

//svuotamento della lista
/*
 *  MILESTONE 2
 */
//try
//{
//Console.WriteLine("Inserire nome dell'evento:");
//string nomeEvento = Console.ReadLine();
//Console.WriteLine("Inserire la data dell'evento (gg/mm/yyyy):");
//string dataEvento = Console.ReadLine();
//Console.WriteLine("Inserire il numero di posti dell'evento:");
//int capienza = Convert.ToInt32(Console.ReadLine());

////manipolazione data
//string[] dataEsplosa = dataEvento.Split('/');
//int dd = Convert.ToInt32(dataEsplosa[0]);
//int mm = Convert.ToInt32(dataEsplosa[1]);
//int yyyy = Convert.ToInt32(dataEsplosa[2]);

//Evento evento = new Evento(nomeEvento, new DateTime(yyyy, mm, dd), capienza);
//programma.AggiungiEvento(evento);
//Console.WriteLine("Quanti posti vuoi prenotare?");
//int postiDaPrenotare = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
//Console.WriteLine("Numero di Posti liberi: " + evento.PostiLiberi());
//    bool continua = true;
//    while (continua) {
//        Console.WriteLine("Vuoi disdire dei posti ? (si/no)");
//        string risposta = Console.ReadLine();
//        switch (risposta) {
//            case "si":
//                Console.WriteLine("Indica il numero di posti da disdire:");
//                int postiDaDisdire = Convert.ToInt32(Console.ReadLine());
//                evento.DisdiciPosti(postiDaDisdire);
//                Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
//                Console.WriteLine("Numero di Posti liberi: " + evento.PostiLiberi());
//                break;
//            case "no":
//                Console.WriteLine("Ok va bene!");
//                Console.WriteLine("Numero di Posti prenotati: " + evento.PostiPrenotati);
//                Console.WriteLine("Numero di Posti liberi: " + evento.PostiLiberi());
//                continua = false;
//                break;
//        }
//    }

//}
//catch (CapienzaMin e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (EmptyTitle e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (DateExeption e)
//{
//    Console.WriteLine(e.Message);
//}
//catch (ImpossibilePrenotareException e) {
//    Console.WriteLine(e.Message);
//}
//catch (ImpossibileDisdireException e)
//{
//    Console.WriteLine(e.Message);
//}
