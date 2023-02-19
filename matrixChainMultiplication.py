import sys
name ="A"

def printParathesis(i , j , length , multiTable):
    global name
    if(i==j):
        print(name , end=" ")
        name = chr(ord(name)+1)
        return

    print("(",end="")

    printParathesis(i,multiTable[i][j],length,multiTable)
    printParathesis(multiTable[i][j] +1 , j , length , multiTable)
    print(")" , end = "")

def matrixChainMultiplication(dimonsions):
    length = len(dimonsions)
    m = [[0 for i in range(length)] for j in range(length)]

    for i in range(1,length):
        m[i][i] = 0
    
    S = [[0 for x in range(length)] for x in range(length)]

    for sliceLength in range(2, length):
        for i in range(1 ,1 + length - sliceLength):
            j = i + sliceLength - 1
            m[i][j] = sys.maxsize
            for k in range(i, j):
                s = [[0 for x in range(i)] for x in range(j)]
                q = m[i][k] + m[k+1][j] + dimonsions[i-1] * \
                    dimonsions[k]*dimonsions[j]
                if q < m[i][j]:
                    m[i][j] = q
                    S[i][j] = (k)
    print("Optimal parenthesization is : ")
    printParathesis(1,length -1, length , S)
    print("Optimal cost is : ")
    return m[1][-1]

dimonsions = [ 40, 20, 30, 10, 30 ]
print(matrixChainMultiplication(dimonsions))