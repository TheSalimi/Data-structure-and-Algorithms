t = int(input())
for i in range(t):
    m = int(input())
    a = list(map(int, input().split()))
    base = 313
    mod = [
        int(1e9 + 7),
        int(1e9 + 9),
    ]
    h = [
        [0] * (m + 1), [0] * (m + 1)
    ]
    p = [
        [1] * (m + 1), [1] * (m + 1)
    ]
    for j in range(m):
        p[0][j + 1] = (p[0][j] * base) % mod[0]
        p[1][j + 1] = (p[1][j] * base) % mod[1]
    for j in range(m):
        h[0][j + 1] = (h[0][j] * base + a[j]) % mod[0]
        h[1][j + 1] = (h[1][j] * base + a[j]) % mod[1]
    for j in range(1, m + 1):
        if h[0][m - j] == ((h[0][m] - p[0][m-j] * h[0][j]) % mod[0] + mod[0]) % mod[0]:
            if h[1][m - j] == ((h[1][m] - p[1][m-j] * h[1][j]) % mod[1] + mod[1]) % mod[1]:
                print(j)
                for k in range(j):
                    print(a[k], end=' ')
                print()
                break