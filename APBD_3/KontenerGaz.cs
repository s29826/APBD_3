namespace APBD_3;

public class KontenerGaz(
    int masaLadunku,
    int wysokosc,
    int masaKontenera,
    int glebokosc,
    int maxLadownosc,
    int cisnienie)
    : Kontener(masaLadunku, wysokosc, masaKontenera, glebokosc, 'G', maxLadownosc), IHazardNotifier
{
    private int _cisnienie = cisnienie;

    public override void OproznijLadunek()
    {
        MasaLadunku = (int)(MasaLadunku * 0.05);
    }

    public void Danger(string numerSeryjny)
    {
        Console.WriteLine("Niebezpieczna sytuacja, kontener: " + numerSeryjny);
    }
}