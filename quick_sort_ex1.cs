using System;

class QuickSorter {
    public static void QuickSort<T>(T[] array) where T: IComparable<T> {
        QuickSort(array, 0, array.Length - 1);
    }


    private static void QuickSort<T>(T[] array, int low, int high) where T: IComparable<T>
    {
        if (low < high) {
            int pivotIndex = Partition(array, low, high);
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private static int Partition<T>(T[] array, int low, int high) where T: IComparable<T> {
    T pivot = array[high];
    
    int i = low - 1;

    for (int j = low; j < high; j++) {
        if (array[j].CompareTo(pivot) <= 0) {
            i++;
            Swap(array, i, j);
        }
    }

    Swap(array, i+ 1, high);
    return i + 1;
    }

    private static void Swap<T>(T[] array, int i, int j) {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

// class Program {
//     static void Main() {
        // int[] numbers = { 34, 7, 23, 32, 5, 62};
        // QuickSorter.QuickSort(numbers);
        // Console.WriteLine(string.Join(", ", numbers));
//     }
// }

int[] numbers = { 34, 7, 23, 32, 5, 62};
QuickSorter.QuickSort(numbers);
Console.WriteLine(string.Join(", ", numbers));