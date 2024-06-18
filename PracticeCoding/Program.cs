using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice Questions

            //SockMerchant();
            //Candles();
            //LeftRotation();
            //SparesArray();
            //SparseArrayTimeComplexity();
            //MountainSequence();
            //ZigZagSequence();
            //SpiralMatrix();

            //int[] arr = { 2, 5, 1, 9, 6 };
            //int[] second = new int[arr.Length];
            //CopyArray(arr, ref second);
            //PrintArray(second, 0, second.Length);

            #endregion

            #region Bubble Sort

            //int[] arr = { 2, 5, 1, 9, 6 };
            //BubbleSort(ref arr);
            //PrintArray(arr, 0, arr.Length);

            //int[] arr = { 2, 5, 1, 9, 6 };
            //BubbleSortRecurrsion(ref arr, arr.Length);
            //PrintArray(arr, 0, arr.Length);

            #endregion

            #region Merge Sort

            //int[] arr = { 2, 5, 1, 6, 9 };
            //int size = arr.Length;

            //PrintArray(arr, 0, arr.Length);
            //MergeSortRecursion(ref arr, 0, size - 1);
            //Console.WriteLine("\n");
            //Console.WriteLine("Merge Sort: ");
            //PrintArray(arr, 0, arr.Length);

            #endregion

            #region Quick Sort

            #region GFG
            //int[] arr = new int[] { 10, 16, 8, 12, 15, 6, 3, 9, 5 };
            ////int[] arr = new int[] { 10, 7, 8, 9, 1, 5 };
            //int n = arr.Length;
            //QuickSortingGFG(arr, 0, n - 1);

            //foreach (var item in arr)
            //{
            //    Console.Write(item.ToString() + " ");
            //}
            #endregion

            #region Algo-Bari

            //int[] arr = new int[] { 10, 7, 8, 9, 1, 5 };
            //int[] arr = new int[] { 10, 16, 8, 12, 15, 6, 3, 9, 5 };
            //int n = arr.Length;
            //QuickSorting(arr, 0, n - 1);
            //foreach (var item in arr)
            //{
            //    Console.Write(item.ToString() + " ");
            //}

            #endregion

            #region Code Help

            //int[] arr = { 2, 4, 1, 6, 9, 9, 9, 9, 9, 9 };
            //int size = arr.Length - 1;

            //PrintArray(arr, 0, arr.Length);
            //QuickSortRecursion(ref arr, 0, size);
            //Console.WriteLine("\n");
            //Console.WriteLine("Quick Sort: ");
            //PrintArray(arr, 0, arr.Length);

            #endregion

            #endregion

            #region BST

            //BinarySearchTree binaryTree = new BinarySearchTree();

            //binaryTree.Insert(75);
            //binaryTree.Insert(57);
            //binaryTree.Insert(90);
            //binaryTree.Insert(32);
            //binaryTree.Insert(7);
            //binaryTree.Insert(44);
            //binaryTree.Insert(60);
            //binaryTree.Insert(86);
            //binaryTree.Insert(93);
            //binaryTree.Insert(99);
            //binaryTree.Insert(100);

            //Console.WriteLine("In-Order Traversal");
            //binaryTree.InOrderTraversal();
            //Console.WriteLine("\n");

            //Console.WriteLine("Pre-Order Traversal");
            //binaryTree.PreOrderTraversal();
            //Console.WriteLine("\n");

            //Console.WriteLine("Post-Order Traversal");
            //binaryTree.PostOrderTraversal();
            //Console.WriteLine("\n");

            //Console.WriteLine("Level-Order Traversal");
            //binaryTree.LevelOrderTraversal();
            //Console.WriteLine("\n");

            //Console.Write("Number of leaf: {0}", binaryTree.NumberOfLeafNode().ToString());
            //Console.WriteLine("\n");

            #endregion

            #region Recursion 

            /////int n = 5;
            //int ans = Factorial(n);
            //Console.Write("Factorial of {0}: {1}", n.ToString(), ans.ToString());

            //PrintCount(n);

            //ReachHome(1, 10);

            //int ans = Fibonacci(4);
            //Console.WriteLine("Fibonacci: {0}", ans.ToString());

            //int ans = CountDistinctWays(n);
            //Console.WriteLine("Count Distinct Ways: {0}", ans.ToString());

            //string[] arr = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            //SayDigits(412, arr);

            //int[] arr = { 3, 2, 5, 1, 6 };
            //int size = arr.Length;
            //int ans = SumArray(arr, size);
            //Console.WriteLine("Sum Of Array: {0}", ans.ToString());

            //int[] arr = { 3, 2, 5, 1, 6 };
            //int size = arr.Length;
            //var result = LinearSearch(arr, size, 0);
            //Console.WriteLine("Linear Search Result: {0}", result.ToString());

            //int[] arr = { 2, 4, 6, 10, 14, 18, 22, 38, 49, 55, 222 };
            //int size = arr.Length;
            //Array.Sort(arr);
            //int key = 22;
            //var result = BinarySearch(arr, 0, size, key);
            //Console.WriteLine("Binary Search Result: {0}", result.ToString());

            //string s = "imtiaz";
            //char[] sChar = s.ToCharArray();
            //ReverString(ref sChar, 0, s.Length - 1);
            //PrintCharArray(sChar, 0, sChar.Length);

            //int baseNumber = 3;
            //int power = 11;
            //int ans = PowerOfNumber(baseNumber, power);
            //Console.WriteLine("Power of {0} ^ {1}: {2}", baseNumber.ToString(), power.ToString(), ans.ToString());

            //int[] arr = { 1, 2, 3 };
            //var sub = Subsets(arr);
            //foreach (var item in sub)
            //{
            //    foreach (var val in item)
            //    {
            //        Console.Write(val + " ");
            //        Console.WriteLine("\n");
            //    }
            //}

            #endregion

            #region Graphs
            //int []arr = new int[]{ 0, 0, 1};
            //int values = findParent(arr, 2);

            //ArrayData();

            //AdjacencyMatrix();
            //AdjacencyList();

            //int V = 4;
            //int[,] edges = { { 0, 1 }, { 0, 3 }, { 1, 2 }, { 2, 3 } };
            //BFSTraversal(edges, V);

            //int V = 4;
            //int[,] edges = { { 0, 1 }, { 0, 2 }, { 1, 2 }, { 2, 0 }, { 2, 3 }, { 3, 3 } };
            //DFSTraversal(edges, V);


            //int V = 10;
            ////int[,] edges = { { 0, 1 }, { 0, 2 }, { 1, 2 }, { 2, 0 }, { 2, 3 }, { 3, 3 } };
            //int[,] edges = { { 1, 2 }, { 2, 1 }, { 2, 3 }, { 3, 2 }, { 4, 5 }, { 5, 4 }, { 5, 6 }, { 5, 7 }, { 6, 5 }, { 6, 8 }, { 7, 5 }, { 7, 8 }, { 8, 6 }, { 8, 7 }, { 8, 9 }, { 9, 8 } };
            //CycleDetectionUsingBFS(edges, V);

            //int V = 10;
            ////int[,] edges = { { 0, 1 }, { 0, 2 }, { 1, 2 }, { 2, 0 }, { 2, 3 }, { 3, 3 } };
            //int[,] edges = { { 1, 2 }, { 2, 1 }, { 2, 3 }, { 3, 2 }, { 4, 5 }, { 5, 4 }, { 5, 6 }, { 5, 7 }, { 6, 5 }, { 6, 8 }, { 7, 5 }, { 7, 8 }, { 8, 6 }, { 8, 7 }, { 8, 9 }, { 9, 8 } };
            //CyclicDetectionUsingDFS(edges, V);

            //int V = 9;
            ////int[,] edges = { { 0, 1 }, { 0, 2 }, { 1, 2 }, { 2, 0 }, { 2, 3 }, { 3, 3 } };
            //int[,] edges = { { 1, 2 }, { 2, 3 }, { 2, 4 }, { 3, 7 }, { 3, 8 }, { 4, 5 }, { 5, 6 }, { 6, 4 }, { 8, 7 } };
            //CycleUsingDFSForDirected(edges, V);

            //int V = 7;
            //int[,] edges = { { 1, 2 }, { 1, 3 }, { 2, 4 }, { 3, 4 }, { 4, 5 }, { 4, 6 }, { 5, 6 }, { 6, -1 } };
            //TopologicalSortUsingDFS(edges, V);

            //int V = 6;
            //int[,] edges = { { 1, 2 }, { 1, 3 }, { 2, 5 }, { 3, 5 }, { 4, -1 }, { 5, 4 } };
            //TopologicalSortUsingKahnsAlgo(edges, V);

            //int V = 10;
            //int[,] edges = { { 1, 2 }, { 1, 3 }, { 1, 4 }, { 2, 5 }, { 3, 8 }, { 4, 6 }, { 5, 8 }, { 6, 7 }, { 7, 8 }, { 8, -1 } };
            //int source = 1;
            //int destination = 7;
            //ShortestPathForUndirectedGraph(edges, V, source, destination);

            //int source = 0;
            //ShortestDistanceForWeightedGraph(source);

            //int source = 0;
            //ShortestPathUsingDijkstra(source, 5);

            //ShortestPathUsingDijkstraTwo();

            //MSTUsingPrimsAlgo();

            //int[,] graph = new int[,] { { 0, 0, 0, 0, 0, 0, 0 },
            //                  { 0, 0, 2, 0, 1, 4, 0 },
            //                  { 0, 0, 0, 3, 3, 0, 7 },
            //                  { 0, 0, 0, 0, 0, 0, 7},
            //                  { 0, 0, 0, 5, 0, 9, 0 },
            //                  { 0, 0, 0, 0, 0, 0, 0},
            //                  { 0, 0, 0, 0, 0, 0, 0 }};
            //int vertex = 7;
            //MSTUsingKruskalAlog(vertex);

            int[,] edges = { { 0, 1 }, { 0, 2 }, { 0, 3 }, { 1, 2 }, { 3, 0 }, { 3, 4 }, { 4, 3 } };
            int vertex = 5;
            BridgesInGraph(edges, vertex);

            #endregion

            Console.ReadLine();
        }

        #region Helper Methods

        public static void SockMerchant()
        {
            int count = 0;

            int n = 9;
            int[] arr = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            HashSet<int> unmatchedPairs = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (unmatchedPairs.Contains(arr[i]))
                {
                    count++;
                    unmatchedPairs.Remove(arr[i]);
                }
                else
                {
                    unmatchedPairs.Add(arr[i]);
                }
            }

            Console.WriteLine("Sock Pairs: {0}", count.ToString());
        }

        public static void Candles()
        {
            List<int> candles = new List<int> { 3, 2, 1, 3 };

            int maxValue = int.MinValue;
            //int result = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < candles.Count(); i++)
            {
                maxValue = Math.Max(maxValue, candles[i]);
                if (maxValue == candles[i])
                {
                    if (!dict.ContainsKey(maxValue))
                    {
                        dict.Add(candles[i], 1);
                    }
                    else
                    {
                        dict[candles[i]]++;
                    }
                }
            }

            int Max = 0;
            bool result = dict.TryGetValue(maxValue, out Max);

            Console.WriteLine(Max.ToString());

        }

        public static void LeftRotation()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int d = 2;

            int n = arr.Length;
            SwapLeftRotation(arr, 0, d - 1);
            SwapLeftRotation(arr, d, n - 1);
            SwapLeftRotation(arr, 0, n - 1);

            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        public static void SwapLeftRotation(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public static void SparesArray()
        {
            string[] queries = new string[] { "de", "lmn", "fgh" }; ;
            string[] stringList = new string[] { "def", "de", "fgh" };
            Dictionary<string, int> dictQueries = new Dictionary<string, int>();
            for (int i = 0; i < queries.Count(); i++)
            {
                dictQueries.Add(queries[i], 0);
            }

            for (int i = 0; i < stringList.Count(); i++)
            {
                if (dictQueries.ContainsKey(stringList[i]))
                {
                    dictQueries[stringList[i]]++;
                }
            }

            List<int> numTimes = new List<int>();
            foreach (var item in dictQueries)
            {
                numTimes.Add(item.Value);
            }

            foreach (var item in numTimes)
            {
                Console.WriteLine(item);
            }
        }

        public static void SparseArrayTimeComplexity()
        {
            string[] queries = new string[] { "de", "lmn", "fgh" }; ;
            string[] stringList = new string[] { "def", "de", "fgh" };

            foreach (var item in queries)
            {
                Console.WriteLine(Array.FindAll(stringList, x => x == item).Count().ToString());
            }
        }

        //GFG
        public static void QuickSortingGFG(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = PartitionGFG(arr, low, high);

                QuickSortingGFG(arr, low, pi - 1);
                QuickSortingGFG(arr, pi + 1, high);
            }
        }


        //GFG-Partition
        public static int PartitionGFG(int[] arr, int low, int high)
        {
            // Choosing the pivot
            int pivot = arr[high];

            // Index of smaller element and indicates
            // the right position of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {

                    // Increment index of smaller element
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        //GFG Partition

        //Algo- Bari
        public static void QuickSorting(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSorting(arr, low, pi - 1);
                QuickSorting(arr, pi + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            //Choosing  the Pivot
            int pivot = arr[low];

            //Index of highest element so far.
            int j = high;

            for (int i = high; i > low; i--)
            {
                if (arr[i] > pivot)
                {
                    Swap(arr, i, j);
                    j--;
                }
            }

            Swap(arr, low, j);

            return j;
        }

        public static void MountainSequence()
        {
            int[] arr = new int[] { 2, 3, 5, 1, 4 };

            Array.Sort(arr);
            int mid = arr.Length / 2;
            int end = arr.Length - 1;

            Swap(arr, mid, end);
            int start = mid + 1;

            while (start < end)
            {
                Swap(arr, start, start + 1);
                start++;
            }

            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
        }

        public static void ZigZagSequence()
        {
            int[] arr = new int[] { 10, 2, 3, 5, 1, 4 };

            int i = 0;
            int end = arr.Length - 1;
            bool flag = true;
            while (i < end)
            {
                if (arr[i] < arr[i + 1] && flag)
                {
                    flag = false;
                    i++;
                    continue;
                }
                else if (arr[i] > arr[i + 1] && !flag)
                {
                    flag = true;
                    i++;
                    continue;
                }

                Swap(arr, i, i + 1);
                flag = !flag;
                i++;
            }


            foreach (var item in arr)
            {
                Console.Write("{0} ", item.ToString());
            }
        }

        public static void SpiralMatrix()
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };
            int lastRow = arr.GetLength(0) - 1;
            int lastColumn = arr.GetLength(1) - 1;
            List<int> list = new List<int>();
            int k = 0, l = 0;

            while (k <= lastRow && l <= lastColumn)
            {
                for (int i = l; i <= lastColumn; i++)
                {
                    list.Add(arr[k, i]);
                }
                k++;

                for (int j = k; j <= lastRow; j++)
                {
                    list.Add(arr[j, lastColumn]);
                }
                lastColumn--;

                if (k <= lastRow)
                {
                    for (int i = lastColumn; i >= l; i--)
                    {
                        list.Add(arr[lastRow, i]);
                    }
                    lastRow--;
                }

                if (l <= lastColumn)
                {
                    for (int j = lastRow; j >= k; j--)
                    {
                        list.Add(arr[j, l]);
                    }
                    l++;
                }

            }

            foreach (var item in list)
            {
                Console.Write("{0} ", item.ToString());
            }

        }

        public static void BubbleSort(ref int[] arr)
        {
            int n = arr.Length;
            while (n > 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                    }
                }
                n--;
            }
        }

        public static void CopyArray(int[] arr, ref int[] secondAr)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = low + (high - low) / 2;

            int len1 = mid - low + 1;
            int len2 = high - mid;

            int[] first = new int[len1];
            int[] second = new int[len2];

            int mainArray = low;
            for (int i = 0; i < len1; i++)
            {
                first[i] = arr[mainArray];
                mainArray++;
            }

            mainArray = mid + 1;
            for (int i = 0; i < len2; i++)
            {
                second[i] = arr[mainArray];
                mainArray++;
            }

            int index1 = 0;
            int index2 = 0;
            mainArray = 0;
            while (index1 < len1 && index2 < len2)
            {
                if (first[index1] < second[index2])
                {
                    secondAr[mainArray] = first[index1];
                    mainArray++;
                    index1++;
                }
                else
                {
                    secondAr[mainArray] = second[index2];
                    index2++;
                    mainArray++;
                }
            }

            while (index1 < len1)
            {
                secondAr[mainArray] = first[index1];
                mainArray++;
                index1++;
            }

            while (index2 < len2)
            {
                secondAr[mainArray] = second[index2];
                mainArray++;
                index2++;
            }
        }

        #endregion

        #region Recursion

        public static int Factorial(int n)
        {
            //base case
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);

        }

        public static void PrintCount(int n)
        {
            //Base case
            if (n == 0)
            {
                return;
            }

            #region Tail Recursion

            //Console.Write(n + " "); 
            //PrintCount(n - 1); 

            #endregion

            #region Head Recursion

            PrintCount(n - 1);
            Console.Write(n + " ");

            #endregion
        }

        public static void ReachHome(int src, int destination)
        {
            Console.WriteLine("Source {0} Destination {1}", src.ToString(), destination.ToString());
            //base case
            if (src == destination)
            {
                Console.WriteLine("Reached Home");
                return;
            }

            src++;
            ReachHome(src, destination);
        }

        public static int Fibonacci(int n)
        {
            //base case
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int CountDistinctWays(int nStairs)
        {
            //base case
            if (nStairs < 0)
            {
                return 0;
            }

            if (nStairs == 0)
            {
                return 1;
            }

            int ans = CountDistinctWays(nStairs - 1) + CountDistinctWays(nStairs - 2);
            return ans;
        }

        public static void SayDigits(int n, string[] arr)
        {
            //Base case
            if (n == 0)
            {
                return;
            }


            int digit = n % 10;
            n = n / 10;

            SayDigits(n, arr);
            Console.Write(arr[digit] + " ");
        }

        public static int SumArray(int[] arr, int size)
        {
            //Base Case
            if (size <= 0)
            {
                return 0;
            }

            int smallProblem = arr[size - 1];
            Console.WriteLine(smallProblem.ToString());
            int bigProblem = SumArray(arr, size - 1);
            int ans = smallProblem + bigProblem;

            //int ans = SumArray(arr, size - 1) + arr[size - 1];
            return ans;
        }

        public static bool LinearSearch(int[] arr, int n, int numToSearch)
        {
            //Base Case
            if (n == 0)
            {
                return false;
            }

            int num = arr[n - 1];
            Console.Write(num.ToString() + " ");
            if (numToSearch == num)
            {
                return true;
            }

            //Recursive Call
            bool result = LinearSearch(arr, n - 1, numToSearch);
            return result;

        }

        public static bool BinarySearch(int[] arr, int low, int high, int key)
        {
            PrintArray(arr, low, high);
            Console.WriteLine("\n");

            //base Case
            if (low > high)
            {
                return false;
            }

            //Processing
            int mid = low + (high - low) / 2;
            Console.WriteLine("Value of arr mid {0}", arr[mid].ToString());
            if (arr[mid] == key) { return true; }
            else
            {
                //Recursive Call
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, low, mid - 1, key);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, high, key);
                }
            }
        }

        public static void ReverString(ref char[] s, int low, int high)
        {
            //base case
            //if (low > high)
            if (low > s.Length - low - 1) //Using Single pointer
            {
                return;
            }

            //Processing
            //SwapChar(s, low, high);
            SwapChar(s, low, s.Length - low - 1);
            low++;
            high--;

            //Recursive Call
            //ReverString(ref s, low, high);
            ReverString(ref s, low, s.Length - low - 1);
        }

        public static int PowerOfNumber(int a, int b)
        {
            //base case 
            if (b == 0)
            {
                return 1;
            }

            if (b == 1)
            {
                return a;
            }

            //Recursive call
            int ans = PowerOfNumber(a, b / 2);

            //Processing
            // if b is even
            if (b % 2 == 0)
            {
                return ans * ans;
            }
            else
            {
                // if b is odd
                return a * (ans * ans);
            }
        }

        public static void BubbleSortRecurrsion(ref int[] arr, int n)
        {
            //Base case
            if (n == 0 || n == 1)
            {
                return;
            }

            //Processing
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(arr, i, i + 1);
                }
            }

            //Recursive Call
            BubbleSortRecurrsion(ref arr, n - 1);
        }

        public static void MergeSortRecursion(ref int[] arr, int low, int high)
        {
            //Base Case
            if (low >= high)
            {
                return;
            }

            int mid = low + (high - low) / 2;

            //Left Part Sort
            MergeSortRecursion(ref arr, low, mid);

            //Right Part Sort
            MergeSortRecursion(ref arr, mid + 1, high);

            //Merge both
            Merge(ref arr, low, high);
        }

        public static void Merge(ref int[] arr, int low, int high)
        {
            int mid = low + (high - low) / 2;

            int len1 = mid - low + 1;
            int len2 = high - mid;

            int[] first = new int[len1];
            int[] second = new int[len2];

            //Copy values
            int mainArrayIndex = low;
            for (int i = 0; i < len1; i++)
            {
                first[i] = arr[mainArrayIndex];
                mainArrayIndex++;
            }

            mainArrayIndex = mid + 1;
            for (int i = 0; i < len2; i++)
            {
                second[i] = arr[mainArrayIndex];
                mainArrayIndex++;
            }

            //Sort Add
            int index1 = 0;
            int index2 = 0;
            mainArrayIndex = low;

            while (index1 < len1 && index2 < len2)
            {
                if (first[index1] < second[index2])
                {
                    arr[mainArrayIndex] = first[index1];
                    mainArrayIndex++;
                    index1++;
                }
                else
                {
                    arr[mainArrayIndex] = second[index2];
                    mainArrayIndex++;
                    index2++;
                }
            }

            while (index1 < len1)
            {
                arr[mainArrayIndex] = first[index1];
                mainArrayIndex++;
                index1++;
            }

            while (index2 < len2)
            {
                arr[mainArrayIndex] = second[index2];
                mainArrayIndex++;
                index2++;
            }
        }

        public static void QuickSortRecursion(ref int[] arr, int low, int high)
        {
            //base case
            if (low >= high)
            {
                return;
            }

            //Partition
            int pi = PartitionRecursion(arr, low, high);

            //Left Quick Sort
            QuickSortRecursion(ref arr, low, pi - 1);

            //Right Quick Sort
            QuickSortRecursion(ref arr, pi + 1, high);
        }

        public static int PartitionRecursion(int[] arr, int low, int high)
        {
            //Pivot
            int pivot = arr[low];

            //Count of elements less than pivot
            int count = 0;
            for (int i = low + 1; i <= high; i++)
            {
                if (arr[i] <= pivot)
                {
                    count++;
                }
            }

            //Place Pivot is correct position
            int pivotIndex = count + low;
            Swap(arr, pivotIndex, low);

            //Placing all values < pivot to left and all values > pivot to right
            int j = low, k = high;
            while (j < pivotIndex && k > pivotIndex)
            {
                while (arr[j] <= pivot)
                {
                    j++;
                }

                while (arr[k] > pivot)
                {
                    k--;
                }

                if (j < pivotIndex && k > pivotIndex)
                {
                    Swap(arr, j, k);
                    j++;
                    k--;
                }
            }

            return pivotIndex;
        }

        /// <summary>
        /// Leet Code- 78
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            ans.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                int count = ans.Count();
                for (int j = 0; j < count; j++)
                {
                    var temp = ans[j].ToList();
                    temp.Add(nums[i]);
                    ans.Add(temp);
                }
            }

            return ans;

        }

        #endregion

        #region Graphs

        //public static void ArrayData()
        //{
        //    int[,] arr = { { 1, 2 }, { 2, 3 }, { 4, 5 }, { 1, 5 } };
        //    int count = 0;

        //    int row = arr.GetLength(0);
        //    int col = arr.GetLength(1);
        //    for (int i = 0; i < row; i++)
        //    {
        //        for (int j = 0; j < col; j++)
        //        {
        //            Console.Write(arr[i, j].ToString() + " ");
        //        }
        //        Console.WriteLine("\n");
        //    }
        //}

        public static void AdjacencyMatrix()
        {
            int N = 3; //Number of Vertices
            int M = 3; //Number of Edges

            int[,] AdjMatrix = new int[N, N];
            int[,] arr = { { 0, 1 }, { 1, 2 }, { 2, 0 } };
            int rowSize = arr.GetLength(0);
            int colSize = arr.GetLength(1);
            Console.WriteLine($"Row Size: {rowSize.ToString()}");
            Console.WriteLine($"Col Size: {colSize.ToString()}");

            FillAdjacencyMatrix(arr, ref AdjMatrix, N, M, true);
            Print2DArray(AdjMatrix);
        }

        public static void FillAdjacencyMatrix(int[,] arr, ref int[,] adjMatrix, int N, int M, bool directed)
        {
            //M = arr.Length / arr.GetLength(0);
            //Traverse the array of Edges
            for (int i = 0; i < M; i++)
            {
                int x = arr[i, 0];
                int y = arr[i, 1];

                adjMatrix[x, y] = 1;
                if (!directed)
                {
                    adjMatrix[y, x] = 1;
                }
            }
        }

        public static void AdjacencyList()
        {
            //Test case-1
            //int V = 3;
            //int[,] edges = { { 0, 1 }, { 1, 2 }, { 2, 0 } };

            //Test case-1
            int V = 4;
            int[,] edges = { { 0, 1 }, { 1, 2 }, { 1, 3 }, { 2, 3 }, { 3, 0 } };
            int rowSize = edges.GetLength(0);

            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            PrepareAdjList(edges, rowSize, ref adjList, true);
            foreach (var item in adjList)
            {
                Console.Write($"Vertex: {item.Key}-> ");
                foreach (var Values in item.Value)
                {
                    Console.Write(Values + ", ");
                }
            }
        }

        public static void PrepareAdjList(int[,] arr, int listSize, ref Dictionary<int, List<int>> adjList, bool directed)
        {
            for (int i = 0; i < listSize; i++)
            {
                int u = arr[i, 0];
                int v = arr[i, 1];
                if (adjList.ContainsKey(u))
                {
                    adjList[u].Add(v);
                }
                else
                {
                    adjList.Add(u, new List<int>() { v });
                }

                if (!directed)
                {
                    if (adjList.ContainsKey(v))
                    {
                        adjList[v].Add(u);
                    }
                    else
                    {
                        adjList.Add(v, new List<int>() { u });
                    }
                }
            }
        }

        public static void BFSTraversal(int[,] edges, int vertex)
        {
            List<int> nodeBFS = new List<int>();

            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            PrepareAdjList(edges, vertex, ref adjList, false);
            Dictionary<int, bool> vistedEdges = new Dictionary<int, bool>();

            //Initialize all vistedEdges = false;
            foreach (var item in adjList.Keys)
            {
                vistedEdges.Add(item, false);
            }

            for (int i = 0; i < vertex; i++)
            {
                if (!vistedEdges[i])
                {
                    BFS(adjList, ref vistedEdges, ref nodeBFS, i);
                }
            }

            //Print BFS Traversal
            Console.Write("BFS Traversal->  ");
            foreach (var item in nodeBFS)
            {
                Console.Write(item + ", ");
            }
        }

        public static void BFS(Dictionary<int, List<int>> adjList, ref Dictionary<int, bool> vistedEdges, ref List<int> nodeBFS, int node)
        {
            Queue<int> qNode = new Queue<int>();
            qNode.Enqueue(node);

            while (qNode.Count() != 0)
            {
                int frontNode = qNode.Dequeue();

                //Store FrontNode into ans
                if (!vistedEdges[frontNode])
                {
                    nodeBFS.Add(frontNode);
                }

                //Traverse all neighbours of frontNode
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(frontNode, out values);
                if (result)
                {
                    if (!vistedEdges[frontNode])
                    {
                        vistedEdges[frontNode] = true;
                        foreach (var neighbours in values)
                        {
                            qNode.Enqueue(neighbours);
                        }
                    }
                }
            }
        }

        public static void DFSTraversal(int[,] edges, int vertex)
        {
            List<int> nodeDFS = new List<int>();
            //Prepare AdjList
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, false);
            Dictionary<int, bool> vistedEdges = new Dictionary<int, bool>();

            //Initialize all Visited Edges to false
            foreach (var item in adjList.Keys)
            {
                vistedEdges[item] = false;
            }

            for (int i = 2; i < vertex; i++)
            {
                if (!vistedEdges[i])
                {
                    DFS(adjList, ref nodeDFS, ref vistedEdges, i);
                }
            }

            //Print BFS Traversal
            Console.Write("DFS Traversal->  ");
            foreach (var item in nodeDFS)
            {
                Console.Write(item + ", ");
            }
        }

        public static void DFS(Dictionary<int, List<int>> adjList, ref List<int> nodeDFS, ref Dictionary<int, bool> vistedEdges, int node)
        {
            Stack<int> sNode = new Stack<int>();
            sNode.Push(node);

            while (sNode.Count() != 0)
            {
                int topNode = sNode.Pop();
                if (!vistedEdges[topNode])
                {
                    nodeDFS.Add(topNode);
                }
                else
                {
                    return;
                }

                //Traverse neighbours until null
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(topNode, out values);
                if (result)
                {
                    if (!vistedEdges[topNode])
                    {
                        vistedEdges[topNode] = true;
                        foreach (var neighbour in values)
                        {
                            DFS(adjList, ref nodeDFS, ref vistedEdges, neighbour);
                        }
                    }
                }
            }
        }

        #region Cycle for Undirected Graph
        public static void CycleDetectionUsingBFS(int[,] edges, int vertex)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, true); // making graph as directed just for better understanding

            //Initialize Visited Edges 
            Dictionary<int, bool> visitedEdges = new Dictionary<int, bool>();
            foreach (var item in adjList.Keys)
            {
                visitedEdges[item] = false;
            }

            for (int i = 0; i < vertex; i++)
            {
                bool isCycleFound = isCyclicBFS(adjList, ref visitedEdges, i);
                if (isCycleFound)
                {
                    Console.WriteLine("Cycle Found using BFS");
                    return;
                }
            }
        }

        public static bool isCyclicBFS(Dictionary<int, List<int>> adjList, ref Dictionary<int, bool> visitedEdges, int node)
        {
            //Parent to keep track of vertex source
            Dictionary<int, int> parent = new Dictionary<int, int>();
            Queue<int> qNode = new Queue<int>();
            qNode.Enqueue(node);
            parent[node] = -1;

            while (qNode.Count() > 0)
            {
                int frontNode = qNode.Dequeue();
                List<int> values = new List<int>();
                bool v = adjList.TryGetValue(frontNode, out values);
                if (values != null)
                {
                    if (!visitedEdges[frontNode])
                    {
                        visitedEdges[frontNode] = true;
                        foreach (var neighbour in values)
                        {
                            if (visitedEdges[neighbour] && parent[frontNode] != neighbour)
                            {
                                return true;
                            }
                            if (!visitedEdges[neighbour] && !qNode.Contains(neighbour))
                            {
                                qNode.Enqueue(neighbour);
                                parent[neighbour] = frontNode;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public static void CyclicDetectionUsingDFS(int[,] edges, int vertex)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, true); // making graph as directed just for better understanding

            //Visted Egdes
            Dictionary<int, bool> visted = new Dictionary<int, bool>();
            foreach (var item in adjList.Keys)
            {
                visted[item] = false;
            }

            //Parent of each verttex
            Dictionary<int, int> parent = new Dictionary<int, int>();

            //Cycle Detection
            for (int i = 0; i < vertex; i++)
            {
                bool isCycleFound = IsCycleDFS(adjList, ref visted, ref parent, -1, i);
                if (isCycleFound)
                {
                    Console.WriteLine("Cycle Found using DFS");
                    return;
                }
            }
        }

        public static bool IsCycleDFS(Dictionary<int, List<int>> adjList, ref Dictionary<int, bool> visted, ref Dictionary<int, int> parent, int p, int node)
        {
            Stack<int> sNode = new Stack<int>();
            sNode.Push(node);
            parent[node] = p;

            while (sNode.Count() > 0)
            {
                int topNode = sNode.Pop();
                //Visit Neighbours
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(topNode, out values);
                if (result)
                {
                    if (!visted[topNode])
                    {
                        visted[topNode] = true;
                        foreach (var neighbours in values)
                        {
                            if (!visted[neighbours])
                            {
                                bool isCycle = IsCycleDFS(adjList, ref visted, ref parent, topNode, neighbours);
                                if (isCycle)
                                {
                                    return true;
                                }
                            }
                            else if (neighbours != parent[topNode])
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
        #endregion

        #region Cycle for Directed Graph

        public static void CycleUsingDFSForDirected(int[,] edges, int vertex)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, true);

            //Visited edges
            Dictionary<int, bool> visited = new Dictionary<int, bool>();

            //Visited DFS
            Dictionary<int, bool> dfsVisited = new Dictionary<int, bool>();

            foreach (var item in adjList.Keys)
            {
                visited[item] = false;
                dfsVisited[item] = false;
            }

            //Cycle Call
            for (int i = 0; i < vertex; i++)
            {
                bool isCycleFound = IsCycleDFSForDirected(adjList, ref visited, ref dfsVisited, i);
                if (isCycleFound)
                {
                    Console.WriteLine("Cycle found using DFS for directed Graph");
                }
            }
        }

        public static bool IsCycleDFSForDirected(Dictionary<int, List<int>> adjList, ref Dictionary<int, bool> visited, ref Dictionary<int, bool> dfsVisited, int node)
        {
            Stack<int> sNode = new Stack<int>();
            sNode.Push(node);

            while (sNode.Count() > 0)
            {
                int topNode = sNode.Pop();
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(topNode, out values);
                if (result)
                {
                    if (!visited[topNode])
                    {
                        visited[topNode] = true;
                        dfsVisited[topNode] = true;
                        foreach (var neighbour in values)
                        {
                            if (visited.ContainsKey(neighbour) && !visited[neighbour])
                            {
                                bool isCycleDetected = IsCycleDFSForDirected(adjList, ref visited, ref dfsVisited, neighbour);
                                if (isCycleDetected)
                                {
                                    return true;
                                }
                            }
                            else if (dfsVisited.ContainsKey(neighbour) && dfsVisited[neighbour])
                            {
                                return true;
                            }
                        }
                    }
                }
                dfsVisited[topNode] = false;
            }
            return false;
        }

        #endregion

        #region Topological Sort

        /// <summary>
        /// Topological Sort can only be performed for acyclic graphs
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="vertex"></param>
        public static void TopologicalSortUsingDFS(int[,] edges, int vertex)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, true);

            //Visited edges
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            foreach (var item in adjList.Keys)
            {
                visited[item] = false;
            }

            //Stack to store node whose DFS is completed
            Stack<int> stack = new Stack<int>();

            //Perform DFS
            for (int i = 0; i < vertex; i++)
            {
                TopologicalSortUsingDFS(adjList, ref visited, ref stack, i);
                var isFalse = visited.Where(x => x.Value != true).Count();
                if (isFalse == 0)
                {
                    break;
                }
            }

            PrintAdjList(adjList);

            Console.Write("Toplogical Sort Using DFS -> ");
            while (stack.Count() > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }

        public static void TopologicalSortUsingDFS(Dictionary<int, List<int>> adjList, ref Dictionary<int, bool> visited, ref Stack<int> stackAns, int node)
        {
            Stack<int> sNode = new Stack<int>();
            sNode.Push(node);

            while (sNode.Count() > 0)
            {
                int topNode = sNode.Pop();
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(topNode, out values);
                if (result)
                {
                    if (visited.ContainsKey(topNode) && !visited[topNode])
                    {
                        visited[topNode] = true;
                        foreach (var neigbour in values)
                        {
                            if (visited.ContainsKey(neigbour) && !visited[neigbour])
                            {
                                TopologicalSortUsingDFS(adjList, ref visited, ref stackAns, neigbour);
                            }
                        }
                    }
                }

                if (visited.ContainsKey(topNode) && visited[topNode])
                {
                    stackAns.Push(topNode);
                }
            }
        }

        /// <summary>
        /// Topological Sort using Kahn's Algo
        /// 1 -> Find Indegree of all nodes
        /// 2 -> Add all 0 Indegree node to queue
        /// 3 -> Do BFS
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="vertex"></param>
        public static void TopologicalSortUsingKahnsAlgo(int[,] edges, int vertex)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, true);

            //Find Indegree of all nodes
            int[] inDegree = new int[vertex];

            foreach (var item in adjList)
            {
                foreach (var values in item.Value.Where(x => x != -1))
                {
                    inDegree[values]++;
                }
            }

            //Push 0 indegree to queue
            Queue<int> qNode = new Queue<int>();
            for (int i = 0; i < inDegree.Length; i++)
            {
                if (inDegree[i] == 0)
                {
                    qNode.Enqueue(i);
                }
            }

            //Perform BFS
            List<int> ans = new List<int>();

            while (qNode.Count() > 0)
            {
                int frontNode = qNode.Dequeue();

                //Ans store
                ans.Add(frontNode);

                //neighbour Indegree update
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(frontNode, out values);
                if (result)
                {
                    foreach (var neighbour in values.Where(x => x != -1))
                    {
                        inDegree[neighbour]--;
                        if (inDegree[neighbour] == 0)
                        {
                            qNode.Enqueue(neighbour);
                        }
                    }
                }
            }

            ans.RemoveAt(0);


            PrintAdjList(adjList);

            Console.Write("Topological Sort using Kahn's Algo and BFS -> ");
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
        }

        #endregion

        #region Shortest Distance in Undirected Graph

        public static void ShortestPathForUndirectedGraph(int[,] edges, int vertex, int source, int destination)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, false); //Using Directed for better understanding

            //Visited & Parent DS
            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            Dictionary<int, int> parent = new Dictionary<int, int>();

            //Initialize all visited to false
            foreach (var item in adjList.Keys)
            {
                visited[item] = false;
            }

            //Perform BFS
            Queue<int> qNode = new Queue<int>();
            var value = edges[0, 0];
            qNode.Enqueue(value);
            parent[value] = -1;

            while (qNode.Count() > 0)
            {
                int frontNode = qNode.Dequeue();
                List<int> values = new List<int>();
                bool result = adjList.TryGetValue(frontNode, out values);
                if (result)
                {
                    if (!visited[frontNode])
                    {
                        visited[frontNode] = true;
                        foreach (var neighbour in values.Where(x => x != -1))
                        {
                            if (!visited[neighbour])
                            {
                                if (!qNode.Contains(neighbour))
                                {
                                    qNode.Enqueue(neighbour);
                                    parent[neighbour] = frontNode;
                                }
                            }
                        }
                    }
                }
            }

            List<int> ans = new List<int>();

            //Get Shortest path from parent
            int currentNode = destination;
            ans.Add(currentNode);
            while (currentNode != source)
            {
                currentNode = parent[currentNode];
                ans.Add(currentNode);
            }

            ans.Reverse();
            Console.Write($"Shortest path from {source} to {destination}: ");
            foreach (var item in ans)
            {
                Console.Write(item + "-> ");
            }
        }

        #endregion

        #region Shortest Distance in Directed weighted Graph

        public static void ShortestDistanceForWeightedGraph(int source)
        {
            //Prepare AdjList with weighted edges.
            Graph g = new Graph();
            g.AddEdegesWithWeight(0, 1, 5);
            g.AddEdegesWithWeight(0, 2, 3);
            g.AddEdegesWithWeight(1, 2, 2);
            g.AddEdegesWithWeight(1, 3, 6);
            g.AddEdegesWithWeight(2, 3, 7);
            g.AddEdegesWithWeight(2, 4, 4);
            g.AddEdegesWithWeight(2, 5, 2);
            g.AddEdegesWithWeight(3, 4, -1);
            g.AddEdegesWithWeight(4, 5, -2);

            g.PrintAdjList();

            Dictionary<int, bool> visited = new Dictionary<int, bool>();
            for (int i = 0; i < 6; i++)
            {
                visited[i] = false;
            }
            Stack<int> ans = new Stack<int>();

            //Topological Sort
            for (int i = 0; i < 6; i++)
            {
                if (!visited[i])
                {
                    DFSWeighted(g.adjList, ref visited, ref ans, i);
                }
            }

            //Distance DS
            int[] distance = new int[6];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = int.MaxValue;
            }

            //Use ans to get the shortest distance from source to each node
            distance[source] = 0;

            ShortestPathWeight(source, ref ans, ref distance, g.adjList);

            //Print Distance
            Console.Write($"Shortest Path from Source {source} to each node: -> ");
            foreach (var item in distance)
            {
                Console.Write(item + ", ");
            }
        }

        public static void DFSWeighted(Dictionary<int, Dictionary<int, int>> adjList, ref Dictionary<int, bool> visited, ref Stack<int> ans, int node)
        {
            Stack<int> sNode = new Stack<int>();
            sNode.Push(node);

            while (sNode.Count() > 0)
            {
                int topNode = sNode.Pop();
                Dictionary<int, int> item = new Dictionary<int, int>();
                bool result = adjList.TryGetValue(topNode, out item);
                if (result)
                {
                    if (visited.ContainsKey(topNode) && !visited[topNode])
                    {
                        visited[topNode] = true;
                        foreach (var neighbour in item)
                        {
                            if (visited.ContainsKey(neighbour.Key) && !visited[neighbour.Key])
                            {
                                DFSWeighted(adjList, ref visited, ref ans, neighbour.Key);
                            }
                        }
                    }
                }
                if (!ans.Contains(topNode))
                {
                    ans.Push(topNode);
                }
            }
        }

        public static void ShortestPathWeight(int source, ref Stack<int> ans, ref int[] distance, Dictionary<int, Dictionary<int, int>> adjList)
        {
            while (ans.Count() > 0)
            {
                int topNode = ans.Pop();
                foreach (var item in adjList)
                {
                    int distanceFromSource = distance[topNode];
                    if (item.Key == topNode)
                    {
                        if (distanceFromSource != int.MaxValue)
                        {
                            Dictionary<int, int> values = new Dictionary<int, int>();
                            bool result = adjList.TryGetValue(item.Key, out values);
                            if (result)
                            {
                                foreach (var neighbour in values)
                                {
                                    int weightOfNode = distance[topNode] + neighbour.Value;
                                    distance[neighbour.Key] = Math.Min(distance[neighbour.Key], weightOfNode);
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        #endregion

        #region Shortest Path using Dijkstra's Algo

        public static void ShortestPathUsingDijkstra(int source, int vertex)
        {
            //Prepare AdjList with weighted edges.
            Graph g = new Graph();
            //g.AddEdegesWithWeight(0, 1, 7);
            //g.AddEdegesWithWeight(0, 2, 1);
            //g.AddEdegesWithWeight(0, 3, 2);
            //g.AddEdegesWithWeight(1, 0, 7);
            //g.AddEdegesWithWeight(1, 2, 3);
            //g.AddEdegesWithWeight(1, 3, 5);
            //g.AddEdegesWithWeight(1, 4, 1);
            //g.AddEdegesWithWeight(2, 1, 3);
            //g.AddEdegesWithWeight(2, 0, 1);
            //g.AddEdegesWithWeight(3, 0, 2);
            //g.AddEdegesWithWeight(3, 1, 5);
            //g.AddEdegesWithWeight(3, 4, 7);
            //g.AddEdegesWithWeight(4, 1, 1);
            //g.AddEdegesWithWeight(4, 3, 7);

            vertex = 4;
            g.AddEdegesWithWeight(0, 1, 5);
            g.AddEdegesWithWeight(0, 2, 8);
            g.AddEdegesWithWeight(1, 0, 5);
            g.AddEdegesWithWeight(1, 2, 9);
            g.AddEdegesWithWeight(1, 3, 2);
            g.AddEdegesWithWeight(2, 0, 8);
            g.AddEdegesWithWeight(2, 1, 9);
            g.AddEdegesWithWeight(2, 3, 6);
            g.AddEdegesWithWeight(3, 1, 2);
            g.AddEdegesWithWeight(3, 2, 6);

            var adjList = g.adjList;

            //Distance for shortest Path
            int[] distance = new int[vertex];
            for (int i = 0; i < vertex; i++)
            {
                distance[i] = int.MaxValue;
            }

            //Distance from Source to source
            distance[source] = 0;

            //Set Pair of <NodeDistance, Node>
            SortedDictionary<int, int> setPair = new SortedDictionary<int, int>();
            setPair.Add(0, 0);

            while (setPair.Count > 0)
            {
                int nodeDistance = new int();
                int node = new int();
                foreach (var item in setPair)
                {
                    nodeDistance = item.Key;
                    node = item.Value;
                    break;
                }
                setPair.Remove(nodeDistance);

                Dictionary<int, int> directedNodes = new Dictionary<int, int>();
                bool result = adjList.TryGetValue(node, out directedNodes);
                if (result)
                {
                    foreach (var neighbour in directedNodes)
                    {
                        int newDistance = nodeDistance + neighbour.Value;
                        if (newDistance < distance[neighbour.Key])
                        {
                            distance[neighbour.Key] = newDistance;
                            if (setPair.ContainsValue(neighbour.Key))
                            {
                                var exisitingKey = setPair.FirstOrDefault(x => x.Value == neighbour.Key);
                                setPair.Remove(exisitingKey.Key);

                                setPair.Add(newDistance, neighbour.Key);
                            }
                            else
                            {
                                setPair.Add(newDistance, neighbour.Key);
                            }
                        }
                    }
                }
            }

            //Distance Array
            Console.Write($"Shortest Distance for Source {source}-> ");
            foreach (var item in distance)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Another Approach  of using SetPair array insted of Sorted Dictionary
        /// </summary>
        public static void ShortestPathUsingDijkstraTwo()
        {
            int source = 0;
            //Prepare Adj List
            Graph g = new Graph();
            //int vertex = 5;
            //g.AddEdegesWithWeight(0, 1, 7);
            //g.AddEdegesWithWeight(0, 2, 1);
            //g.AddEdegesWithWeight(0, 3, 2);
            //g.AddEdegesWithWeight(1, 0, 7);
            //g.AddEdegesWithWeight(1, 2, 3);
            //g.AddEdegesWithWeight(1, 3, 5);
            //g.AddEdegesWithWeight(1, 4, 1);
            //g.AddEdegesWithWeight(2, 1, 3);
            //g.AddEdegesWithWeight(2, 0, 1);
            //g.AddEdegesWithWeight(3, 0, 2);
            //g.AddEdegesWithWeight(3, 1, 5);
            //g.AddEdegesWithWeight(3, 4, 7);
            //g.AddEdegesWithWeight(4, 1, 1);
            //g.AddEdegesWithWeight(4, 3, 7);

            int vertex = 4;
            g.AddEdegesWithWeight(0, 1, 5);
            g.AddEdegesWithWeight(0, 2, 8);
            g.AddEdegesWithWeight(1, 0, 5);
            g.AddEdegesWithWeight(1, 2, 9);
            g.AddEdegesWithWeight(1, 3, 2);
            g.AddEdegesWithWeight(2, 0, 8);
            g.AddEdegesWithWeight(2, 1, 9);
            g.AddEdegesWithWeight(2, 3, 6);
            g.AddEdegesWithWeight(3, 1, 2);
            g.AddEdegesWithWeight(3, 2, 6);

            var adjList = g.adjList;

            int[] distance = new int[vertex];
            bool[] visited = new bool[vertex];

            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;

            for (int i = 0; i < vertex; i++)
            {
                int mini = int.MaxValue;
                int u = new int();

                for (int v = 0; v < vertex; v++)
                {
                    if (visited[v] == false && distance[v] < mini)
                    {
                        mini = distance[v];
                        u = v;
                    }
                }

                Dictionary<int, int> directedNode = new Dictionary<int, int>();
                bool results = adjList.TryGetValue(u, out directedNode);
                if (results)
                {
                    foreach (var neighbour in directedNode)
                    {
                        int newDistance = distance[u] + neighbour.Value;
                        distance[neighbour.Key] = Math.Min(distance[neighbour.Key], newDistance);
                    }
                }

                visited[u] = true;
            }

            //Distance Array
            Console.Write($"Shortest Distance for Source {source}-> ");
            foreach (var item in distance)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
        }

        #endregion

        #region Minimum Spanning Tree Using Prim's Algo

        public static void MSTUsingPrimsAlgo()
        {
            //Prepare Adj List
            Graph g = new Graph();
            int numNode = 5;
            int source = 0;
            g.AddEdegesWithWeight(0, 1, 2);
            g.AddEdegesWithWeight(0, 3, 6);
            g.AddEdegesWithWeight(1, 0, 2);
            g.AddEdegesWithWeight(1, 2, 3);
            g.AddEdegesWithWeight(1, 3, 8);
            g.AddEdegesWithWeight(1, 4, 5);
            g.AddEdegesWithWeight(2, 1, 3);
            g.AddEdegesWithWeight(2, 4, 7);
            g.AddEdegesWithWeight(3, 0, 6);
            g.AddEdegesWithWeight(3, 1, 8);
            g.AddEdegesWithWeight(4, 1, 5);
            g.AddEdegesWithWeight(4, 2, 7);

            var adjList = g.adjList;

            int[] key = new int[numNode];
            bool[] mst = new bool[numNode];
            int[] parent = new int[numNode];

            for (int i = 0; i < numNode; i++)
            {
                key[i] = int.MaxValue;
                mst[i] = false;
                parent[i] = -1;
            }

            //Start Algo

            //Find Minimum Key/Node
            key[source] = 0;

            for (int i = 0; i < numNode; i++)
            {
                int mini = int.MaxValue;
                int u = new int();

                for (int v = 0; v < numNode; v++)
                {
                    if (mst[v] == false && key[v] < mini)
                    {
                        u = v;
                        mini = key[v];
                    }
                }

                //Check Neighbours of Minimum key
                Dictionary<int, int> directedNode = new Dictionary<int, int>();
                bool result = adjList.TryGetValue(u, out directedNode);
                if (result)
                {
                    foreach (var item in directedNode)
                    {
                        int v = item.Key;
                        int w = item.Value;
                        if (mst[v] == false && w < key[v])
                        {
                            parent[v] = u;
                            key[v] = w;
                        }
                    }
                }
                mst[u] = true;
            }


            int sum = 0;
            for (int i = 1; i < key.Length; i++)
            {
                sum = sum + key[i];
            }
            Console.Write($"Weight of MST -> {sum}");

            Console.WriteLine("Minimum Spanning tree: ");
            for (int i = 1; i < parent.Length; i++)
            {
                int directedNode = parent[i];
                Console.Write($"{directedNode} -> {i}");
                Console.WriteLine("\n");
            }
        }

        #endregion

        #region Minimum Spanning Tree Using Kruskal's Algo

        public static void MSTUsingKruskalAlog(int vertex)
        {
            int edges = 9;
            int[] parent = new int[vertex];
            int[] rank = new int[vertex];
            MakeSet(ref parent, ref rank, vertex);

            Edge[] edge = new Edge[edges];
            for (int i = 0; i < edges; i++)
            {
                edge[i] = new Edge();
            }
            edge[0].src = 1;
            edge[0].dest = 2;
            edge[0].weight = 2;

            edge[1].src = 1;
            edge[1].dest = 5;
            edge[1].weight = 4;

            edge[2].src = 1;
            edge[2].dest = 4;
            edge[2].weight = 1;

            edge[3].src = 4;
            edge[3].dest = 5;
            edge[3].weight = 9;

            edge[4].src = 4;
            edge[4].dest = 3;
            edge[4].weight = 5;

            edge[5].src = 2;
            edge[5].dest = 4;
            edge[5].weight = 3;

            edge[6].src = 2;
            edge[6].dest = 6;
            edge[6].weight = 7;

            edge[7].src = 2;
            edge[7].dest = 3;
            edge[7].weight = 3;

            edge[8].src = 3;
            edge[8].dest = 6;
            edge[8].weight = 8;

            Array.Sort(edge);

            int minWeight = 0;
            for (int i = 0; i < edge.Length; i++)
            {
                int x = edge[i].src;
                int y = edge[i].dest;
                int u = FindParent(ref parent, x);
                int v = FindParent(ref parent, y);
                int wt = edge[i].weight;

                if (u != v)
                {
                    UnionSet(u, v, ref parent, ref rank);
                    minWeight = minWeight + wt;
                }
            }
        }

        public static void MakeSet(ref int[] parent, ref int[] rank, int vertex)
        {
            for (int i = 0; i < vertex; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public static void UnionSet(int u, int v, ref int[] parent, ref int[] rank)
        {
            u = FindParent(ref parent, u);
            v = FindParent(ref parent, v);
            if (rank[u] < rank[v])
            {
                parent[u] = v;
            }
            else if (rank[v] < rank[u])
            {
                parent[v] = u;
            }
            else
            {
                parent[v] = u;
                rank[u]++;
            }
        }

        public static int FindParent(ref int[] parent, int node)
        {
            if (parent[node] == node)
            {
                return node;
            }
            return parent[node] = FindParent(ref parent, parent[node]);
        }

        class Edge : IComparable<Edge>
        {
            public int src, dest, weight;

            // Comparator function used for sorting edges 
            // based on their weight 
            public int CompareTo(Edge compareEdge)
            {
                return this.weight - compareEdge.weight;
            }
        }

        #endregion

        #region Bridges in Graph

        public static void BridgesInGraph(int[,] edges, int vertex)
        {
            //Prepare Adj List
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            int rowSize = edges.GetLength(0);
            PrepareAdjList(edges, rowSize, ref adjList, false);

            //DS required
            int[] discoveryTime = new int[vertex];
            int[] lowestTimeRequired = new int[vertex];
            bool[] visited = new bool[vertex];
            int timer = 0;
            int parent = -1;

            Dictionary<int, int> ans = new Dictionary<int, int>();

            for (int i = 0; i < vertex; i++)
            {
                discoveryTime[i] = -1;
                lowestTimeRequired[i] = -1;
                visited[i] = false;
            }

            //Perform DFS Bridge
            for (int i = 0; i < vertex; i++)
            {
                if (!visited[i])
                {
                    DFSBridge(i, parent, adjList, ref discoveryTime, ref lowestTimeRequired, ref visited, ref timer, ref ans);
                }
            }

            Console.WriteLine("Bridges in Graph");
            foreach (var item in ans)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }

        public static void DFSBridge(int node, int parent, Dictionary<int, List<int>> adjList, ref int[] discoveryTime, ref int[] lowestTimeRequired, ref bool[] visited, ref int timer,
            ref Dictionary<int, int> ans)
        {
            discoveryTime[node] = lowestTimeRequired[node] = timer;
            timer++;

            List<int> values = new List<int>();
            bool result = adjList.TryGetValue(node, out values);
            if (result)
            {
                if (!visited[node])
                {
                    visited[node] = true;
                    foreach (var neighbour in values)
                    {
                        //Check neighbour == parent, if yes ->ignore
                        if (neighbour == parent)
                        {
                            continue;
                        }
                        if (!visited[neighbour])
                        {
                            DFSBridge(neighbour, node, adjList, ref discoveryTime, ref lowestTimeRequired, ref visited, ref timer, ref ans);
                            lowestTimeRequired[node] = Math.Min(lowestTimeRequired[node], lowestTimeRequired[neighbour]);
                            //Check Bridge
                            if (lowestTimeRequired[neighbour] > discoveryTime[node])
                            {
                                ans.Add(node, neighbour);
                            }
                        }
                        else
                        {
                            //Back Edge
                            lowestTimeRequired[node] = Math.Min(lowestTimeRequired[node], discoveryTime[neighbour]);
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

        #region Common Methods

        public static void PrintAdjList(Dictionary<int, List<int>> adjList)
        {
            foreach (var item in adjList)
            {
                Console.Write($"Vertex: {item.Key}-> ");
                foreach (var Values in item.Value)
                {
                    Console.Write(Values + ", ");
                }
            }
            Console.WriteLine("\n");
        }

        public static void PrintArray(int[] arr, int low, int high)
        {
            for (int i = low; i < high; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
        }

        public static void PrintCharArray(char[] arr, int low, int high)
        {
            string s = string.Empty;

            for (int i = low; i < high; i++)
            {
                s = s + arr[i];
            }
            Console.WriteLine(s);
        }


        public static void SwapChar(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Print2DArray(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
        }


        #endregion
    }

    #region Graph

    public class Graph
    {
        public Dictionary<int, Dictionary<int, int>> adjList = new Dictionary<int, Dictionary<int, int>>();
        public void AddEdegesWithWeight(int parentNode, int directedNode, int weight)
        {
            Dictionary<int, int> uv = new Dictionary<int, int>();
            uv.Add(directedNode, weight);
            if (adjList.ContainsKey(parentNode))
            {
                adjList[parentNode].Add(directedNode, weight);
            }
            else
            {
                adjList.Add(parentNode, uv);
            }
        }

        public void PrintAdjList()
        {
            foreach (var item in adjList)
            {
                Console.Write(item.Key + "-> ");
                foreach (var neighbour in item.Value)
                {
                    Console.Write("(" + neighbour.Key + ", " + neighbour.Value + "), ");
                }
                Console.WriteLine("\n");
            }
        }
    }

    #endregion

    #region BST 

    public class BinarySearchTree
    {
        private Node root;

        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                root.Insert(data);
            }
        }

        public void InOrderTraversal()
        {
            if (root != null)
            {
                root.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()
        {
            if (root != null)
            {
                root.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            if (root != null)
            {
                root.PostOrderTraversal();
            }
        }

        public void LevelOrderTraversal()
        {
            if (root != null)
            {
                root.LevelOrderTraversal(root);
            }
        }

        public int NumberOfLeafNode()
        {
            if (root == null)
            {
                return 0;
            }

            return root.NumberOfLeafNode();
        }
    }

    public class Node
    {
        public int data;
        public Node LeftNode;
        public Node RightNode;

        public Node(int value)
        {
            this.data = value;
            LeftNode = null;
            RightNode = null;
        }

        public void Insert(int value)
        {
            if (value >= data)
            {
                if (RightNode == null)
                {
                    RightNode = new Node(value);
                }
                else
                {
                    RightNode.Insert(value);
                }
            }
            else
            {
                if (LeftNode == null)
                {
                    LeftNode = new Node(value);
                }
                else
                {
                    LeftNode.Insert(value);
                }
            }
        }

        /// <summary>
        /// LNR
        /// </summary>
        public void InOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.InOrderTraversal();
            }

            Console.Write(data + " ");

            if (RightNode != null)
            {
                RightNode.InOrderTraversal();
            }
        }

        /// <summary>
        /// NLR
        /// </summary>
        public void PreOrderTraversal()
        {
            Console.Write(data + " ");

            if (LeftNode != null)
            {
                LeftNode.PreOrderTraversal();
            }

            if (RightNode != null)
            {
                RightNode.PreOrderTraversal();
            }
        }

        /// <summary>
        /// LRN
        /// </summary>
        public void PostOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.PostOrderTraversal();
            }

            if (RightNode != null)
            {
                RightNode.PostOrderTraversal();
            }

            Console.Write(data + " ");
        }

        public void LevelOrderTraversal(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count() != 0)
            {
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.data + " ");

                if (tempNode.LeftNode != null)
                {
                    queue.Enqueue(tempNode.LeftNode);
                }

                if (tempNode.RightNode != null)
                {
                    queue.Enqueue(tempNode.RightNode);
                }
            }
        }

        public int Height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int heightLeft = Height(root.LeftNode);
                int heightRight = Height(root.RightNode);
                return heightLeft > heightRight ? heightLeft + 1 : heightRight + 1;
            }
        }

        public int NumberOfLeafNode()
        {
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1;
            }

            int leftLeaf = 0;
            int rightLeaf = 0;

            if (this.LeftNode != null)
            {
                leftLeaf = LeftNode.NumberOfLeafNode();
            }

            if (this.RightNode != null)
            {
                rightLeaf = RightNode.NumberOfLeafNode();
            }

            return leftLeaf + rightLeaf;
        }
    }


    #endregion
}
