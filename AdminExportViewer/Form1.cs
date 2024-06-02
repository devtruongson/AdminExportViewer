using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminExportViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
        }
    }
}
