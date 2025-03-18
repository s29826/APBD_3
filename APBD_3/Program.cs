namespace APBD_3;

class Program
{
    static void Main(string[] args)
    {
        Kontener kontener1 = new KontenerPlyny(5, 20, 2, 30,
            'L', 10, false);
        Kontener kontener2 = new KontenerGaz(10, 3, 2, 50,
            'G', 20, 1001);
        Kontener kontener3 = new KontenerChlodniczy(25, 100, 2, 150,
            'C', 200, "Bananas", 0);
        kontener1.ZaladujKonterer();
        kontener2.ZaladujKonterer();
        kontener3.ZaladujKonterer();

        Kontenerowiec kontenerowiec1 = new Kontenerowiec(20, 10, 200);
        Kontenerowiec kontenerowiec2 = new Kontenerowiec(10, 15, 100);
        kontenerowiec1.ZaladujKontener(kontener1);
        kontenerowiec1.ZaladujKontener(kontener2);
        kontenerowiec2.ZaladujKontener(kontener3);
        
        Console.WriteLine(kontenerowiec1);
        Console.WriteLine(kontenerowiec2);
    }
}