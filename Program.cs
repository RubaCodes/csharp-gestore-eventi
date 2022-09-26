//inizializzaione evento
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
    Evento evento = new Evento(nomeEvento,new DateTime(yyyy,mm,dd), capienza);
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