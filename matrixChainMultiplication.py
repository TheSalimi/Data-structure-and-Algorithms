import sys

def matrixChainMultiplication(arrOfMatrix):
    length = len(arrOfMatrix)
    m = [[]*length]*length

    for i in range(length):
        m[i][i] = 0

    for length_of_each_first in range(2, length):
        for i in range(length_of_each_first):
            j = i+length_of_each_first-1
            m[i][j] = sys.maxsize
            for k in (i, j):
                q = m[i][k] + m[k+1][j] + arrOfMatrix[i] * \
                    arrOfMatrix[k]*arrOfMatrix[j]
                if q < m[i][j]:
                    m[i][j] = q
