var compareService = new CompareService();
compareService.Do(50);
compareService.Do(500);
compareService.Do(5000);
compareService.Do(50000);

public class Letter
{
    public char Name { get; set; }
    public EnumLetter Type { get; set; }
    public int Id { get; set; }
}

public enum EnumLetter
{
    Upper,
    Lower
}