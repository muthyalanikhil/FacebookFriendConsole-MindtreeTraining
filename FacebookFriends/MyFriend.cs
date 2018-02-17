using System;
using System.Collections;
using System.Collections.Specialized;

namespace FacebookFriends
{
    class MyFriend
    {
        StringCollection friend = new StringCollection();

        /// <summary>
        /// This method adds friends to your friends list.
        /// </summary>
        public void FriendsList()
        {
            Console.WriteLine("Enter number of friends:");
            int numberOfFriends = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter names of your friends:");

            string nameOfFriend = string.Empty;
            for (int index = 0; index < numberOfFriends; index++)
            {
                nameOfFriend = Console.ReadLine();
                friend.Add(nameOfFriend);
            }

            AccountSettings();
        }

        /// <summary>
        /// This method is used to switch to different methods.
        /// </summary>
        public void AccountSettings()
        {
            Console.WriteLine("\n1.Display your friends list.\n2.Add new friend.\n3.Remove friend.\n4.Replace a friend.\n5.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DisplayFriendsList();
                    break;
                case 2:
                    AddFriend();
                    break;
                case 3:
                    RemoveFriend();
                    break;
                case 4:
                    ReplaceFriend();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// This method is used to display your friends list.
        /// </summary>
        public void DisplayFriendsList()
        {
            Console.Clear();
            Console.WriteLine("\nFriends in your friends list are:");
           
            foreach (var newFriend in friend)
            {
                Console.WriteLine(newFriend);
            }

            AccountSettings();
        }

        /// <summary>
        /// This method is used to add new friends.
        /// </summary>
        public void AddFriend()
        {
            Console.WriteLine("\nEnter name of the friend to be added:");
            string newFriend = Console.ReadLine();
            
            friend.Add(newFriend);

            AccountSettings();
        }

        /// <summary>
        /// This method is used to remove friends from friends list.
        /// </summary>
        public void RemoveFriend()
        {
            Console.WriteLine("\nEnter name of friend to be removed:");
            string nameOfFriend = Console.ReadLine();

            friend.Remove(nameOfFriend);

            AccountSettings();
        }

        /// <summary>
        /// This method is used to replace friends in friends list.
        /// </summary>
        public void ReplaceFriend()
        {
            Console.WriteLine("\nEnter name of the friend to be replaced:");

            string nameOfFriend = Console.ReadLine();
            int position = friend.IndexOf(nameOfFriend);
            friend.Remove(nameOfFriend);

            Console.WriteLine("\nEnter name of the new friend to be added:");
            string newFriend = Console.ReadLine();
            friend.Insert(position, newFriend);

            AccountSettings();
        }
    }
}
