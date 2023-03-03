def knapSack(capacity , values , weights ):
    size = len(values)
    profit = [[0 for x in range(capacity+1)] for i in range(size+1)]
    for i in range(1,size+1):
        for j in range(1,capacity+1):
            if i == 0 or j ==0:
                profit[i][j] = 0
            elif weights[i-1] < capacity:
                profit[i][j] = max(profit[i-1][j] , values[i-1] + profit[i-1][j - weights[i-1]])
            else :
                profit[i][j]=profit[i-1][j]
    return profit[size][capacity]

val = [60, 100, 120]
wt = [10, 20, 30]
W = 50
n = len(val)
print(knapSack(W, val, wt))