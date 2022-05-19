using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class textt : Form
    {
        public textt()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("لطفا داخل کادر متنی بنویسید");
            }
            else
            {
                MessageBox.Show("ممنون که توجه کردید نظر شما مطمئنا در پیشرفت ما تاثیر گذاره", "ثبت نظر");
            }
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textt_Load(object sender, EventArgs e)
        {

        }
    }
}
