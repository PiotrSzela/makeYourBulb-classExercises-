using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeYourBulb_classExercises_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulb bulb = new Bulb("green");
            Bulb bulb2 = new Bulb("red");
            Bulb bulb3 = new Bulb(bulb);
            Console.WriteLine(bulb3.BulbColor);

            bulb3.BulbColor = "pink";

            Console.WriteLine(bulb.BulbColor);
            Console.WriteLine(bulb.BulbPower);
            Console.WriteLine(bulb2.BulbColor);
            Console.WriteLine(bulb3.BulbColor);


            Console.ReadLine();
        }
    }

    class Bulb
    {
        public string BulbColor { get; set; }
        public int BulbPower { get; private set; }


        public Bulb(string bulbColor,int bulbPower)
        {
            this.BulbColor = bulbColor;
            this.BulbPower = bulbPower;

        }

        public Bulb(string bulbColor): this(bulbColor,10)
        {

        }

        public Bulb(Bulb bulb) // copy constructor 
        {
            this.BulbColor = bulb.BulbColor;
            this.BulbPower = bulb.BulbPower;

        }

    }
}
