
int[] arr = { 1, 11, 3, 0, 15, 5, 2, 4, 10, 7, 12, 6 };

int[] result = solution(arr);
foreach (var item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

int[] solution(int[] arr)
{
    int[] longestRange = new int[2];
    int longestNum = 0;
    HashSet<int> nums = new HashSet<int>();
    foreach (var item in arr)
    {
        nums.Add(item);
    }
    foreach (var num in arr)
    {
        if (!nums.Contains(num))
        {
            continue;
        }
        nums.Remove(num);
        int currentLength = 1;
        int left = num - 1;
        int right = num + 1;
        while (nums.Contains(left))
        {
            nums.Remove(left);
            currentLength++;
            left--;
        }
        while (nums.Contains(right))
        {
            nums.Remove(right);
            currentLength++;
            right++;
        }
       if(currentLength> longestNum)
        {
            longestNum = currentLength;
            longestRange = new int[] { left + 1, right - 1 };
        }
    }
    return longestRange;
}