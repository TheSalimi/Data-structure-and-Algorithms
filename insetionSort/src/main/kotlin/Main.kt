fun main(args: Array<String>) {
    val array = arrayOf(1,5,6,8,0,3)

    println("Before sort : ")
    for(i in array)
    {
        print("$i ")
    }

    println("\nAfter sort : ")
    val sortedArray  = insertionSort(array)
    for(i in sortedArray){
        print("$i ")
    }
}

fun insertionSort( array :Array<Int> ) : Array<Int> {
    var size : Int = 0
    for(i in array){
        size++
    }

    for(i in 1..size-1){
        var temp = array[i]
        var j = i-1

        while(j>=0 && temp<array[j]){
            array[j+1] = array[j]
            j--
        }

        array[j+1] = temp
    }
    return array
}