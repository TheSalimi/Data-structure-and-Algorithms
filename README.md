# Algorithm

## Dynamic programming
[Dynamic Programming](https://www.geeksforgeeks.org/dynamic-programming/) is mainly an optimization over plain recursion. Wherever we see a recursive solution that has repeated calls for same inputs, we can optimize it using Dynamic Programming. The idea is to simply store the results of subproblems, so that we do not have to re-compute them when needed later. This simple optimization reduces time complexities from exponential to polynomial.

see more at [here](https://github.com/TheSalimi/Data-structure-and-Algorithms/tree/main/DP)

## Greedy
[Greedy Algorithms](https://www.geeksforgeeks.org/greedy-algorithms-general-structure-and-applications/) work step-by-step, and always choose the steps which provide immediate profit/benefit. It chooses the “locally optimal solution”, without thinking about future consequences.

## BFS
[The breadth-first search (BFS)](https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/) algorithm is used to search a tree or graph data structure for a node that meets a set of criteria. It starts at the tree’s root or graph and searches/visits all nodes at the current depth level before moving on to the nodes at the next depth level. Breadth-first search can be used to solve many problems in graph theory.

## DFS
[Depth First](https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/) Traversal (or Search) for a graph is similar to Depth First Traversal of a tree. The only catch here is, that, unlike trees, graphs may contain cycles (a node may be visited twice). To avoid processing a node more than once, use a boolean visited array. A graph can have more than one DFS traversal.

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
In computer science, [Selection Sort](https://www.geeksforgeeks.org/selection-sort/) is an in-place comparison sorting algorithm. It has an O(n2) time complexity, which makes it inefficient on large lists, and generally performs worse than the similar insertion sort...

![selection-sort-amination](https://user-images.githubusercontent.com/108394058/205165479-571f3d1e-4a6f-49e5-9704-b7a84bfb343c.gif)

## Merge sort
The [Merge Sort](https://www.geeksforgeeks.org/merge-sort/) algorithm is a sorting algorithm that is based on the Divide and Conquer paradigm. In this algorithm, the array is initially divided into two equal halves and then they are combined in a sorted manner...
###### Worst , Best , average caae
> nlogn

![Merge-sort-example-300px](https://user-images.githubusercontent.com/108394058/206577029-d01fafb6-9ee3-49cf-81d1-9671bff341cd.gif)

## Heap sort
Heap sort is a comparison-based sorting technique based on Binary Heap data structure. It is similar to the selection sort where we first find the minimum element and place the minimum element at the beginning. Repeat the same process for the remaining elements.
###### Worst , Best , average caae
> nlogn

![heapSortExample](https://user-images.githubusercontent.com/108394058/211544603-e8327a90-cc06-4206-8e54-6a953d3b5860.gif)

## Quick sort
Like Merge Sort, [Quick Sort](https://www.geeksforgeeks.org/quick-sort/) is a Divide and Conquer algorithm. It picks an element as a pivot and partitions the given array around the picked pivot. There are many different versions of quickSort that pick pivot in different ways. 

###### Worst complexity
> n^2

###### Average complexity
> n*log(n)

###### Best complexity
> n*log(n)

![quicksort](https://user-images.githubusercontent.com/108394058/208423135-b68ef880-d2cc-43fd-af93-cfc8b923233d.gif)

## Counting Sort
 [Counting sort](https://www.geeksforgeeks.org/counting-sort/) is a sorting technique based on keys between a specific range. It works by counting the number of objects having distinct key values (a kind of hashing). Then do some arithmetic operations to calculate the position of each object in the output sequence. 

###### Worst case
> when data is skewed and range is large.

###### Best Case
> When all elements are same : O(n)

###### Average Case
> O(N+K) (N & K equally dominant)

![countingSort](https://user-images.githubusercontent.com/108394058/208434695-9b0a6f9e-d533-4ace-a012-3db4976a5ee7.gif)


## Radix sort
> In computer science, [Radix sort](https://www.geeksforgeeks.org/radix-sort/)
 is a non-comparative sorting algorithm. It avoids comparison by creating and distributing elements into buckets according to their radix.

![IEZs8xJML3-radixsort_ed](https://user-images.githubusercontent.com/108394058/207691756-3ed33651-0400-440b-a993-d4b4c1554696.png)
