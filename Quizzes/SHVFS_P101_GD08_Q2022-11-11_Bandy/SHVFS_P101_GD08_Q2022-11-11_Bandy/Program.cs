using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD_08
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            var KUNNN = new Gameobject[5];
            var object1 = new Gameobject("aa", new Positision(1, 5, 9));
            var object2 = new Gameobject("bb", new Positision(2, 5, 9));
            var object3 = new Gameobject("cc", new Positision(4, 6, 8));
            var object4 = new Gameobject("dd", new Positision(2, 5, 9));
            var object5 = new Gameobject("ee", new Positision(2, 5, 9));
            KUNNN[0] = object1;
            KUNNN[1] = object2;
            KUNNN[2] = object3;
            KUNNN[3] = object4;
            KUNNN[4] = object5;   
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    //Console.WriteLine( KUNNN[i].Name);
                    if (KUNNN[i].IKUN(KUNNN[j]))
                    {
                        Console.WriteLine($"{KUNNN[i].Name} = {KUNNN[j].Name}");
                        
                    }
                }
            }
            Console.ReadLine();
        }

    }

    public struct Positision
    {
        public int x;
        public int y;
        public int z;
        public Positision(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }

    public class Gameobject
    {
        public string Name;
        public Positision pos;
        public Gameobject(string name, Positision position)
        {
            Name = name;
            pos = position;
        }
        public bool IKUN(Gameobject KUN)
        {
            if (pos.x == KUN.pos.x && pos.y == KUN.pos.y && pos.z == KUN.pos.z)
            {
                return true;
            }
            else return false;

            
        }
    }
}