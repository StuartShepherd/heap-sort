namespace HeapSort;

public class HeapSort
{
    public int[] Sort(int[] array)
    {
        var size = array.Length;

        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(array, size, i);
        }

        for (int i = size - 1; i >= 0; i--)
        {
            var tempVar = array[0];
            array[0] = array[i];
            array[i] = tempVar;
            Heapify(array, i, 0);
        }

        return array;
    }

    private void Heapify(
        int[] array, 
        int size, 
        int index)
    {
        var largestIndex = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;

        if (leftChild < size && array[leftChild] > array[largestIndex])
        {
            largestIndex = leftChild;
        }

        if (rightChild < size && array[rightChild] > array[largestIndex])
        {
            largestIndex = rightChild;
        }

        if (largestIndex != index)
        {
            var tempVar = array[index];
            array[index] = array[largestIndex];
            array[largestIndex] = tempVar;

            Heapify(array, size, largestIndex);
        }
    }
}
