string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
    result = result + text;
    }
return result;
}
string res = Method4(8, "Текст 8 раз");
// Console.WriteLine(res);



// for (int i = 2; i <= 9; i++)
// {
//     for (int j = 2; j <= 9; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


//Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”
//Перед выполнением задаем вопросы:
// Что значит “Дан текст”?.
// Что значит “черточками”?
// Какого алфавита?
// Маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// Ясна ли задача?
// Текст:
// — Я думаю, — сказал князь, улыбаясь, — что,
// ежели бы вас послали вместо нашего милого
// Винценгероде, вы бы взяли приступом согласие
// прусского короля. Вы так красноречивы. Вы
// дадите мне чаю?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
            + "Винценгероде, вы бы взяли приступом согласие "
            + "прусского короля. Вы так красноречивы. Вы "
            + "дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '%');
// Console.WriteLine(newText);
// Console.WriteLine();
newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);