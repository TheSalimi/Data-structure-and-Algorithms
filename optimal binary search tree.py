import sys
def Sum( arr , i , j ):
    total = 0
    for x in range(i , j):
        total += arr[x]
    return total

def Optimal_binary_search_tree(keys , frequency):
    size = len(keys)
    cost = [[0 for x in range(size)] for y in range(size)]

    for i in range(size):
        cost[i][i] = frequency[i]

    for length in range(2 , size+1):
        for i in range(size - length + 2):
            j = length + i -1 
            sum = Sum( frequency , i , j )
            if i >= size or j>= size :
                break
            cost[i][j] = sys.maxsize
            for r in range(i , j+1):
                c = 0
                if(r > i):
                    c+= cost[i][r-1]
                if (r < j):
                    c += cost[r+1][j]
                c += sum
                if c < cost[i][j]:
                    cost[i][j] = c
    
    return cost[0][-1]
            
keys = [10, 12, 20]
freq = [34, 8, 50]
print("Cost of Optimal BST is",
           Optimal_binary_search_tree(keys, freq))
