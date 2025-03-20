namespace APBD_3;

public class Kontenerowiec(int maxSpeed, int maxLiczbaKontenerów, int maxLadownosc)
{
    private List<Kontener> _kontenery = new();

    public void ZaladujKontener(Kontener kontener)
    {
        if (_kontenery.Count >= maxLiczbaKontenerów)
        {
            Console.WriteLine("Maksymalna liczba kontenerów osiągnięta!");
            return;
        }

        if (ObecnaMasaZaladowana() + kontener.MasaKontenera + kontener.MasaLadunku > maxLadownosc * 1000)
        {
            Console.WriteLine("Maksymalna ładowość osiągnięta!");
            return;
        }

        _kontenery.Add(kontener);
    }

    public void ZaladujKontener(List<Kontener> kontener)
    {
        foreach (Kontener k in kontener)
        {
            ZaladujKontener(k);
        }
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

    private int ObecnaMasaZaladowana()
    {
        return _kontenery.Sum(k => k.MasaKontenera + k.MasaLadunku);
    }

    public override string ToString()
    {
        string str = "";
        foreach (Kontener k in _kontenery)
        {
            if (str.Length > 0)
            {
                str += ", ";
            }
            str += k.NumerSeryjny;
        }

        return "Prędkość maksymalna statku: " + maxSpeed +
               "; Maksymalna liczba kontenerów do zabrania: " + maxLiczbaKontenerów + "; Maksymalna ładowność: " +
               maxLadownosc + "t. Ładunek kontenerowca: " + str;
    }
}