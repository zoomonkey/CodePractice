
int[] numbers = { 12, 45, 7, 89, 23, 56 };

int highest = DoSomething.GetBiggest(numbers);

Console.WriteLine($"Largest number: {highest}");

public static class DoSomething
{
    public static int GetBiggest(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length - 1];
    }
}

