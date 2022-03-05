foreach (var (item, index) in PrintTestCase.InputCase().Select((item, index) => (item, index)))
{
  Console.WriteLine($"Case {index + 1}: {item}");
}

public static class PrintTestCase
{
    public static List<string> InputCase()
    {
      List<string> cases = new();

      while(true)
      {
        var buffer = Console.ReadLine();

        if (buffer == "0" || buffer == null) break;

        cases.Add(buffer);
      }

      return cases;
    }
}