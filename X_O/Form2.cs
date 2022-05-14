using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
            label2.Text = WIN;
        }
        public string WIN = "";
        public static string WIN2 = "";
        private void button1_Click(object sender, EventArgs e){
            Form1.ECHO = "YES";
            label2.Text = "";
            Close(); 
        }

        private void button2_Click(object sender, EventArgs e){
            Form1.ECHO = "NO";
            Close();
        }
    }
}
