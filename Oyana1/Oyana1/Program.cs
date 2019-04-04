using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Oyana1
{
    public class Formula1
    {
        public string place;
        public List<Racer> racers;
        public string name;
        public Formula1()
        {
            
        }
       
        public Formula1(string place, List<Racer> racers,string name)
        {
            this.place = place;
            this.racers = racers;
            this.name = name;
        }
       
        public override string ToString()
        {
            return place + name;
        }
    }
    public class Racer
    {
        public string name;
        public int age;
        public Car car;
        public Racer()
        {

        }
        public Racer(string name, int age,Car car)
        {
            this.name = name;
            this.age = age;
            this.car = car;
            
        }
    }
    public class Car
    {
        public string model;
        public double volumeOfengine;
        public string color;
        public Car(string model, double volumeOfengine, string color)
        {
            this.model = model;
            this.volumeOfengine = volumeOfengine;
            this.color = color;
        }
    }
    class Program
    {
        public static void Save()
        {
            Formula1 formula = new Formula1();
            FileStream fs1 = new FileStream("hs.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xm = new XmlSerializer(typeof(Formula1));
            xm.Serialize(fs1, formula);
            fs1.Close();
        }
        public static Formula1 Load()
        {
            FileStream fs1 = new FileStream("hs.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Formula1));
            Formula1 formula1 = xs.Deserialize(fs1) as Formula1;
            fs1.Close();
            return formula1;

        }
        static void Main(string[] args)
        {
            Car c = new Car("asdas", 8.12, "sdas");
            List <Racer> r = new List<Racer>();
            r[0].name = "ghj";
            r[0].age = 1;
            r[0].car = c;
            Formula1 f1 = new Formula1("saad",r,"dfg");
            Save();
            Load();

        }
       
    }
}
