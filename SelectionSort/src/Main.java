public class Main {
    public static void main(String[] args) {
        int [] arr = {1 , 5  , 6 ,2};
        SelectionSort(arr);

        for(int item : arr){
            System.out.print(item + " ");
        }
    }
    
    public static void SelectionSort(int [] arr){
        int smallestNumber;
        for (int i = 0 ; i < arr.length  ; i++) {
            smallestNumber = i;
            for (int j = i + 1; j < arr.length; j++) {
                if (arr[i] > arr[j]) {
                    smallestNumber = j;
                }
            }
            
            int temp = arr[smallestNumber];
            arr[smallestNumber] = arr[i];
            arr[i] = temp;
        }
    }
}