using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMichaelKastas
{
    public partial class Form1 : Form
    {


        T4DBWebAsEntities MyDB; 

        public Form1()
        {
            InitializeComponent();

            MyDB = new T4DBWebAsEntities();

            foreach (var item in MyDB.Customers)
            {
                listBox1.Items.Add(item);
            }
            listBox1.DisplayMember = "FirstName";

        }
    }
}
