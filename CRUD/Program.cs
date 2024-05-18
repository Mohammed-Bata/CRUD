
using CRUD;

List<User> users = new List<User>();

Console.WriteLine("1-Add User");
Console.WriteLine("2-Update Data of User");
Console.WriteLine("3-Delete User");
Console.WriteLine("4-Print All Users");
bool flag = true;
while (flag == true)
{
    User user = new User();
    int i = int.Parse(Console.ReadLine());
    switch (i)
    {
        case 1: user.add_user(users);
            break;
        case 2: user.update_user(users);
            break ;
        case 3: user.delete_user(users);
            break;
        case 4: user.print_all(users);
            break;

        default: Console.WriteLine("not valid");
            break;
    }
    Console.WriteLine("Do you want continue? (y/n)");
    string answer = Console.ReadLine();
    if(answer == "n")
    {
        flag = false;
    }
    Console.WriteLine("1-Add User");
    Console.WriteLine("2-Update Data of User");
    Console.WriteLine("3-Delete User");
    Console.WriteLine("4-Print All Users");
}






