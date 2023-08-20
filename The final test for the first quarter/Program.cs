// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//["Hello", "2", "world", ":-)"] → ['2", ":-)"]
//["1234", "1567", "-2", "computer science"] → ["-2"]
//["Russia", "Denmark", "Kazan"] → []


SamplingArrayElementsByLength();

void SamplingArrayElementsByLength ()
{
    int j = 0;
    string[] array = new string[j];  //Задаём исходный массив.
    array = ArraySelection(array);
    Console.WriteLine("Исходный массив  :   ");
    PrintArray(array);
    bool flag = false;
    string[] sorted = new string[array.Length]; // Создаём новый массив.
    for (int i = 0; i < array.Length; i++) // Проверяем количество символов в элементах исходного массива.
    {
        flag = ElementToArray(array[i], flag);
        if (flag == true)            // Добавляем элементы в новый массив.
        {
            sorted[j] = array[i];
            j++;
        }
    }
    Console.WriteLine();
    Console.Write("Из заданного массива выбираем строки менее 3 символов , получаем новый массив :");
    Console.WriteLine();
    PrintArray(sorted);
}

void PrintArray (string [] elsorted) // Выводим на экран массив .
{ 
    for (int i = 0; i < elsorted.Length ; i++)
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

string[] BildSizeArray ( )                 // Задаём параметры массива , вводим массив с клавиатуры.
{
Console.Write ( " Введите  количество строк в массиве  :  ") ;
int realsize = int.Parse ( Console.ReadLine ()! ) ;
string[] array = new string [realsize ]; 
for (int i = 0; i < realsize ; i ++ )
{
        Console.Write("Введите строку массива , по окончании ввода нажмите ENTER  :  ");
        array[i] = (Console.ReadLine()!);
}
return array ;
}

string[] ReadyMadeArrayInBodyProgram()      // Готовый массив в теле программы.
{
        string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark" };
    return array;
}

string[] ArraySelection (string[] arrayselection)    // Выбираем исходный массив.
{
    Console.Write("Эта программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна трём символам.Если желаете ввести массив с клавиатуры введите 0, если использовать массив ,встроенный в тело программы , введите любую цифру от 1 до 9.   ");
    var flag = int.Parse(Console.ReadLine()!);
    if (flag == 0) { arrayselection = BildSizeArray(); }
    else  { arrayselection = ReadyMadeArrayInBodyProgram(); }
    return (arrayselection);
}