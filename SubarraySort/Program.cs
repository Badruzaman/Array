

int[] array = { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 };
int[] result = solution(array);
foreach (var item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

int[] solution(int[] nums)
{
    int n = nums.Length;
    int start = -1;
    int end = -1;
    int min = nums[n - 1];
    int max = nums[0];

    for (int i = 1; i < n; i++)
    {
        max = Math.Max(max, nums[i]);
        min = Math.Min(min, nums[n - 1 - i]);
        if (nums[n - 1 - i] > min) 
            start = n - 1 - i;
        if (nums[i] < max)
            end = i;
    }
    return new int[] { start, end };
}
