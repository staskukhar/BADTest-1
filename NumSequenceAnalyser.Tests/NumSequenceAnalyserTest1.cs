using NumberSequenceAnalyserLib;

namespace NumSequenceAnalyser.Tests;

public class NumSequenceAnalyserTest1
{
    [Fact]
    public void Get_Mediana_Test1()
    {
        //Arrange
        List<int> nums = [1, 8, 6, 2, 7, 9, 5, 3, 4];   // 1, 2, 3, 4, 5, 6, 7, 8, 9
        float expectedMediana = 5.0f;                   //             ^ - mediana
        nums.Sort();
        //Act
        float actualMediana = NumberSequenceAnalyser.GetMediana(nums);

        //Assert
        Assert.Equal(expectedMediana, actualMediana);
    }
    [Fact]
    public void Get_Mediana_Test2()
    {
        //Arrange
        List<int> nums = [1, 8, 6, 2, 7, 9, 5, 3, 4, 10];   // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        float expectedMediana = 5.5f;                       //             ^--^ mediana == 5.5
        nums.Sort();
        //Act
        float actualMediana = NumberSequenceAnalyser.GetMediana(nums);

        //Assert
        Assert.Equal(expectedMediana, actualMediana);
    }
    [Fact]
    public void Get_Mediana_Test3()
    {
        //Arrange
        List<int> nums = [1];   
        float expectedMediana = 1.0f;
        nums.Sort();
        //Act
        float actualMediana = NumberSequenceAnalyser.GetMediana(nums);

        //Assert
        Assert.Equal(expectedMediana, actualMediana);
    }
    [Fact]
    public void Get_Mediana_Test4()
    {
        //Arrange
        List<int> nums = [1, 6];   
        float expectedMediana = 3.5f;
        nums.Sort();
        //Act
        float actualMediana = NumberSequenceAnalyser.GetMediana(nums);

        //Assert
        Assert.Equal(expectedMediana, actualMediana);
    }
}