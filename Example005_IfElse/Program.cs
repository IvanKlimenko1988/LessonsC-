Console.WriteLine("Введите имя пользователя ");
String userName = Console.ReadLine();

if(userName.ToLower() == "маша")
{
    Console.WriteLine("УРА! Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}