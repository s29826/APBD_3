namespace APBD_3;

public class Kontener
{
    public int MasaLadunku { get; set; }
    private int Wysokosc { get; set; }
    public int MasaKontenera { get; set; }
    private int Glebokosc { get; set; }
    private char RodzajKontenera { get; set; }
    public string NumerSeryjny { get; set; }
    protected int MaxLadownosc { get; set; }

    private static int _counter = 1;

    protected Kontener(int masaLadunku, int wysokosc, int masaKontenera, int glebokosc,
        char rodzajKontenera, int maxLadownosc)
    {
        MasaLadunku = masaLadunku;
        this.Wysokosc = wysokosc;
        MasaKontenera = masaKontenera;
        this.Glebokosc = glebokosc;
        RodzajKontenera = rodzajKontenera;
        NumerSeryjny = CreateNumerSeryjny();
        MaxLadownosc = maxLadownosc;
    }

    private string CreateNumerSeryjny()
    {
        return "KON-" + RodzajKontenera + "-" + _counter++;
    }

    public virtual void OproznijLadunek()
    {
        MasaLadunku = 0;
    }

    public virtual void ZaladujKonterer()
    {
        if (MasaLadunku > MaxLadownosc)
        {
            throw new OverfillException();
        }
    }

    public override string ToString()
    {
        return "Masa ładunku: " + MasaLadunku + "kg; Maksymalna ładowność: " + MaxLadownosc + "kg; numer seryjny: "
               + NumerSeryjny + " i rodzaj kontenera: " +
               RodzajKontenera;
    }
}