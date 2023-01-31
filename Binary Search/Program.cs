
int[] arr = { 1, 2, 3, 4, 5, 6 };
int target = 6;
int result = solution(arr, target);
Console.Write(result);
Console.ReadKey();

int solution(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (arr[mid] == target)
        {
            return mid;
        }
        else if (arr[mid] < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }
    return -1;
}