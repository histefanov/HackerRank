namespace ArrayReduction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using C5;

    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var reductionCost = ReduceArray(nums);
            Console.WriteLine(reductionCost);
        }

        private static int ReduceArray(List<int> nums)
        {
            var heap = new IntervalHeap<int>();
            heap.AddAll(nums);

            var cost = 0;

            while (heap.Count > 1)
            {
                var first = heap.DeleteMin();
                var second = heap.DeleteMin();

                cost += (first + second);

                heap.Add(first + second);
            }

            return cost;
        }
    }
}
