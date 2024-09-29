using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {





            try
            {
                Console.WriteLine("Enter Your UserName : ");
                string username = Console.ReadLine();

                if (username.Contains(" "))
                    throw new InvalidUsernameException("Use Username without space !!!");


                Console.WriteLine("Enter your password : ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new InvalidPasswordException("your password is not strong ");

                }

            }
         
        catch ( InvalidPasswordException exception)
            {
                Console.WriteLine($"Erorr : {exception.Message}");   
            }

            catch (InvalidUsernameException exeption)
            {
                Console.WriteLine($"error : {exeption.Message}");    
            } 


            //catch (Exception exeption)
            //{
            //    Console.WriteLine($"aramosalodneli erori {exeption.Message}");
            //}
            

        }
    }
}
