namespace MyArray
{
    public class KineretArray
    {
        private int[] ints;

        public KineretArray(int[] ints)
        {
            this.ints = ints;
        }
        public void SelectSort()
        {
            int n = ints.Length;
            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (ints[j] < ints[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
               swap(ref ints[i],ref ints[min_idx]);
            }
        }
        public void Bubblesort()
        {
            for (int i = 0; i < ints.Length; i++)
                for (int j = 0; j < ints.Length-i-1; j++)
                    if (ints[j] > ints[j + 1])
                        swap(ref ints[j],ref ints[j + 1]);
        }

        public void Quick_Sort( int left, int right)
        {
            // Check if there are elements to sort
            if (left < right)
            {
                // Find the pivot index
                int pivot = Partition(ints, left, right);

                // Recursively sort elements on the left and right of the pivot
                if (pivot > 1)
                {
                    Quick_Sort( left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(pivot + 1, right);
                }
            }
        }

        // Method to partition the array
        private static int Partition(int[] arr, int left, int right)
        {
            // Select the pivot element
            int pivot = arr[left];

            // Continue until left and right pointers meet
            while (true)
            {
                // Move left pointer until a value greater than or equal to pivot is found
                while (arr[left] < pivot)
                {
                    left++;
                }

                // Move right pointer until a value less than or equal to pivot is found
                while (arr[right] > pivot)
                {
                    right--;
                }

                // If left pointer is still smaller than right pointer, swap elements
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    // Return the right pointer indicating the partitioning position
                    return right;
                }
            }
        }

        private void swap(ref int x, ref  int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public bool Find(int v)
        {
            if(ints ==null)
                throw new ArgumentNullException("ints");
            foreach (int i in ints)
            {
                if (i == v) return true;
            }
                return false;
        }
    }
}