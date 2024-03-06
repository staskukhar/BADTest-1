using Microsoft.VisualBasic;
using NumberSequenceAnalyserLib;

namespace NumSequenceAnalyser.Tests;

public class NumSequenceAnalyserTest2
{
    [Fact]
    public void Get_Analytical_Data_Test1()
    {
        //Arrange
        var analyser = new NumberSequenceAnalyser();
        List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        //Act && Assert
        AnalyticalData actualData = analyser.GetAnalyticalData(nums);
        AnalyticalData expectedData = new AnalyticalData(5.0f, [1, 2, 3, 4, 5, 6, 7, 8, 9], []);

        Assert.Equal(expectedData.AverangeValue, actualData.AverangeValue);
        Assert.Equal(   
            expectedData.BiggestSequenceByIncresing.ToList().Count, 
            actualData.BiggestSequenceByIncresing.ToList().Count
        );
        Assert.Equal(   
            expectedData.BiggestSequenceByDecresing.ToList().Count, 
            actualData.BiggestSequenceByDecresing.ToList().Count
        );
        for(int i = 0; i < expectedData.BiggestSequenceByIncresing.ToList().Count; i++)
        {
            Assert.Equal(
                expectedData.BiggestSequenceByIncresing.ToList()[i], 
                actualData.BiggestSequenceByIncresing.ToList()[i]
            );
        }
        for(int i = 0; i < expectedData.BiggestSequenceByDecresing.ToList().Count; i++)
        {
            Assert.Equal(
                expectedData.BiggestSequenceByDecresing.ToList()[i], 
                actualData.BiggestSequenceByDecresing.ToList()[i]
            );
        }
    }
    [Fact]
    public void Get_Analytical_Data_Test2()
    {
        //Arrange
        var analyser = new NumberSequenceAnalyser();
        List<int> nums = [0, 1, 3, 5, 7, 9, 8, 6, 4, 2];

        //Act && Assert
        AnalyticalData actualData = analyser.GetAnalyticalData(nums);
        AnalyticalData expectedData = new AnalyticalData(4.5f, [0, 1, 3, 5, 7, 9], [9, 8, 6, 4, 2]);

        Assert.Equal(expectedData.AverangeValue, actualData.AverangeValue);
        Assert.Equal(   
            expectedData.BiggestSequenceByIncresing.ToList().Count, 
            actualData.BiggestSequenceByIncresing.ToList().Count
        );
        Assert.Equal(   
            expectedData.BiggestSequenceByDecresing.ToList().Count, 
            actualData.BiggestSequenceByDecresing.ToList().Count
        );
        for(int i = 0; i < expectedData.BiggestSequenceByIncresing.ToList().Count; i++)
        {
            Assert.Equal(
                expectedData.BiggestSequenceByIncresing.ToList()[i], 
                actualData.BiggestSequenceByIncresing.ToList()[i]
            );
        }
        for(int i = 0; i < expectedData.BiggestSequenceByDecresing.ToList().Count; i++)
        {
            Assert.Equal(
                expectedData.BiggestSequenceByDecresing.ToList()[i], 
                actualData.BiggestSequenceByDecresing.ToList()[i]
            );
        }
    }
}
