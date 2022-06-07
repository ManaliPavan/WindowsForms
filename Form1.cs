using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Employee ID :"+txtEmpID.Text+
                "\nEmployee Name :"+txtEmpName.Text+
                "\nEmployee Salary :"+txtEmpSal.Text+
                "\nEmployee Department :"+txtEmpDepart.Text
                ,"Employee Details");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtEmpName.Clear();
            txtEmpDepart.Clear();
            txtEmpSal.Clear();
        }
    }
}
