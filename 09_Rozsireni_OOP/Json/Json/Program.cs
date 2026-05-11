using System.Collections.Generic;
using System.Text.Json;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> userlist = new List<User>{
                new User { id =  1001, username =  "Jan", score = 25 },
                new User { id =  1002, username =  "Božena", score = 100 }
            };

            string jsonString = JsonSerializer.Serialize(userlist);
            Console.WriteLine(jsonString);

            File.WriteAllText("data.json",jsonString);
           
            string upload = File.ReadAllText("data.json");

            List<User> userlistUpload = JsonSerializer.Deserialize<List<User>>(upload);

            for (int i = 0; i < userlistUpload.Count; i++)
            {
                userlistUpload[i].score += 100;
            }
            string jsonString2 = JsonSerializer.Serialize(userlistUpload);

            File.WriteAllText("data2.json", jsonString2);

            //Práce se staženými daty

            List<User2> users = JsonSerializer.Deserialize<List<User2>>(File.ReadAllText("users.json"));

            foreach (User2 user in users)
            {
                if(user.countery == "China")
                {
                    Console.WriteLine($"{user.username}");
                }
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].countery == "China")
                {
                    users[i].countery = "Vietnam";
                }
            }

            File.WriteAllText("users.json", JsonSerializer.Serialize(users));




        }
    }
}
