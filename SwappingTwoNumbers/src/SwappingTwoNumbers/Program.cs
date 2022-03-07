var list = new List<(int, int)>();
var buffer = "";

while ((buffer = Console.ReadLine()) != null) {
  try {
    var num = buffer.Split(' ', StringSplitOptions.RemoveEmptyEntries)
      .Select(c => int.Parse(c))
      .ToList();

    if (num[0] ==0 && num[1] == 0)
    {
      break;
    }
    else if (num[0] <= num[1])
    {
      list.Add((num[0], num[1]));
    } else
    {
      list.Add((num[1], num[0]));
    }
  }
  catch (System.FormatException)
  {
    Console.WriteLine("整数で入力してください。");
    continue;
  }
  catch (System.ArgumentOutOfRangeException)
  {
    Console.WriteLine("2つの整数をスペース区切りで入力してください。");
    continue;
  }
}

Console.WriteLine("----------");

foreach (var (i, j) in list)
{
  Console.WriteLine($"{i} {j}");
}