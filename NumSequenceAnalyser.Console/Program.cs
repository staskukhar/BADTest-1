using System.Diagnostics;
using NumberSequenceAnalyserLib;
using static NumberSequenceAnalyserLib.NumberSequenceAnalyser;

do
{
    Console.Clear();
    await Run();
    Console.WriteLine("Press \"escape\" to exit or any another to continue.");
} while(Console.ReadKey().Key != ConsoleKey.Escape);

async Task Run()
{
    var a = new NumberSequenceAnalyser();

    Console.WriteLine("Please provide full path to your file(extension: .txt):");
    string? fileName = Console.ReadLine();
    if(!String.IsNullOrEmpty(fileName))
    {
        if(Path.GetExtension(fileName) != ".txt")
        {
            Console.WriteLine(@"Path or file isn't valid. (Example: C:\Users\MyComputer\Documents\10m.txt)");
            Console.WriteLine("Accepts only .txt files.");
            return;
        }
        string[]? lines = null;
        try
        {
            lines = await File.ReadAllLinesAsync(fileName);
        }
        catch(IOException)
        {
            Console.WriteLine(@"Path or file isn't valid. (Example: C:\Users\MyComputer\Documents\10m.txt)");
        }
        if(lines is null) return;
        
        List<int>? nums = null;
        try
        {
            nums  = lines
            .Select(l => int.Parse(l))
            .ToList();
        }
        catch(FormatException)
        {
            Console.WriteLine("No literal symbols allowed.");
        }
        if(nums is null) return;

        var timer = new Stopwatch();
        timer.Start();

        AnalyticalData dataAnalyser = a.GetAnalyticalData(nums);
        Console.WriteLine("By increasing");
        foreach(int n in dataAnalyser.BiggestSequenceByIncresing)
        {
            Console.Write($"{n} | ");
        }
        Console.WriteLine();

        Console.WriteLine("By decreasing");
        foreach(int n in dataAnalyser.BiggestSequenceByDecresing)
        {
            Console.Write($"{n} | ");
        }
        Console.WriteLine();

        nums.Sort();
        Console.WriteLine(
            $"min: {nums.First()}, max: {nums.Last()}, medium: {GetMediana(nums)}, avrg: {dataAnalyser.AverangeValue:N2}"
        );
        timer.Stop();
        Console.WriteLine($"Time elapsed: {timer.ElapsedMilliseconds / 1000m} s.");
    }
}

