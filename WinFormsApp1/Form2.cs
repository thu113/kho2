using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private const int V = 10;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String layTenKH()
        {

            return tenKH.Text ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text1 = String.Format("{0} là học sinh của tui", layTenKH());
            Class1 a = new Class1();
       
            Node b = new Node();
            MessageBox.Show(String.Format("{0} hêhe", b.show132()));


        }

        private void tenKH_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
