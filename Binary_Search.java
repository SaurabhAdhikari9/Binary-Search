// Binary search algorithm always need the sorted list of the data
// Initialy, this code is written for the ascending sorted data. So, must of the comments referes to the ascending data
// But, hint is given in the for descending sorted data.

public class Binary_Search{
    public static int search( int []list, int high, int low, int searchValue) {
        if (low <= high){
            // calculate the mid value 
            int mid = (high+low )/2;      // decimal value is automatically round up

            // return mid, if search value in the mid index by itself
            if( list[mid] == searchValue){
                return mid;
            }
            // if searchValue is greater than the mid value
            // that means search value is loacted right side of the mid value
            // So, low is need to update with mid+1 
            //## recall the search function with updated low value
            // other value is remain same as before
            else if ( list[mid] < searchValue){         // change:  list[mid] > searchValue    // descending sorted data
                return search(list, high, mid+1,searchValue);
            }
            else{
                //  if the search value is smaller than the mid value
                // that means search value is located left side of the mid value 
                // So, high is need to upadate with mid-1
                //## recall the search function with updated high value,
                // other value is remain same as before
                return search(list,mid-1,low,  searchValue);
            }
        }
        // return the value -1 if the search value is not found
        return -1;
    }
    public static void main(String[] args) {
        // creating the list
        int a[] = {1,2,3,4,5,6,7};          // ascending sorted data
        // int a[] = {9,8,7,6,5,4,3,2,1};           // descending sorted data
        int low = 0;                        // first index of the list
        int high = a.length-1;      // last index of the list
        int searchValue = 6;        // search value
        int output = search(a, high, low, searchValue); 
        if(output == -1){       // if value is not found
            System.out.println("Value not found!!");
        }
        else{
            System.out.println("The searched value is : "+ a[output]+" found at index: "+output);
        }
    }
}