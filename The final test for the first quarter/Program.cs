// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//["Hello", "2", "world", ":-)"] → ['2", ":-)"]
//["1234", "1567", "-2", "computer science"] → ["-2"]
//["Russia", "Denmark", "Kazan"] → []


SamplingArrayElementsByLength();

void SamplingArrayElementsByLength ()
{
    string[] array = { "Hello", "2", "world", ":-)","1234", "1567", "-2", "computer science","Russia", "Denmark" };
    int j = 0;
    bool flag = false;
    string[] sorted = new string[array.Length]; // Создаём новый массив.
    for (int i = 0; i < array.Length; i++) // Проверяем количество символов в элементах массива.
    {
        flag = ElementToArray(array[i], flag);
        if (flag == true)            // Добавляем элементы в новый массив.
        {
            sorted[j] = array[i];
            j++;
        }
    }
    Console.Write("Из заданного массива выбираем строки менее 3 символов , получаем новый массив :");
    Console.WriteLine();
   PrintArray(sorted);
}

void PrintArray (string [] elsorted) // Выводим на экран массив .
{ 
    for (int i = 0; i < elsorted.Length; i++)
    {
            Console.Write ($" {elsorted[i]} ");       
    }
}
    
bool ElementToArray (string element , bool elemflag ) 
// Считаем количество символов в элементе массива , сравниваем с условием задачи.
{
    if (element.Length <= 3) elemflag = true;
    else elemflag = false;
    return elemflag;    
}