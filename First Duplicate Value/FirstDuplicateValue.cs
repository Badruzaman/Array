


int[] array = { 2, 1, 5, 3, 3, 2, 4 };
int result = solution_02(array);
Console.WriteLine(result);
Console.ReadKey();

// time O(N^2) Space O(1)
int solution(int[] array)
{
    int minimumSecondIndex = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        int value = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            int secondMatchValue = array[j];
            if (value == secondMatchValue)
            {
                minimumSecondIndex = Math.Min(minimumSecondIndex, j);
            }
        }
    }
    if (minimumSecondIndex == array.Length)
    {
        return -1;
    }
    return array[minimumSecondIndex];
}

// time O(N) Space O(N)
int solution_01(int[] array)
{
    HashSet<int> seen = new HashSet<int>();
    foreach (var item in array)
    {
        if (seen.Contains(item))
        {
            return item;
        }
        seen.Add(item);
    }
    return -1;
}
// time O(N) Space O(1)
int solution_02 (int[] array)
{
    // { 2, 1, 5, 3, 3, 2, 4 };
    foreach (var value in array)
    {
        int absValue = Math.Abs(value);
        if (array[absValue - 1] < 0)
        {
            return absValue;
        }
        array[absValue - 1] *= -1;
    }
    return -1;
}