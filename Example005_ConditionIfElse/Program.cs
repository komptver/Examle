Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ксюня")
{
    Console.WriteLine("Ура, это же КСЮНЯ! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}