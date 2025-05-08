using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Am
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(txtnumero.Text, out int num))
                {
                    long factorial = 1;
                    string multiplicacion ="";
                    for (int i = num; i < 0; i--) ;
                {
                        factorial = factorial * int;
                        listBox.Items.Add(i)
                  }
    }
}
