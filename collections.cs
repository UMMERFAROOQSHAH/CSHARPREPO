namespace genlist
{
   public  class abc
    {
        public static void Genericlist()
        {
            
                List<int> Genericlist = new List<int>();
                Genericlist.Add(20);
                Genericlist.Add(60);
                Genericlist.Add(200);
                Genericlist.Add(250);
                Genericlist.Add(280);
                Genericlist.Add(290);
                Genericlist.Add(220);
                foreach (int x in Genericlist)
                {
                    Console.WriteLine(x);
                }

            } 
        }
    }
