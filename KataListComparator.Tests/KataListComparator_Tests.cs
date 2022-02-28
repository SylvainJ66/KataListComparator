using System.Collections.Generic;
using Xunit;

namespace KataListComparator.Tests;

public class KataListComparator_Tests
{
    [Fact]
    public void DoNothing()
    {
        Assert.False(false);
    }

    [Fact]
    public void CompareSimpleSameArraysShouldReturnNumberOfElementsInCommon()
    {
        List<int> firstArray = new List<int>{ 5 };
        List<int> secondArray = new List<int> { 5 };

        Assert.Equal(1, new KataListComparator().GetNumberOfSameElements(firstArray, secondArray));
    }

    [Fact]
    public void CompareAnOtherSimpleSameArraysShouldReturnElementsInCommon()
    {
        List<int> firstArray = new List<int> { 6 };
        List<int> secondArray = new List<int> { 6 };

        Assert.Equal(1, new KataListComparator().GetNumberOfSameElements(firstArray, secondArray));
    }

    [Fact]
    public void CompareArraysShouldReturnElementsInCommon()
    {
        List<int> firstArray = new List<int> { 6, 7, 9 };
        List<int> secondArray = new List<int> { 6, 7, -1 };

        Assert.Equal(2, new KataListComparator().GetNumberOfSameElements(firstArray, secondArray));
    }

    [Fact]
    public void CompareOnOtherArraysShouldReturnElementsInCommon()
    {
        List<int> firstArray = new List<int> { 6, 7, 9, 10, 20, 80, 10 };
        List<int> secondArray = new List<int> { 6, 10 };

        Assert.Equal(2, new KataListComparator().GetNumberOfSameElements(firstArray, secondArray));
    }
}