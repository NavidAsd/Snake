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
    public partial class Next_Level : Form
    {
        public Next_Level()
        {
            InitializeComponent();
            MessageBox.Show("به مرحله دوم خوش امدی این مرحله هم با قوانین مرحله قبل کار میکنه امید وارم خوش بگذره  توی این مرحله تایم آزاده پس راحت باش  ", "#موفق باشی#", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Next_Level_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("ایا از خروج اطمینان دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == exit)
            {
                this.Close();
            }
        }

        private void btnme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("# NavidAsadi #", "---Good Programer---", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textt txt = new textt();
            timer1.Enabled = false;
            txt.ShowDialog();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("خب سناریو اینه (: حالا که به خونه رسیدی لازمه که بری بیرون و با سکه هایی که جمع کردی گوشت بخری ", "راهنمایی", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {                   
                lblunder.Top += 29;
            }
            else
            {
                MessageBox.Show("لطفا روی ادامه کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtms.Text = (Int32.Parse(txtms.Text) + 1).ToString();
            if (Int32.Parse(txtms.Text) == 59)
            {

                txtsecend.Text = (Int32.Parse(txtsecend.Text) + 1).ToString();
                txtms.Text = "0";
            }
            if (Int32.Parse(txtsecend.Text) == 59)
            {

                txtmin.Text = (Int32.Parse(txtmin.Text) + 1).ToString();
                txtsecend.Text = "0";
            }
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsecend.Text = "0";
            txtmin.Text = "0";
            txtms.Text = "0";
            timer1.Enabled = true;
        }

        private void btnpaus_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btntop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                lblunder.Top -= 29;
            }
            else
            {
                MessageBox.Show("لطفا روی ادامه کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                lblunder.Left -= 25;
            }
            else
            {
                MessageBox.Show("لطفا روی ادامه کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                lblunder.Left += 25;
            }
            else
            {
                MessageBox.Show("لطفا روی ادامه کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
