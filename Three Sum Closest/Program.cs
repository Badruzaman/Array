
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;

HttpClient _httpClient = new HttpClient();

int[] nums = { -1, 2, 1, -4 };
int target = 1;

int result = solution(nums, target);

Console.WriteLine(result);
Console.ReadKey();

[Test]
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
    //getDTO();
    return closestSum;
}
async void getDTO()
{
//    try
//    {
//        var state = await _httpClient.GetFromJsonAsync<List<DTOState>>($"http://10.10.83.153:70/api/State/GetStateById?id={2}");
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
}
public class DTOState
{
    public int StateId { get; set; }
    public string Name { get; set; }
}
