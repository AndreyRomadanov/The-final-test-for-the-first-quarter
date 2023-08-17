// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//["Hello", "2", "world", ":-)"] → ['2", ":-)"]
//["1234", "1567", "-2", "computer science"] → ["-2"]
//["Russia", "Denmark", "Kazan"] → []




string []array =  {"Hello", "2", "world", ":-)" }  ;
int j = 0; 
bool flag = false;
string[] sorted = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{  
    flag = ConvertArrayElementToArray(array[i],flag);
    if (flag == true)  
    {
        sorted[j] = array[i];
        j++;
    }
}
PrintArray( sorted);

void PrintArray (string [] elsorted) // Выводим на экран что получилось.
{
    for (int i = 0; i < elsorted.Length; i++)
    {
            Console.Write ($" {elsorted[i]} ");       
    }
}

    
bool ConvertArrayElementToArray (string element , bool elemflag )
{
    string[] elemarray = new string[element.Length];
    if (element.Length <= 3) elemflag = true;
    else elemflag = false;
    return elemflag;    
}