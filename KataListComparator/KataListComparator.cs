namespace KataListComparator;

/// <summary>
/// You have two arrays in this kata, every array contains only unique elements. 
/// Your task is to calculate the number of elements in the first array which are also in the second array.
/// </summary>
public class KataListComparator
{
    public int GetNumberOfSameElements(List<int> firstArray, List<int> secondArray)
    {
        return firstArray.Intersect(secondArray).Count();
    }
}
