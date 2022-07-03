using Sumomo99.WriteCodeEveryDay;

if (args.Length > 1)
{
    Console.WriteLine(Power.Caluculate(args[0], args[1]));
}
else
{
    Console.WriteLine("Usage: X-Power BASE EXPONENT");
}