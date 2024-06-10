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

            //ArrayData();

            AdjacencyMatrix();

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
            int M = 3; // Number of Edges

            int[,] AdjMatrix = new int[N, N];
            int[,] arr = { { 0, 1 }, { 1, 2 }, { 2, 0 } };

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

        #region Common Methods

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

        #endregion
    }

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
