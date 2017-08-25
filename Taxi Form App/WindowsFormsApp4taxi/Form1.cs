using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4taxi
{
    public partial class Form1 : Form
    {
        Taxi selectedTaxi;
        Client selectedClient;
        public Form1()
        {
            InitializeComponent();
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddTaxi_Click(object sender, EventArgs e)
        {
            
            Taxi.mytaxi.Add(new Taxi(TaxiNum.Text, Convert.ToInt32(TaxiX.Text), Convert.ToInt32(TaxiY.Text)));
            comboBox1.Items.Add(TaxiNum.Text);
        }

        private void TaxiX_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TaxiY_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMusteri_Click(object sender, EventArgs e)
        {
            Client.myclient.Add(new Client(ClientName.Text, Convert.ToInt32(ClientX.Text), Convert.ToInt32(ClientY.Text)));
            comboBox2.Items.Add(ClientName.Text);
        }
        
        private void CallTaxi_Click(object sender, EventArgs e)
        {
            foreach (var taxi in Taxi.mytaxi)
            {
                if (comboBox1.SelectedItem.ToString()==taxi.Num)
                {
                    selectedTaxi = taxi;
                }
            }
            foreach (var client in Client.myclient)
            {
                if (comboBox2.SelectedItem.ToString() ==client.Name)
                {
                    selectedClient = client;
                }
            }
            double distance = Math.Sqrt(Math.Pow((Convert.ToInt32( TaxiX.Text) -Convert.ToInt32( ClientX.Text)), 2) + Math.Pow((Convert.ToInt32( TaxiY.Text) -Convert.ToInt32( ClientY.Text)), 2));
            double money = Math.Floor( distance * 0.3);
            result.Text ="Gedish haggi: "+ money.ToString()+"AZN";

        }
    }
    class Taxi
    {
       public static List<Taxi> mytaxi = new List<Taxi>();
        public string Num { get; set; }
        public double TaxiX { get; set; }
        public double TaxiY { get; set; }
        public Taxi(string _num ,int _x,int _y)
        {
            this.Num = _num;
            this.TaxiX = _x;
            this.TaxiY = _y;
            Taxi.mytaxi.Add(this);

        }
    }
    class Client
    {
       public static List<Client> myclient = new List<Client>();
        public string Name { get; set; }
        public double ClientX { get; set; }
        public double ClientY { get; set; }
        public Client(string _name, int _x, int _y)
        {
            this.Name = _name;
            this.ClientX = _x;
            this.ClientY = _y;
            Client.myclient.Add(this);

        }
    }
}
