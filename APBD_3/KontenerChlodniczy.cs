namespace APBD_3;

public class KontenerChlodniczy(
    int masaLadunku,
    int wysokosc,
    int masaKontenera,
    int glebokosc,
    int maxLadownosc,
    string rodzajProduktu,
    double temperatura)
    : Kontener(masaLadunku, wysokosc, masaKontenera, glebokosc, 'C', maxLadownosc)
{
    public override void ZaladujKonterer()
    {
        base.ZaladujKonterer();
        switch (rodzajProduktu)
        {
            case "Bananas":
                if (temperatura < 13.3)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Chocolate":
                if (temperatura < 18)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Fish":
                if (temperatura < 2)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Meat":
                if (temperatura < -15)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Ice cream":
                if (temperatura < -18)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Frozen pizza":
                if (temperatura < -30)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Cheese":
                if (temperatura < 7.2)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Sausages":
                if (temperatura < 5)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Butter":
                if (temperatura < 20.5)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
            case "Eggs":
                if (temperatura < 19)
                {
                    Console.WriteLine("Nieprawidłowa temperatura dla: " + rodzajProduktu);
                }

                break;
        }
    }
}