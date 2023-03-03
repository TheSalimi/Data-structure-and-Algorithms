leftSum = 0
rightSum = 0

def findMaxSubArrayCrossingMid(list , low , mid , high):
    global leftSum
    global rightSum
    sum=0
    for i in range(mid , low-1 , -1):
        sum +=list[i]
        if(sum > leftSum):
            leftSum = sum
    sum=0
    for j in range(mid , high+1):
        sum += list[j]
        if (sum> rightSum):
            rightSum = sum

    return max(leftSum , rightSum , leftSum+rightSum-list[mid])

def findMaxSubArray(list , low , high):
    if (low>high):
        return -1000
    if ( low == high ):
        return (list[0])
    mid = (low+high)//2
    return max(findMaxSubArray(list , low , mid-1)
                ,findMaxSubArray(list , mid +1 , high)
                ,findMaxSubArrayCrossingMid(list , low  , mid , high))

