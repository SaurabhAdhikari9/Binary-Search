#  Binary search algorithm
#  Binary search algorithm always needs the sorted lists of data
#  this code only works on the ascending data i.e. [1,2,3,4,5,6,7,8]

def search(List, lowIndex, highIndex, searchValue):
    #  lower index must be smaller than the higher 
    if(lowIndex <= highIndex):

        # calculaing the mid index of the List
        midIndex = (lowIndex + highIndex) //2

        # if search value is in middle index by itself
        if List[midIndex] == searchValue:
            return midIndex
        
        # if the mid index value is smaller than the search value
        # then, search value is located in the right side of the mid index
        elif List[midIndex] <  searchValue:             # change: List[midIndex] > searchValue      # for desceding sorted values
            return search(List, midIndex+1, highIndex, searchValue)

        # Else when mid index value is greater than the seach value
        # then, search value is located left side of the mid index
        else:
            return search(List,lowIndex, midIndex -1, searchValue)
    
    # if value is not in the list it returns -1 
    else:
        return -1

# creating required parameters for search function
numbers = [1,2,3,4,5,6,7,8,9]
# numbers = [9,8,7,6,5,4,3,2,1]
high = len(numbers)-1
low = 0
search_value = 7

# calling the search function
result = search(numbers, low, high, search_value)

# displaying the search result
if result == -1:
    print("Value is not found!!!")
else:
    print("The value is at index of %d " %result)