def carAssembly(a,t,e,x):
    lineOne,lineTwo = [] , []
    lineOne.append(e[0]+a[0][0])
    lineTwo.append(e[1]+a[1][0])

    for i in range(1 , len(a[0])):
        lineOne.append(min(lineOne[i-1]+a[0][i] , lineTwo[i-1]+t[1][i]+a[0][i]))
        lineTwo.append(min(lineOne[i-1]+t[0][i]+a[1][i] , lineTwo[i-1]+a[1][i]))
    
    return min(lineOne[-1]+x[0] , lineTwo[-1]+x[1])


a=[[4,5,3,2]
,[2,10,1,4]]

t=[[0,7,4,5]
,[0,9,2,8]]

e=[10,12]
x=[18,7]

print(carAssembly(a,t,e,x))