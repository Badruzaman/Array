


int[] array = { 2, 1, 5, 3, 3, 2, 4 };
int result = solution(array);
Console.WriteLine(result);
Console.ReadKey();

int solution(int[] array)
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