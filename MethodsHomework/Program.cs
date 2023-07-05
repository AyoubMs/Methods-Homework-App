
using MethodsHomework;
using static MethodsHomework.UserMethods;

string userName;
bool isInvalid;

do
{
    userName = UserMethods.GetUserName();
    isInvalid = int.TryParse(userName, out int dumb);
    if (isInvalid || string.IsNullOrEmpty(userName))
    {
        Console.WriteLine("Please provide a valid name");
    }
    if (userName != "exit" && !isInvalid && !string.IsNullOrEmpty(userName))
    {
        UserMethods.SayHello(userName);
    }
} while (userName != "exit");
