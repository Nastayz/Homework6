/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())*/


int[] GetIntNumberFromString(string message) {
    Console.WriteLine(message);
    string text = Console.ReadLine();
    
    var data = text.Split(",");
    string[] dataArr = data.ToArray();
    int[] result = new int[dataArr.Length];

    for (int i = 0; i < dataArr.Length; i++) {
        result[i] = Convert.ToInt32(dataArr[i]);
    }
    return result;
}

int CountPositiveNumbers (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] > 0) count++;
    }
    return count;
}


int[] arrayInt = GetIntNumberFromString("Введите значения массива через запятую: ");
Console.WriteLine("[{0}]",string.Join(" ", arrayInt));

int countPosNum = CountPositiveNumbers(arrayInt);
Console.WriteLine($"В массиве {countPosNum} положительных чисел");
