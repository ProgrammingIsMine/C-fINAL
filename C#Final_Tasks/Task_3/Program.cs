//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int [] numbers = {1,2,3,4,5,6,7,8,9,10,56};

void printReverseArray(int [] array, int index) {
    if (index < 0) {
        return;
    }
    Console.Write(array[index] + "   ");
    printReverseArray(array,index-1);
}
int elements = numbers.Length - 1;
printReverseArray(numbers,elements);