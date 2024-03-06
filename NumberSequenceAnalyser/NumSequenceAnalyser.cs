using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace NumberSequenceAnalyserLib;

public class NumberSequenceAnalyser
{
    public readonly List<int> BiggestSequenceByIncresing = new List<int>();
    private List<int> IncreasingTempSequnce = new List<int>();
    public readonly List<int> BiggestSequenceByDecresing = new List<int>();
    private List<int> DecreasingTempSequnce = new List<int>();
    public static float GetMediana(List<int> list)
    {
        return list.Count % 2 == 0 ? 
            (list[list.Count / 2 - 1] + list[(int)Math.Ceiling(list.Count / 2m)]) / 2f : // lenght of list is even
            list[(int)Math.Floor(list.Count / 2m)]; // length of list is odd
    } 
    public AnalyticalData GetAnalyticalData(List<int> list)
    {
        IncreasingTempSequnce.Clear();
        DecreasingTempSequnce.Clear();
        BiggestSequenceByDecresing.Clear();
        BiggestSequenceByIncresing.Clear();

        IncreasingTempSequnce.Add(list[0]);
        DecreasingTempSequnce.Add(list[0]);
        int sum = list[0];
        for(int i = 1; i < list.Count; i++)
        {
            sum += list[i];
            MoveBiggestSequenceByIncreasing(list[i]);
            MoveBiggestSequenceByDecreasing(list[i]);
        }
        return new AnalyticalData(
            sum * 1f / list.Count, 
            BiggestSequenceByIncresing,
            BiggestSequenceByDecresing
        );
    } 
    private void MoveBiggestSequenceByIncreasing(int num)
    {
        if(num > IncreasingTempSequnce.Last())
        {
            IncreasingTempSequnce.Add(num);
            if(IncreasingTempSequnce.Count > BiggestSequenceByIncresing.Count)
            {
                BiggestSequenceByIncresing.Clear();
                BiggestSequenceByIncresing.AddRange(IncreasingTempSequnce);
            }
        }
        else
        {
            IncreasingTempSequnce.Clear();
            IncreasingTempSequnce.Add(num);
        }
    }
    private void MoveBiggestSequenceByDecreasing(int num)
    {
        if(num < DecreasingTempSequnce.Last())
        {
            DecreasingTempSequnce.Add(num);
            if(DecreasingTempSequnce.Count > BiggestSequenceByDecresing.Count)
            {
                BiggestSequenceByDecresing.Clear();
                BiggestSequenceByDecresing.AddRange(DecreasingTempSequnce);
            }
        }
        else
        {
            DecreasingTempSequnce.Clear();
            DecreasingTempSequnce.Add(num);
        }
    }
}

