namespace APBD_3;

public class KontenerPlyny : Kontener, IHazardNotifier
{
    private bool _czyNiebezpieczny;
    
    public KontenerPlyny(int masaLadunku, int wysokosc, int masaKontenera, int glebokosc, char rodzajKontenera,
        int maxLadownosc, bool czyNiebezpieczny)
        : base(masaLadunku, wysokosc, masaKontenera, glebokosc, rodzajKontenera, maxLadownosc)
    {
        _czyNiebezpieczny = czyNiebezpieczny;
    }

    public override void ZaladujKonterer()
    {
        if (_czyNiebezpieczny && MasaLadunku <= MaxLadownosc * 0.5)
        {

        } 
        else if (!_czyNiebezpieczny && MasaLadunku <= MaxLadownosc * 0.9)
        {
            
        } 
        else
        {
            Danger(NumerSeryjny);
        }
    }

    public void Danger(string numer)
    {
        Console.WriteLine("Niebezpieczna sytuacja, kontener: " + numer);
    }
}