using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_taxi_with_list
{
    class Program
    {
        public static List<Client> clientler = new List<Client>();
        public static List<string> names = new List<string>();
        public static List<Taxi> taxiler = new List<Taxi>();
        public static List<double> distances = new List<double>();
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                string TaxiNum = Convert.ToString(Console.ReadLine());
                int TaxiX = Convert.ToInt32(Console.ReadLine());
                int TaxiY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(TaxiNum+" nomreli taxinin koordinatlari: "+TaxiX+" "+TaxiY);
                Taxi myTaxies = new Taxi(TaxiNum,TaxiX,TaxiY);
                taxiler.Add(myTaxies);
                names.Add(TaxiNum);
            }
            for (int i = 1; i < 6; i++)
            {
                string ClientName = Convert.ToString(Console.ReadLine());
                int ClientX = Convert.ToInt32(Console.ReadLine());
                int ClientY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(ClientName + " adli musterinin koordinatlari: " + ClientX + " " + ClientY);
                Client myClient = new Client(ClientName, ClientX, ClientY);
                clientler.Add(myClient);
                names.Add(ClientName);
            }
            Console.WriteLine("Taxini hansi mushteri uchun sifarish etmek isterdiz? ");
            string MainClient = Console.ReadLine();
            foreach (var item in clientler)
            {
                if (MainClient.ToString()==item.ClientNum)
                {
                    for (int i = 0; i < taxiler.Count; i++)
                    {
                        item.CallTaxi(taxiler[i],distances);
                    }
                }
            }
            double[] array = distances.ToArray();
            double mindist = array.Min();
            Console.WriteLine(names[distances.IndexOf(mindist)]+" nomreli taxi size teyin edildi ve odeyeceyiniz meblegh: "+mindist.ToString()+"Azn");
        }
    }
    public class Taxi
    {
        public string TaxiNum;
        public int TaxiX;
        public int TaxiY;
        public Taxi(string _num,int _x,int _y)
        {
            this.TaxiNum = _num;
            this.TaxiX = _x;
            this.TaxiY = _y;
        }
    }
    public class Client
    {
        public string ClientNum;
        public int ClientX;
        public int ClientY;
        public double Distance;
        public double Price;
        public Client(string _num, int _x, int _y)
        {
            this.ClientNum = _num;
            this.ClientX = _x;
            this.ClientY = _y;
        }
        public void CallTaxi(Taxi taxiler, List<double> distances)
        {
            this.Distance = Math.Round(Math.Sqrt(Math.Pow((taxiler.TaxiX - ClientX), 2) + Math.Pow((taxiler.TaxiY - ClientY), 2)));
            this.Price = Distance * 0.3;
            distances.Add(Distance);
        }
    }
    }


