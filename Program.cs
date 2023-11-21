namespace 找k
{
    internal class Program
    {
        public static int[] FindMaxNumbers(int[] nums, int k)
        {
            if (k <= 0 || nums.Length == 0)
                return new int[0];

            int[] result = new int[k];

            // 遍历数组，找到最大的 K 个数
            for (int i = 0; i < k; i++)
            {
                int maxIndex = 0;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[maxIndex])
                        maxIndex = j;
                }

                result[i] = nums[maxIndex];
                nums[maxIndex] = int.MinValue;  // 将已找到的最大数替换为最小值，以便下次循环不再考虑它
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 9, 7, 5, 8 };
            int k = 3;

            int[] result = FindMaxNumbers(nums, k);

            Console.WriteLine("Max K Numbers:");
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

            
        }
    }
}
