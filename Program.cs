
//inizializzaione evento
try
{
    Evento evento = new Evento();
}
catch (CapienzaMin e)
{
    Console.WriteLine(e.Message);
}
catch (EmptyTitle e)
{
    Console.WriteLine(e.Message);
}
catch (DateExeption e) {
    Console.WriteLine(e.Message);
}