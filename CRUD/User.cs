using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class User
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public User()
        {

        }
        public User(string num,string name,string email)
        {
            Name = name;
            PhoneNumber = num;
            Email = email;
        }
        public void add_user(List<User> users)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Phone: ");
            string phone = Console.ReadLine();

            var user = new User(phone, name, email);
            users.Add(user);

            Console.WriteLine("====================== user information you added ======================");
            user.print();
        }

        public void print()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Email:{Email}");
            Console.WriteLine($"Phone:{PhoneNumber}");
            Console.WriteLine("==========================");
        }

        public void print_all(List<User>users)
        {
            foreach (var user in users)
            {
                user.print();
            }
        }

        public void delete_user(List<User>users)
        {
            Console.WriteLine("Enter Phone number of user you want delete: ");
            string ph = Console.ReadLine();
            User founduser = users.FirstOrDefault(x => x.PhoneNumber == ph);
            if (founduser != null)
            {
                users.Remove(founduser);
            }
            else
            {
                Console.WriteLine("user not found");
            }
            //for (int i = 0; i < users.Count; i++)
            //{
            //    if (users[i].PhoneNumber != ph)
            //    {
            //        continue;
            //    }
            //    users.RemoveAt(i);
            //    break;
            //}

        }

        public void update_user(List<User>users)
        {
            Console.WriteLine("Enter Phone number of user you want update: ");
            string ph = Console.ReadLine();
            User founduser = users.FirstOrDefault(x => x.PhoneNumber == ph);
            if(founduser != null)
            {
                Console.WriteLine("Enter Name: ");
                founduser.Name = Console.ReadLine();

                Console.WriteLine("Enter Email: ");
                founduser.Email = Console.ReadLine();

                Console.WriteLine("Enter Phonenumber: ");
                founduser.PhoneNumber = Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("user not found");
            }

            //for (int i = 0; i < users.Count; i++)
            //{
            //    if (users[i].PhoneNumber != ph)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("Enter Name: ");
            //    users[i].Name = Console.ReadLine();
            //    Console.WriteLine("Enter Email: ");
            //    users[i].Email = Console.ReadLine();

            //    break;
            //}
        }
    }
}
