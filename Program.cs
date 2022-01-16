using System;
using System.Collections.Generic;

namespace AddressBookFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Address Book you want : ");
            int numBook = Convert.ToInt32(Console.ReadLine());
            int numberBook = 0;
            int key = 1;
            while (numberBook < numBook)
            {
                Console.Write("\n Enter name of Address Book : ");
                string book = Console.ReadLine();
                Console.WriteLine("\n Select the below option");
                Console.WriteLine("1.Add Contact Details \n2.View Contant Detials \n3.Count By City Or State Name");
                Console.Write("Enter Your Choice : ");
                int num = Convert.ToInt32(Console.ReadLine());

                while (key != 0)
                {
                    switch (num)
                    {
                        case 1:
                            AddressBook.AddContact();
                            break;
                        case 2:
                            AddressBook.Details();
                            break;
                        default:
                            Console.Write("Choice correct option : ");
                            num = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    Console.Write("\n Do you wish to continue press 1 or press 0 for exit: ");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                AddressBook.AddTo(book);
                AddressBook.WriteAddressBookUsingStreamWriter();
                AddressBook.ReadAddressBookUsingStreamReader();
                numberBook++;

            }
        }
    }
}
