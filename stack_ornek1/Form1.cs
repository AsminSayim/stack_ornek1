using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> stack = new Stack<string>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            stack.Push(textBox1.Text);
            listBox1.DataSource=stack.ToList();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(stack.Pop() + "kişisi listeden çıkarıldı");
            stack.Pop();//Listeden çıkar
            listBox1.DataSource = stack.ToList();
            

        }
    }
}
