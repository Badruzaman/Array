

int[] arr = { 1, 2, 3, 7, 5 };
int N = 5;
int S = 12;
List<int> result = solution(arr, N, S);
foreach (var item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

List<int> solution(int[] arr, int N, int S)
{
    int left = 0;
    int right = 0;
    int current_sum = arr[0];
    while (right < N)
    {
        if (current_sum == S)
        {
            return new List<int> { left + 1, right + 1 };
        }
        else if (current_sum < S)
        {
            right += 1;
            if (right == arr.Length)
            {
                break;
            }
            current_sum += arr[right];
        }
        else
        {
            current_sum -= arr[left];
            left += 1;
        }
    }
   return new List<int> { -1, -1 };
}


