using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;


namespace FacebookFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyFriend friend = new MyFriend();
                friend.FriendsList();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("\n\nSorry.Try again.");
                MyFriend friend = new MyFriend();
                friend.FriendsList();
            }
            Console.ReadLine();
        }
    }
}
