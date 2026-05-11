namespace CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> userlist = new List<User>{
                new User { id =  1001, username =  "Jan", score = 25 },
                new User { id =  1002, username =  "Božena", score = 100 }
            };

            using(StreamWriter sw = new StreamWriter("data.csv"))
            {
                sw.WriteLine("id,usernam,score"); //hlavička tabulky

                for (int i = 0; i < userlist.Count; i++)
                {
                    sw.WriteLine($"{userlist[i].id},{userlist[i].username},{userlist[i].score}");
                }
            }

            using(StreamReader sr = new StreamReader("data.csv"))
            {
                string radek = sr.ReadLine();
                while(radek != null)
                {
                    Console.WriteLine(radek);
                    radek = sr.ReadLine();
                }
            }

            using(StreamReader sr = new StreamReader("bigdata.csv"))
            {
                sr.ReadLine();
                string radek = sr.ReadLine();
                while (radek != null)
                {
                    string[] poleuser = radek.Split(",");
                    User newUser = new User();
                    newUser.id = int.Parse(poleuser[0]);
                    newUser.username = poleuser[1];
                    newUser.score = int.Parse(poleuser[2]);
                    userlist.Add(newUser);
                    radek = sr.ReadLine();
                }
            }

            foreach (User user in userlist)
            {
                if(user.score >= 900)
                {
                    user.Introduction();
                }
            }

            for (int i = 0; i < userlist.Count; i++)
            {
                if (userlist[i].score < 500)
                {
                    userlist[i].score += 100;
                }
            }

            using (StreamWriter sw = new StreamWriter("bigdata.csv"))
            {
                sw.WriteLine("id,usernam,score"); //hlavička tabulky

                for (int i = 0; i < userlist.Count; i++)
                {
                    sw.WriteLine($"{userlist[i].id},{userlist[i].username},{userlist[i].score}");
                }
            }

        }
    }
}
