

int[] nums = { -1, 2, 1, -4 };
int target = 1;

int result = solution(nums, target);
Console.WriteLine(result);
Console.ReadKey();

int solution(int[] nums, int target)
{
    //[-4, -1, 1, 2]
    Array.Sort(nums);
    int closestSum = nums[0] + nums[1] + nums[2];
    for (int i = 0; i < nums.Length - 2; i++)
    {
        int left = i + 1;
        int right = nums.Length - 1;
        while (left < right)
        {
            int sum = nums[i] + nums[left] + nums[right];
            if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
            {
                closestSum = sum;
            }
            if (sum < target)
            {
                left++;
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                return sum;
            }
        }
    }
    return closestSum;
}