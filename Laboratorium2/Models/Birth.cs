using Laboratorium2.Models;
public class Birth
{
    public string imie { get;set; }
    public DateTime uro { get;set; }

    public bool IsValid()
    {
        return imie != null;
    }
    public int Calc()
    {
        DateTime now=DateTime.Now;

        return (int)now.Year-(int)uro.Year;
    }

}

