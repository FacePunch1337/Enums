using System;

namespace Enums
{
    class Program
    {
        delegate void Delegate();
        private static Random rnd = new Random();
        private static Directions dir = new Directions();
        private static String img;
        private static Directions direction;
        static void Main(string[] args)
        {
            Console.WriteLine("Weather\n");

            
            
            foreach (int i in Enum.GetValues(typeof(Directions)))
            {
                
                var dir_val = Enum.GetName(typeof(Directions), i);

                Console.WriteLine("_____________________");
                direction = (Directions)i;
                Console.WriteLine(dir_val + " " + i + "°С");

                PrintDirection(direction);
                Dir("Тепло");





                /*direction = RandomDir();
                PrintDirection(direction);*/


            }
            Console.WriteLine("_____________________");
            dir = RandomDir();
            PrintDirection(dir);


        }

        private static Directions Direction()
        {
            foreach (int i in Enum.GetValues(typeof(Directions)))
             {
                 //var dir = Enum.GetValues(typeof(Directions)).GetValue(i);

                 var dir = (Directions)Enum.GetValues(typeof(Directions)).GetValue(i);
             }

            return dir;//(Directions)Enum.GetValues(typeof(Directions)).Length; 

        }

        private static Directions RandomDir()
        {


            Directions[] tmp = (Directions[])Enum.GetValues(typeof(Directions));
            return (Directions)tmp[rnd.Next(tmp.Length)];
        }

        private static void Dir(String _dir)
        {

            if (img == _dir) Console.WriteLine($"[√]");
            else Console.WriteLine("[Ơ]");
  
        }

        

        private static void PrintDirection(Directions direction)
        {
            //!Enum.IsDefined(direction.GetType(), direction)
            //!Enum.IsDefined<Directions>(direction)
            if (!Enum.IsDefined(direction.GetType(), direction))
            {
                throw new ArgumentOutOfRangeException($"Value {direction} out of Enum");
            }
            img = String.Empty;
            switch (direction)
            {
                case Directions.Cold: img = "Холодно"; break;
                case Directions.Chilly: img = "Прохладно"; break;
                case Directions.Heat: img = "Тепло"; break;
                case Directions.Hot: img = "Жарко"; break;
            }
            Console.WriteLine(img);
            
        }

        
    }
}
