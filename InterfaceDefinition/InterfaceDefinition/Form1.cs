using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB;

namespace InterfaceDefinition
{
    public partial class Form1 : Form
    {
        private readonly Form1ViewModel _viewModel 
            = new Form1ViewModel();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.Button1Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _viewModel.Button2Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _viewModel.Button3Click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _viewModel.Button4Click(checkBox1.Checked);
        }
    }
}
