import sys 

def cutRod(list , n):
    revenues = [0 for i in range(n+1)]
    for j in range(1,n+1):
        q = ~sys.maxsize
        for i in range(j):
            q = max(q , list[i] + revenues[j-i-1])
        revenues[j] = q
    return revenues[n]

arr = [1,5,8,9,10,17,17,20]
size = len(arr)
print(cutRod(arr,size))

