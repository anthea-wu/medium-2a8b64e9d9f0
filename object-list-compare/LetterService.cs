public class LetterService
{
    private static readonly char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

    public List<Letter> Generate(int count)
    {
        var letters = new List<Letter>();
        
        var random = new Random();
        for (var i = 0; i < count; i++)
        {
            var index = random.Next(chars.Length);
            var letter = chars[index];
            var isUpper = char.IsUpper(letter);
            letters.Add(new Letter()
            {
                Name = letter,
                Id = i + 1,
                Type = isUpper ? EnumLetter.Upper : EnumLetter.Lower
            });
        }

        return letters;
    }
}