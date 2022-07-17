Console.WriteLine("Введите имя пользователя-> ");
string userName = Console.ReadLine();
if (userName.ToLower() == "маша")
{
    Console.WriteLine("О как круто. Маша привет");
}
else
{
    Console.WriteLine("Привет, " + userName);
}