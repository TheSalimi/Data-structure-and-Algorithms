public class Main {
    public static void main(String[] args) {
        int [] arr = {1 , 2 , 3 , 5 , 8 , 7 , 98} ;
        //sort :
        insertionSort(arr);
        for (int i=0 ; i < arr.length ; i++){
            System.out.print(arr[i] + " ");
        }
    }

    static void insertionSort(int [] arr){
        for(int i = 1 ; i < arr.length ; i++){
            int temp =  arr[i];
            int j = i -1 ;

            while(j>=0 && temp < arr[j]){
                arr[j+1] = arr[j];
                j--;
            }

            arr[j+1] = temp;
        }
    }
}