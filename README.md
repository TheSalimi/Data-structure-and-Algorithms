# Sorting

## Insertion Sort
[Inserton Sort](https://www.geeksforgeeks.org/insertion-sort/) 
 is a simple sorting algorithm that builds the final sorted array (or list) one item at a time by comparisons...

###### Best case 
> when the list is already in the correct order : O(n)

###### Worst case 
> when the list is in descending order: O(n^2)

![Insertion-sort-example-300px](https://user-images.githubusercontent.com/108394058/205162632-88f31337-a2e9-480e-adee-48b8efdf5680.gif)

## Bubble Sort
[Bubble Sort](https://www.geeksforgeeks.org/bubble-sort/)
is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order. This algorithm is not suitable for large data sets as its average and worst-case time complexity is quite high.

###### Best case 
> The best case for bubble sort occurs when the list is already sorted or nearly sorted. In the case where the list is already sorted, bubble sort will terminate after the first iteration, since no swaps were made : O(n)

###### worst case
> The worst situation for bubble sort is when the list's smallest element is in the last position. In this situation, the smallest element will move down one place on each pass through the list, meaning that the sort will need to make the maximum number of passes through the list, namely n - 1 : O(n^2)

![Bubble-sort-example-300px](https://user-images.githubusercontent.com/108394058/207931294-208f5fe8-7061-489c-9836-24e2c69b292d.gif)

## Selection Sort
> In computer science, [Selection Sort](https://www.geeksforgeeks.org/selection-sort/) is an in-place comparison sorting algorithm. It has an O(n2) time complexity, which makes it inefficient on large lists, and generally performs worse than the similar insertion sort...

![selection-sort-amination](https://user-images.githubusercontent.com/108394058/205165479-571f3d1e-4a6f-49e5-9704-b7a84bfb343c.gif)

## Merge sort
> The [Merge Sort](https://www.geeksforgeeks.org/merge-sort/) algorithm is a sorting algorithm that is based on the Divide and Conquer paradigm. In this algorithm, the array is initially divided into two equal halves and then they are combined in a sorted manner...

![Merge-sort-example-300px](https://user-images.githubusercontent.com/108394058/206577029-d01fafb6-9ee3-49cf-81d1-9671bff341cd.gif)

## Quick sort
> Like Merge Sort, [Quick Sort](https://www.geeksforgeeks.org/quick-sort/) is a Divide and Conquer algorithm. It picks an element as a pivot and partitions the given array around the picked pivot. There are many different versions of quickSort that pick pivot in different ways. 

Worst complexity: n^2

Average complexity: n*log(n)

Best complexity: n*log(n)

![quicksort](https://user-images.githubusercontent.com/108394058/208423135-b68ef880-d2cc-43fd-af93-cfc8b923233d.gif)

## Counting Sort
> [Counting sort](https://www.geeksforgeeks.org/counting-sort/) is a sorting technique based on keys between a specific range. It works by counting the number of objects having distinct key values (a kind of hashing). Then do some arithmetic operations to calculate the position of each object in the output sequence. 

Worst case: when data is skewed and range is large.

Best Case: When all elements are same : O(n)

Average Case: O(N+K) (N & K equally dominant)

![countingSort](https://user-images.githubusercontent.com/108394058/208434695-9b0a6f9e-d533-4ace-a012-3db4976a5ee7.gif)


## Radix sort
> In computer science, [Radix sort](https://www.geeksforgeeks.org/radix-sort/)
 is a non-comparative sorting algorithm. It avoids comparison by creating and distributing elements into buckets according to their radix.

![IEZs8xJML3-radixsort_ed](https://user-images.githubusercontent.com/108394058/207691756-3ed33651-0400-440b-a993-d4b4c1554696.png)
