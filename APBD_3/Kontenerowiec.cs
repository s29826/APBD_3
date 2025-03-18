namespace APBD_3;

public class Kontenerowiec
{
    private List<Kontener> _kontenery = new List<Kontener>();
    private int _maxSpeed;
    private int _maxLiczbaKontenerów;
    private int _maxLadownosc;

    public Kontenerowiec(int maxSpeed, int maxLiczbaKontenerów, int maxLadownosc)
    {
        _maxSpeed = maxSpeed;
        _maxLiczbaKontenerów = maxLiczbaKontenerów;
        _maxLadownosc = maxLadownosc;
    }

    public void ZaladujKontener(Kontener kontener)
    {
        _kontenery.Add(kontener);
    }

    public void UsunKontener(Kontener kontener)
    {
        _kontenery.Remove(kontener);
    }

    public void ZamianaKontenera(string poprzednik, Kontener nastepnik)
    {
        int index = _kontenery.FindIndex(i => i.NumerSeryjny == poprzednik);
        _kontenery[index] = nastepnik;
    }

    public void PrzeniesienieKontenera(Kontener kontener, Kontenerowiec kontenerowiec)
    {
        UsunKontener(kontener);
        kontenerowiec.ZaladujKontener(kontener);
    }

    public override string ToString()
    {
        return "Prędkość maksymalna statku: " + _maxSpeed +
               ", Maksymalna liczba kontenerów do zabrania oraz ładowność: " + _maxLiczbaKontenerów + ", " +
               _maxLadownosc + ". Ładunek kontenerowca: " + String.Join(", ", _kontenery);
    }
}