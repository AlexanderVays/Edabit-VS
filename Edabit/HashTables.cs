using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Edabit
{
    struct UserInfo 
    {
        public string userName;
        public int userId;

        public UserInfo(int id, string name) 
        {
            userId = id;
            userName = name;
        }
    }

    /// <summary>
    /// HashTable represent a non generic key and value pair
    /// </summary>    
    class HashTables
    {
        static Hashtable myTable;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;

        public static void HashtableMethods()
        {
            myTable = new Hashtable();
            userInfoList = new List<UserInfo>();
            sw = new Stopwatch();

            //adding pairs to HashTable
            for (int i = 0; i < 4000000; i++) 
            {
                myTable.Add(i, "user" + i);
                userInfoList.Add(new UserInfo(i, "user" + i));
            }

            //removing from Hashtable
            if (myTable.ContainsKey(0)) 
            {
                myTable.Remove(0);
            }

            //setting the new value
            if (myTable.ContainsKey(1)) 
            {
                myTable[1] = "new value";
            }

            //adding new data type as a key and new value data type
            myTable.Add("string", 10);
            myTable.Add(25.25, 11);


            //looping through hashtable
            /* foreach (DictionaryEntry entry in myTable) 
            {
                Console.WriteLine("The key is: " + entry.Key + " and value:" + entry.Value);
            }  */

            //access  
            Random randomUserGen = new Random();
            int randomUser = -1;

            sw.Start();
            float startTime = 0;

            float endTime = 0;
            float deltaTime = 0;
            string userName = string.Empty;

            for (int i = 0; i < 5; i++) 
            {
                randomUser = randomUserGen.Next(3000000, 4000000);
                startTime = sw.ElapsedMilliseconds;
                //list access
                userName = GetFromList(randomUser);
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from the List took " + string.Format("{0:0.##}", deltaTime) + "ms");

                startTime = sw.ElapsedMilliseconds;
                //hashtable access
                userName = GetFromHashtable(randomUser);
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from the Hashtable took " + string.Format("{0:0.##}", deltaTime) + "ms");
            }

        }

        static string GetFromList(int userId) 
        {
            for (int i = 0; i < userInfoList.Count; i++) 
            {
                if (userInfoList[i].userId == userId) 
                {
                    return userInfoList[i].userName;
                }
            }
            return string.Empty;
        }

        static string GetFromHashtable(int userId) 
        {
            if (myTable.ContainsKey(userId)) 
            {
                return myTable[userId].ToString();
            }

            return string.Empty;
        }
    }
}
