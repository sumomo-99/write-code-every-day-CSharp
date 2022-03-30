using Sumomo99.WriteCodeEveryDay;

if (args.Length > 0)
{
    var watch = new Watch() { Seconds = UInt32.Parse(args[0]) };
    watch.Format();
    Console.WriteLine($"{watch.Hours:00}:{watch.Minutes:00}:{watch.Seconds:00}");
}
else
{
    Console.WriteLine("Usage:  dotnet run SECONDS");
}

namespace Sumomo99.WriteCodeEveryDay
{
    public class Watch
    {
        public uint Hours { get; set; } = 0;
        public uint Minutes { get; set; } = 0;
        public uint Seconds { get; set; } = 0;

        public void Format()
        {
            ConvertSeconds();
            ConvertMinutes();
        }

        private void ConvertSeconds()
        {
            if (Seconds >= 60)
            {
                Minutes = Seconds / 60;
                Seconds %= 60;
            }
        }

        private void ConvertMinutes()
        {
            if (Minutes >= 60)
            {
                Hours = Minutes / 60;
                Minutes %= 60;
            }
        }
    }
}