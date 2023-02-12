﻿

int[] arr = { 1, 2, 3, 4, 5, 6 };
int target = 9;
int[] result = solution_02(arr, target);
foreach (var item in result)
{
	Console.Write(item + " ");
}
Console.ReadKey();

// time O(N) space O(N)
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

// time O(NlongN) space O(1)
int[] solution_02(int[] arr, int target)
{
    Array.Sort(arr);
	int left = 0;
	int right = arr.Length - 1;
	while (left < right)
	{
		int currentNum = arr[left] + arr[right];
		if(currentNum == target)
		{
			return new int[] { arr[left], arr[right] };
		}
	    else if (currentNum < target)
		{
			left++;	
		}
		else
		{
			right--;
		}
	}
    return new int[2];
}