//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int M = 1;
int N = 10;

void PrintNumbers(int start, int end) {
    if (start > end) {
        return;
    }
    Console.Write(start + " ");
    PrintNumbers(start + 1, end);
}

PrintNumbers(M,N);