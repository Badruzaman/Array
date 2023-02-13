

int[] arr = { 12, 3, 1, 2, -6, 5, -8, 6 };
int target = 0;
List<int[]> result = solution_01(arr, target);
foreach (var item in result)
{
    foreach (var _item in item)
    {
        Console.Write(_item + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();

// time O(N^3) space O(N)
List<int[]> solution(int[] arr, int targetSum)
{
    List<int[]> triplets = new List<int[]>();
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            for (int k = j + 1; k < arr.Length; k++)
            {
                int currentSum = arr[i] + arr[j] + arr[k];
                if (currentSum == targetSum)
                {
                    int[] triplet = new int[] { arr[i], arr[j], arr[k] };
                    Array.Sort(triplet);
                    triplets.Add(triplet);
                }
            }
        }
    }
    return triplets;
}
List<int[]> solution_01(int[] array, int targetSum)
{
    List<int[]> triplets = new List<int[]>();
    Array.Sort(arr);
    for (int i = 0; i < array.Length; i++)
    {
        int left = i + 1;
        int right = array.Length - 1;
        while (left < right)
        {
            int currentSum = array[i] + array[left] + array[right];
            if (currentSum == targetSum)
            {
                int[] triplet = new int[] { array[i], array[left], array[right] };
                triplets.Add(triplet);
                left++;
                right--;
            }
            else if (currentSum < targetSum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }
    return triplets;
}