import sys
leftTotal = ~sys.maxsize
rightTotal = ~sys.maxsize

def findMaxCrossingMidSubbarray(list):
    global leftTotal
    global rightTotal
    left = 0
    right = len(list)
    mid = int((left+right)/2)
    sum=0
    rightMaxIndex = mid+1
    leftMaxIndex = mid 

    for i in range(mid , left):
        sum = list[i]
        if(sum>=leftTotal):
            leftTotal = sum
            leftMaxIndex = i

    sum=0
    for i in range(mid+1 , right):
        sum = list[i]
        if(sum>=rightTotal):
            rightTotal = sum
            rightMaxIndex = i

    return list[leftMaxIndex : rightMaxIndex+1]

l = [0 , 10 , 20 ,10 , 30 , 50 , 60]
print(findMaxCrossingMidSubbarray(l))