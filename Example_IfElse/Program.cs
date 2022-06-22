Console.Write("Введите имя пользователя - ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Эгегей это же МАША!))"); 
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);        
}
