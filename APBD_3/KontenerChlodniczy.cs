namespace APBD_3;

public class KontenerChlodniczy : Kontener
{
    private string _rodzajProduktu;
    private double _temperatura;
    
    public KontenerChlodniczy(int masaLadunku, int wysokosc, int masaKontenera, int glebokosc, char rodzajKontenera,
        int maxLadownosc, string rodzajProduktu, double temperatura)
        : base(masaLadunku, wysokosc, masaKontenera, glebokosc, rodzajKontenera, maxLadownosc)
    {
        _rodzajProduktu = rodzajProduktu;
        _temperatura = temperatura;
    }

    public override void ZaladujKonterer()
    {
        switch (_rodzajProduktu)
        {
            case "Bananas":
                if (_temperatura > 13.3)
                {
                    Console.WriteLine("Nieprawidłowa temperatura!");
                }
                break;
            case "Fish":
                if (_temperatura > 2)
                {
                    Console.WriteLine("Nieprawidłowa temperatura!");
                }
                break;
            case "Frozen Pizza":
                if (_temperatura > -30)
                {
                    Console.WriteLine("Nieprawidłowa temperatura!");
                }
                break;
            case "Butter":
                if (_temperatura > 20.5)
                {
                    Console.WriteLine("Nieprawidłowa temperatura!");
                }
                break;
            case "Eggs":
                if (_temperatura > 19)
                {
                    Console.WriteLine("Nieprawidłowa temperatura!");
                }
                break;
            
        }
    }
}