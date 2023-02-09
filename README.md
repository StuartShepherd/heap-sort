# Heap Sort

Heap sort is a comparison-based sorting algorithm that works by constructing a binary heap data structure from the elements of the unsorted list, and repeatedly extracting the maximum element from the heap (which is always the root node) and swapping it with the last element of the list, effectively reducing the size of the heap by one. 

The process is repeated until all elements have been extracted and the list is sorted. 

Because the binary heap has logarithmic time complexity for insertions and extractions, heap sort has a time complexity of O(n log n). 

It is also an in-place sorting algorithm, meaning it does not require any extra memory to be allocated during the sorting process.