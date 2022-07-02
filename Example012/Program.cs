// Первая группа методов: 
// Ничего не возвращают и не принимают.

// void Method1()
// {
//     Console.WriteLine("Автор - это я!");
// }
// Method1();



//Вторая группа методов:
//Ничего не возвращают, но принимают какое либо количество аргументов.

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2(msg: "Какой то текст", count: 6);



//Третья группа методов:
//Аргументы не принимают, но возвращают данные.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



//Четвертая группа методов:
//И принимают и возвращают

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(8, "Текст 8 раз");
// Console.WriteLine(res);