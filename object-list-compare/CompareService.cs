using System.Diagnostics;

public class CompareService
{
    public void Do(int count)
    {
        var letterService = new LetterService();
        var letters1 = letterService.Generate(count);
        var letters2 = letterService.Generate(count);
        Console.WriteLine($"----------比較 {count} 筆的差異----------");

        var stopwatch = new Stopwatch();
        stopwatch.Reset();
        stopwatch.Start();
        var intersect = letters1.IntersectBy(letters2.Select(l => l.Name), l => l.Name).ToList();
        var intersectTime = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"使用 IntersectBy 總共花費 {intersectTime} 豪秒");

        var intersectForeach = new List<Letter>();
        stopwatch.Reset();
        stopwatch.Start();
        foreach (var letter1 in letters1)
        {
            foreach (var letter2 in letters2)
            {
                if (letter1.Name == letter2.Name)
                {
                    var isExisted = intersectForeach.Find(letter => letter.Name == letter1.Name) == null;
                    if (isExisted)
                        intersectForeach.Add(letter1);
                }
            }
        }
        var intersectForeachTime = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"使用 Foreach 總共花費 {intersectForeachTime} 豪秒");
    }
}