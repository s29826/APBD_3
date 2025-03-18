namespace APBD_3;

public class Kontener
{
    protected int MasaLadunku { get; set; }
    private int Wysokosc { get; set; }
    private int MasaKontenera { get; set; }
    private int Glebokosc { get; set; }
    private char RodzajKontenera { get; set; }
    public string NumerSeryjny { get; set; }
    protected int MaxLadownosc { get; set; }
    
    private static int _counter = 1;

    public Kontener(int masaLadunku, int wysokosc, int masaKontenera, int glebokosc, 
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

    protected string CreateNumerSeryjny()
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
        return "Masa ładunku: " + MasaLadunku + ", numer seryjny: "
               + NumerSeryjny + " i rodzaj kontenera: " +
               RodzajKontenera;
    }
    
}