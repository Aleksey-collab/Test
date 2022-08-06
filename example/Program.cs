// Написать программу, Котороая из имеющего массива строк формирует массив из строк, длина которых меньше либо равно 3 - м симвалам.
// Первоначальныймассив можно ввисти с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуеться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] myArray = new string [number];
string[] myArray2 = new string [myArray.Length];
for (int i = 0; i < number; i++)
{
    Console.Write($"Введите значение №{i + 1}: ");
    myArray[i] = Console.ReadLine();
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", myArray)+ "]");
Console.WriteLine();

//Выбор из массива меньше либо равно 3-м.
for (int i = 0; i < myArray.Length; i++)
{
    int count = 0;
    for (int j = 0; j < myArray.Length; j++)
    {
        if(myArray[i].Length <= 3)
        {
            myArray[count] = myArray[i];
            count++;
            Console.WriteLine("Длина которых меньше либо равно 3-м симвалам: [" + string.Join(", ", myArray[i])+ "]");
        }
        break;
    }
    
}