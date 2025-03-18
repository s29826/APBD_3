namespace APBD_3;

public class OverfillException : Exception
{
    public OverfillException() 
        : base("Kontener przeładowany - masa ładunku jest większa, niż jego ładowność!")
    {
    }
}