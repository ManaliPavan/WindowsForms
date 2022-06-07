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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void addname_Click(object sender, EventArgs e)
        {
            listNames.Items.Add(txtName.Text);
        }

        private void deletename_Click(object sender, EventArgs e)
        {
            listNames.Items.Remove(listNames.SelectedItem);
        }

        private void clearlist_Click(object sender, EventArgs e)
        {
            listNames.Items.Clear();
        }
    }
}
