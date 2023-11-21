namespace 计算
{
    internal class Text
    {
        public int[][] Paixu(int[][] points, int k)
        {
            if (k <= 0 || points.Length == 0)
                return new int[0][];

            // 使用快速排序找到第 K 小的距离
            int left = 0;
            int right = points.Length - 1;
            int kthSmallest = k - 1;

            while (left <= right)
            {
                int pivotIndex = Partition(points, left, right);

                if (pivotIndex == kthSmallest)
                    break;

                if (pivotIndex < kthSmallest)
                    left = pivotIndex + 1;
                else
                    right = pivotIndex - 1;
            }

            // 构建结果数组，包含前 K 个最小距离的点
            int[][] result = new int[k][];
            Array.Copy(points, result, k);

            return result;
        }

        private int Partition(int[][] points, int left, int right)
        {
            int[] pivot = points[left];
            int pivotDistance = CalculateDistance(pivot);

            while (left < right)
            {
                while (left < right && CalculateDistance(points[right]) >= pivotDistance)
                    right--;

                points[left] = points[right];

                while (left < right && CalculateDistance(points[left]) <= pivotDistance)
                    left++;

                points[right] = points[left];
            }

            points[left] = pivot;
            return left;
        }

        private int CalculateDistance(int[] point)
        {
            int x = point[0];
            int y = point[1];

            // 使用欧几里得距离公式计算距离
            return x * x + y * y;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Text solution = new Text();

            // 示例用法
            int[][] points = new int[][] {
            new int[] {1, 3},
            new int[] {-2, 2},
            new int[] {5, -1}
        };
            int k = 2;

            int[][] closestPoints = solution.Paixu(points, k);

            Console.WriteLine("K closest points to origin:");
            foreach (int[] point in closestPoints)
            {
                Console.WriteLine($"({point[0]}, {point[1]})");
            }
        }
    }
}
