
#include <iostream>

using namespace std;

int main() {

    setlocale(LC_ALL, "Russian");

    int N;
    cout << "Введите размер массива: ";
    cin >> N;

    int* arr = new int[N];

    for (int i = 0; i < N; ++i) {
        arr[i] = i + 1;
    }

    cout << "Массив: ";
    for (int i = N - 1; i >= 0; i--) {
        cout << arr[i] << " ";
    }
    cout << endl;
    int max = arr[0];
    for (int i = 0; i < N; ++i)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    int min = arr[0];
    for (int i = 0; i < N; ++i)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    int sum = 0;

    for (int i = 0; i < N; ++i) {
        sum += arr[i]; 
    }

    double average = static_cast<double>(sum) / N;


    cout << "Максимальный элемент: " << max << endl;
    cout << "Минимальный элемент: " << min << endl;

    cout << "Сумма элементов массива: " << sum << endl;
    cout << "Среднее арифметическое: " << average << endl;

    delete[] arr;

    return 0;5
}