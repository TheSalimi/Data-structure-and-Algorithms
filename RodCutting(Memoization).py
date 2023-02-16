import sys
def memoizedCutRod(arr , n , r):
    if (n<=0):
        return 0
    if(r[n]>=0):
        return r[n]
    if(n==0):
        q=0
    else:
        q= ~sys.maxsize
        if(n!=1):
            for i in range(1,n):
                q = max(q , arr[i] + memoizedCutRod(arr , n-i-1 , r))
        else :
            q = max(q , arr[0] + memoizedCutRod(arr , n-1 , r))

    r[n] = q
    return r[n]


arr = [1,5,8,9,10,17,17,20]
revenues = [~sys.maxsize for x in range(len(arr)+1)]
print(memoizedCutRod(arr,1,revenues))