
int[] arr = { 1, 2, 3, 4, 5, 6 };
int target = 5;
int[] result = solution(arr, target);
foreach (var item in result)
{
    Console.Write(item + " ");
}
Console.ReadKey();

int[] solution(int[] arr, int target)
{
    HashSet<int> set = new HashSet<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        int currentNum = arr[i];
        int potentialNum = target - currentNum;
        if (set.Contains(potentialNum))
        {
            return new int[] { potentialNum, currentNum };
        }
        else
        {
            set.Add(currentNum);
        }
    }
    return new int[2];
}