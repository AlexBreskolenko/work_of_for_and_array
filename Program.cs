Console.Clear();

/*
=====Работа с текстом
 Дан текст. В тексте нужно все пробелы заменить чёрточками,
 маленькие буквы “к” заменить большими “К”,
 а большие “С” маленькими “с”.
 Ясна ли задача?
Дальше. У нас есть сам текст. Можете в чат написать или в комментариях написать, о том
узнали ли вы произведения, откуда взят этот текст? И дальше мы уже начинаем писать код.
string text = “— Я думаю, — сказал князь, улыбаясь, — что,”
● ”ежели бы вас послали вместо нашего милого Винценгероде,”
● ”вы бы взяли приступом согласие прусского короля.”
● ”Вы так красноречивы. Вы дадите мне чаю?”;
*/
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?”";
//==========================Методы=================================================
string Replace(string str)
{
    string result = String.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (text[i] == ' ')
        {
            result += "-";
        }
        else if (text[i] == 'к')
        {
            result += "К";
        }
        else if (text[i] == 'С')
        {
            result += "с";
        }
        else
        {
            result += text[i];
        }
        ;
    }
    return result;
}


//Принимает строку ,новый и старый символ и возвращает измененную строку
string Replace_2(string str, char oldValue, char newValue)
{
    string result = String.Empty;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == oldValue)
        {
            result += $"{newValue}";
        }
        else
        {
            result += $"{str[i]}";
        }
    }
    return result;
}

//Сортировка массива
void SortingArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        
        int miniPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[miniPosition] > arr[j])
            {
                miniPosition = j;
            }
        }

        int temporary = arr[i];
        arr[i] = arr[miniPosition];
        arr[miniPosition] = temporary;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
//==========================Вызовы=================================================
//string str = Replace(text);
//Console.WriteLine(str);
//string str_2 = Replace_2(text, 'м', 'М');
//Console.WriteLine(str_2);

int[] array = { 5, 3, 2, 11, 0, 4, 17 };
SortingArray(array);
PrintArray(array);



//Создаем таблицу умножения
/*
for (int i = 1; i < 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        //Интрополяция строк
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/