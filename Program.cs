using System;
using System.Collections.Generic;
using Lab3.SortingAlgorithms;
using System.Diagnostics;
using System.Buffers.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1000000;

            // Unordered
            List<int> intList = GenerateRandomIntList(num, num * 5);

            //Reversed
            List<int> intListRev = new List<int>();
            for (int i = num - 1; i > -1; i--)
            {
                intListRev.Add(i);
            }

            //Ordered
            List<int> intListOrdered = new List<int>();
            for (int i = 0;i < num; i++)
            {
                intListOrdered.Add(i);

            }

            double totalTime = 0.0;
            double averageTime = 0.0;


            //List<double> doubleList = GenerateRandomDoubleList(100, 500);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));




            //Quadratic Time(BubbleSort and InsertionSort)

            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            Console.WriteLine("BUBBLE SORT");
            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                //Unordered
                //List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                //totalTime += TimeSort<int>(bubbleSort, intListCopy);

                //Reversesed
                //List<int> intListCopy = new List<int>(intListRev);   // make a copy of the array in reverse

                //totalTime += TimeSort<int>(bubbleSort, intListCopy);

                //Ordered
                //List<int> intListCopy = new List<int>(intListOrdered);   // make a copy of the array in order

                //totalTime += TimeSort<int>(bubbleSort, intListCopy);
            }

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            InsertionSort<int> insertionSort = new InsertionSort<int>();
            Console.WriteLine("INSERTION SORT");
            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                ////Unordered
                //List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                //totalTime += TimeSort<int>(insertionSort, intListCopy);

                //Reversed
                //List<int> intListCopy = new List<int>(intListRev);   // make a copy of the array in reverse

                //totalTime += TimeSort<int>(insertionSort, intListCopy);

                //Ordered
                //List<int> intListCopy = new List<int>(intListOrdered);   // make a copy of the array in order

                //totalTime += TimeSort<int>(insertionSort, intListCopy);
            }

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");



            //Log - Linear Time(MergeSort and QuickSort)

            MergeSort<int> mergeSort = new MergeSort<int>();
            Console.WriteLine("MERGE SORT");

            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                //Unordered
                //List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                //totalTime += TimeSort<int>(mergeSort, intListCopy);

                //Reversed
                //List<int> intListCopy = new List<int>(intListRev);   // make a copy of the array in reverse

                //totalTime += TimeSort<int>(mergeSort, intListCopy);

                //Ordered
                //List<int> intListCopy = new List<int>(intListOrdered);   // make a copy of the array in order

                //totalTime += TimeSort<int>(mergeSort, intListCopy);

            }

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            QuickSort<int> quickSort = new QuickSort<int>();
            Console.WriteLine("QUICK SORT");

            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                //Unordered
                //List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                //totalTime += TimeSort<int>(quickSort, intListCopy);

                //Reversed
                //List<int> intListCopy = new List<int>(intListRev);   // make a copy of the array in reverse

                //totalTime += TimeSort<int>(quickSort, intListCopy);

                //Ordered
                //List<int> intListCopy = new List<int>(intListOrdered);   // make a copy of the array in order

                //totalTime += TimeSort<int>(quickSort, intListCopy);
            }

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");



            //Linear Time(Non-comparison based)(BucketSort and RadixSort)

            BucketSort bucketSort = new BucketSort();
            Console.WriteLine("BUCKET SORT");
            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                //Unordered
                //List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                //totalTime += TimeSort(bucketSort, intListCopy);

                //Reversed
                //List<int> intListCopy = new List<int>(intListRev);   // make a copy of the array in reverse

                //totalTime += TimeSort(bucketSort, intListCopy);

                //Ordered
                //List<int> intListCopy = new List<int>(intListOrdered);   // make a copy of the array in order

                //totalTime += TimeSort(bucketSort, intListCopy);
            }

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            RadixSort radixSort = new RadixSort();
            Console.WriteLine("RADIX SORT");
            totalTime = 0;

            for (int i = 0; i < 11; i++)
            {
                ////Unordered
                //List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array

                //totalTime += TimeSort(radixSort, intListCopy);

                //Reversed
                //List<int> intListCopy = new List<int>(intListRev);   // make a copy of the array in reverse

                //totalTime += TimeSort(radixSort, intListCopy);

                //Ordered
                //List<int> intListCopy = new List<int>(intListOrdered);   // make a copy of the array in order

                //totalTime += TimeSort(radixSort, intListCopy);
            }

            //averageTime = totalTime / 11;
            //Console.WriteLine($"{averageTime}");


            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));


            //bubbleSort.Sort(ref intListCopy);

            //BucketSort<int> bucketSort = new BucketSort<int>();
            //bucketSort.Sort(ref intListCopy);

            //HeapSort<int> heapSort = new HeapSort<int>();
            //heapSort.Sort(ref intList);

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //mergeSort.Sort(ref intList);

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //insertionSort.Sort(ref intList);

            //SelectionSort<int> selectionSort = new SelectionSort<int>();
            //selectionSort.Sort(ref intList);

            //quickSort.Sort(ref intList);
            //QuickSort<double> quickSortDouble = new QuickSort<double>();
            //quickSortDouble.Sort(ref doubleList);

            //TreeSort<int> treeSort = new TreeSort<int>();
            //treeSort.Sort(ref intList);

            //Console.WriteLine("[{0}]", string.Join(", ", intList.ToArray()));
            //Console.WriteLine("[{0}]", string.Join(", ", doubleList.ToArray()));

            //Console.WriteLine("QUICKSORT");
            //QuickSort<int> quickSort = new QuickSort<int>();
            //for( int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //    TimeSort(quickSort, intListCopy);
            //}

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //for (int i = 0; i < 11; i++)
            //{
            //    List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //    TimeSort(mergeSort, intListCopy);
            //}

            //MergeSort<int> mergeSort = new MergeSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(mergeSort, intListCopy);

            //InsertionSort<int> insertionSort = new InsertionSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(insertionSort, intListCopy);

            //BubbleSort<int> bubbleSort = new BubbleSort<int>();
            //intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
            //TimeSort(bubbleSort, intListCopy);





        }

        public static double TimeSort<T>(ISortable<T> sortable, List<T> items) where T : IComparable<T>
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(ref items);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;

        }

        public static double TimeSort(ISortableInt sortable, List<int> items)
        {
            int[] array = items.ToArray();

            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var sorted = sortable.Sort(array);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            Console.WriteLine(ts.TotalSeconds);

            return ts.TotalSeconds;
        }


        public static List<int> GenerateRandomIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(maxValue));
            }

            return list;
        }

        public static List<double> GenerateRandomDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.NextDouble() * maxValue);
            }

            return list;
        }
    }
}
