namespace APBD_3;

public class KontenerGaz : Kontener, IHazardNotifier
{
    private int _cisnienie;
    
    public KontenerGaz(int masaLadunku, int wysokosc, int masaKontenera, int glebokosc, char rodzajKontenera, int maxLadownosc, int cisnienie) : base(masaLadunku, wysokosc, masaKontenera, glebokosc, rodzajKontenera, maxLadownosc)
    {
        _cisnienie = cisnienie;
    }

    public override void OproznijLadunek()
    {
        MasaLadunku = (int)(MasaLadunku * 0.05);
    }

    public void Danger(string numer)
    {
        Console.WriteLine("Niebezpieczna sytuacja, kontener: " + numer);
    }
    
    
}