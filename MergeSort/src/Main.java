public class Main {
    public static void main(String[] args) {
    }

    static void Sort(int[] arr, int left, int right) {
        if (left < right) {
            int middle = (left + right) / 2;

            Sort(arr, left, middle);
            Sort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right) {
        int numberOfLeftElements = middle - left + 1;
        int numberOfRightElements = right - middle;

        int[] leftSubTree = new int[numberOfLeftElements];
        int[] rightSubTree = new int[numberOfRightElements];

        for (int i = 0; i < leftSubTree.length; ++i) leftSubTree[i] = arr[i + left];

        for (int i = 0; i < rightSubTree.length; ++i) rightSubTree[i] = arr[i + middle + 1];

        int i = 0, j = 0, k = left;

        while (i < numberOfLeftElements && j < numberOfRightElements) {
            if (leftSubTree[i] <= rightSubTree[j]) {
                arr[k] = leftSubTree[i];
                i++;
            } else {
                arr[k] = rightSubTree[j];
                j++;
            }
            k++;
        }

        while (i < numberOfLeftElements) {
            arr[k] = leftSubTree[i];
            i++;
            k++;
        }

        while (j < numberOfRightElements) {
            arr[k] = rightSubTree[j];
            j++;
            k++;
        }
    }
}
