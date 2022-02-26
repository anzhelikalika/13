using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_task5_8
{
    public partial class Form1 : Form
    {
        List<IShip> ships = new List<IShip>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(TankerType)));
            comboBox1.SelectedIndex = 0;

            listBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IShip ship = GetSelectedShip(); ;
            if (ship != null)
            {
                Print(ship.Sail());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IShip ship = GetSelectedShip(); ;
            if (ship != null)
            {
                Print(ship.Sink());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IShip ship = GetSelectedShip(); ;
            if (ship != null)
            {
                Print(ship.ToString());
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            float lifting = (float)numericUpDown1.Value;
            int staff = (int)numericUpDown2.Value;
            string transportedLiquid = textBox2.Text;
            TankerType tankerType = (TankerType)Enum.Parse(typeof(TankerType), (string)comboBox1.SelectedItem);
            ships.Add(new Tanker(name, lifting, staff, transportedLiquid, tankerType));
            
            ReloadList();
            Print($"Корабль {name} добавлен.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Print(string message)
        {
            textBox3.Text += message + Environment.NewLine;
        }

        private void ReloadList()
        {
            listBox1.Items.Clear();
            ships.ForEach(s => listBox1.Items.Add(s));
        }

        private IShip GetSelectedShip()
        {
            IShip ship = (IShip)listBox1.SelectedItem;
            if (ship == null)
            {
                Print("Корабль не выбран");
            }
            return ship;
        }

    }
}
