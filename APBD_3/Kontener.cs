namespace APBD_3;

public class Kontener
{
    private int MasaLadunku { get; set; }
    private int Wysokosc { get; set; }
    private int MasaKontenera { get; set; }
    private int Glebokosc { get; set; }
    private string NumerSeryjny { get; set; }
    private char RodzajKontenera { get; set; }
    private int MaxLadownosc { get; set; }

    private static int _counter;

    public Kontener(int masaLadunku, int wysokosc, int masaKontenera, int glebokosc, 
        char rodzajKontenera, int maxLadownosc)
    {
        MasaLadunku = masaLadunku;
        this.Wysokosc = wysokosc;
        MasaKontenera = masaKontenera;
        this.Glebokosc = glebokosc;
        NumerSeryjny = CreateNumerSeryjny();
        RodzajKontenera = rodzajKontenera;
        MaxLadownosc = maxLadownosc;
    }

    private string CreateNumerSeryjny()
    {
        return "KON-" + RodzajKontenera + "-" + _counter++;
    }

    public void OproznijLadunek()
    {
        MasaLadunku = 0;
    }

    public void ZaladujKonterer()
    {
        if (MasaLadunku > MaxLadownosc)
        {
        }
    }
}