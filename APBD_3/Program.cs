namespace APBD_3;

class Program
{
    static void Main(string[] args)
    {
        Kontener kontener1 = new KontenerPlyny(1000, 20, 1, 30,
            1500, true);
        Kontener kontener2 = new KontenerGaz(1000, 3, 1, 50,
            1000, 1001);
        Kontener kontener3 = new KontenerChlodniczy(1000, 100, 2,
            150, 1500, "Bananas", 13.3);
        Kontener kontener4 = new KontenerGaz(1000, 3, 1, 50,
            1000, 1001);
        
        kontener1.ZaladujKonterer();
        kontener2.ZaladujKonterer();
        kontener3.ZaladujKonterer();
        
        Kontenerowiec kontenerowiec1 = new Kontenerowiec(1, 3, 2);
        kontenerowiec1.ZaladujKontener(kontener1);
        
        List<Kontener> list = new List<Kontener> { kontener1, kontener4, kontener3 };
        kontenerowiec1.ZaladujKontener(list);
        
        kontenerowiec1.UsunKontener(kontener1);
        
        Console.WriteLine(kontener2);
        kontener2.OproznijLadunek();
        Console.WriteLine(kontener2);
        
        Kontenerowiec kontenerowiec2 = new Kontenerowiec(2, 3, 2);
        kontenerowiec1.PrzeniesienieKontenera(kontener1, kontenerowiec2);
        
        Console.WriteLine(kontenerowiec2);
        Console.WriteLine(kontenerowiec1);

        Kontenerowiec kontenerowiec3 = new Kontenerowiec(1, 3, 4);
        kontenerowiec3.ZaladujKontener(list);
        Console.WriteLine(kontenerowiec3);
    }
}