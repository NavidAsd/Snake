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
    // Author Navid Asadi
    public partial class oneproject : Form
    {
        

        
        int num = 51, num2 = 61, joon = 4, score = 0, win = 0, loser = 0, nottry = 0, sco = 0;

        public oneproject()
        {
            InitializeComponent();
            DialogResult run = MessageBox.Show(" کاربر عزیز دقت کن که بتونی مار رو به سلامت به خونه برسونی البته قبل از رسیدن توجه کن که امتیازت به 70 رسیده باشه در غیر اینصورت باید دوباره بازی کنی و حواست به زمان باشه که 60 ثانیه وقت داری  ", "#موفق باشی#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (DialogResult.OK == run)
            {
                picoff1.Hide();
                picoff2.Hide();
                picoff3.Hide();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
        }

        private void btnme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("# NavidAsadi #", "---Good Programer---", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("ایا از خروج اطمینان دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == exit)
            {
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //time

            if (piccarec.Location.Equals(picoff1.Location))
            {
                piccarec.Location = new Point(64, 412);
            }

            if (piccarec.Location.Equals(picoff1.Location))
            {
                piccarec.Location = new Point(64, 412);
            }
            if (piccarec.Location.Equals(picoff2.Location))
            {
                piccarec.Location = new Point(308, 412);
            }
            if (piccarec.Location.Equals(picoff3.Location))
            {
                piccarec.Location = new Point(491, 412);
            }

            //timer code
            txts.Text = (Int32.Parse(txts.Text) - 1).ToString();
            if (Int32.Parse(txts.Text) == 0)
            {
                txtmin.Text = "0";
                txtsecend.Text = (Int32.Parse(txtsecend.Text) - 1).ToString();
                txts.Text = "59";
            }
            if (txtsecend.Text == "0")
            {
                txtsecend.Text = "999";
                txts.Hide();
                DialogResult trry = MessageBox.Show("متاسفم زمان شما به پایان رسیده میخوای دوباره امتحان کنی؟", "اتمام وقت", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (DialogResult.Yes == trry)
                {
                    txts.Show();
                    txts.Text = "59";
                    txtsecend.Text = "59";
                    txtmin.Text = "0";
                    timer1.Enabled = true;
                    score = 0;
                    joon = 4;
                    piccarec.Location = new Point(64, 412);
                    picmn3.Location = new Point(308, 412);
                    picmn3.Show();
                    picmn4.Location = new Point(735, 361);
                    picmn4.Show();
                    picmany.Location = new Point(186, 259);
                    picmany.Show();
                    picmany2.Location = new Point(125, 310);
                    picmany2.Show();
                    picmn1.Location = new Point(64, 259);
                    picmn1.Show();
                    picmn5.Location = new Point(674, 208);
                    picmn5.Show();
                    picmn8.Location = new Point(552, 208);
                    picmn8.Show();
                    picmn9.Location = new Point(430, 208);
                    picmn9.Show();
                    picmn6.Location = new Point(735, 4);
                    picmn6.Show();

                    picmn10.Location = new Point(552, 4);
                    picmn10.Show();
                    picmn11.Location = new Point(491, 412);
                    picmn11.Show();
                }
                else if (DialogResult.No == trry)
                {
                    MessageBox.Show("بعدا شانستو امتحان کن(: ء", " # (: #");
                    this.Close();
                }
            


            }



            //text
            txtjon.Text = joon + "";
            txtscore.Text = score + "";
            txtlose.Text = loser + "";
            txtwin.Text = win + "";

        }

        private void btnpaus_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            txts.Text = "59";
            txtsecend.Text = "60";
            txtmin.Text = "0";
            nottry = 0;
            timer1.Enabled = true;
            score = 0;
            joon = 4;
            nottry = 0;
            piccarec.Location = new Point(64, 412);
            picmn3.Location = new Point(308, 412);
            picmn3.Show();
            picmn4.Location = new Point(735, 361);
            picmn4.Show();
            picmany.Location = new Point(186, 259);
            picmany.Show();

            picmn1.Location = new Point(64, 259);
            picmn1.Show();
            picmn5.Location = new Point(674, 208);
            picmn5.Show();
            picmn8.Location = new Point(552, 208);
            picmn8.Show();
            picmn9.Location = new Point(430, 208);
            picmn9.Show();
            picmn6.Location = new Point(735, 4);
            picmn6.Show();
            picmany2.Location = new Point(125, 310);
            picmany2.Show();
            picmn10.Location = new Point(552, 4);
            picmn10.Show();
            picmn11.Location = new Point(491, 412);
            picmn11.Show();
        }

        private void btntop_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
            {
                piccarec.Top -= num;
                textBox1.Location = new Point(-3, 460);
                textBox1.Clear();
                if (nottry == 0)
                {
                    if (txtjon.Text == "2")
                    {
                        MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                        nottry += 1;
                    }
                }
                if (txtscore.Text == "65")
                {
                    if (sco == 0)
                    {
                        MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sco += 1;
                    }
                }
                if (piccarec.Location.Equals(picfr16.Location))
                {
                    piccarec.Location = new Point(186, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr17.Location))
                {
                    piccarec.Location = new Point(247, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox1.Location))
                {
                    piccarec.Location = new Point(125, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr41.Location))
                {
                    piccarec.Location = new Point(186, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr33.Location))
                {
                    piccarec.Location = new Point(430, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox14.Location))
                {
                    piccarec.Location = new Point(552, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr39.Location))
                {
                    piccarec.Location = new Point(552, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox27.Location))
                {
                    piccarec.Location = new Point(125, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(186, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox25.Location))
                {
                    piccarec.Location = new Point(247, 106);
                    joon -= 1;
                }

                if (piccarec.Location.Equals(pictureBox25.Location))
                {
                    piccarec.Location = new Point(247, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr17.Location))
                {
                    piccarec.Location = new Point(186, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox15.Location))
                {
                    piccarec.Location = new Point(308, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr17.Location))
                {
                    piccarec.Location = new Point(186, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr17.Location))
                {
                    piccarec.Location = new Point(247, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr11.Location))
                {
                    piccarec.Location = new Point(308, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr19.Location))
                {
                    piccarec.Location = new Point(369, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox24.Location))
                {
                    piccarec.Location = new Point(369, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox23.Location))
                {
                    piccarec.Location = new Point(430, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox22.Location))
                {
                    piccarec.Location = new Point(491, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox22.Location))
                {
                    piccarec.Location = new Point(491, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox10.Location))
                {
                    piccarec.Location = new Point(7552, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox14.Location))
                {
                    piccarec.Location = new Point(552, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox13.Location))
                {
                    piccarec.Location = new Point(613, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox16.Location))
                {
                    piccarec.Location = new Point(613, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr14.Location))
                {
                    piccarec.Location = new Point(674, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr38.Location))
                {
                    piccarec.Location = new Point(613, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr32.Location))
                {
                    piccarec.Location = new Point(552, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr23.Location))
                {
                    piccarec.Location = new Point(491, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr21.Location))
                {
                    piccarec.Location = new Point(403, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr35.Location))
                {
                    piccarec.Location = new Point(308, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr9.Location))
                {
                    piccarec.Location = new Point(247, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr25.Location))
                {
                    piccarec.Location = new Point(186, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picmany2.Location))
                {
                    picmany2.Location = new Point(3, 463);
                    score += 15;
                    picmany2.Hide();

                }
                if (piccarec.Location.Equals(picfr3.Location))
                {
                    piccarec.Location = new Point(64, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr2.Location))
                {
                    joon -= 1;

                }
                if (piccarec.Location.Equals(picmn5.Location))
                {
                    score += 5;
                    picmn5.Hide();
                    picmn5.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(picmn6.Location))
                {
                    score += 5;
                    picmn6.Hide();
                    picmn6.Location = new Point(3, 463);
                }

                if (joon == 0)
                {
                    loser += 1;
                    DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == lose)
                    {
                        nottry = 0;
                        joon = 4;
                        score = 0;
                        piccarec.Location = new Point(64, 412);
                        txts.Text = "59";
                        txtsecend.Text = "60";
                        txtmin.Text = "0";
                        piccarec.Location = new Point(64, 412);
                        picmn3.Location = new Point(308, 412);
                        picmn3.Show();
                        picmany2.Location = new Point(125, 310);
                        picmany2.Show();
                        picmn4.Location = new Point(735, 361);
                        picmn4.Show();
                        picmany.Location = new Point(186, 259);
                        picmany.Show();

                        picmn1.Location = new Point(64, 259);
                        picmn1.Show();
                        picmn5.Location = new Point(674, 208);
                        picmn5.Show();
                        picmn8.Location = new Point(552, 208);
                        picmn8.Show();
                        picmn9.Location = new Point(430, 208);
                        picmn9.Show();
                        picmn6.Location = new Point(735, 4);
                        picmn6.Show();

                        picmn10.Location = new Point(552, 4);
                        picmn10.Show();
                        picmn11.Location = new Point(491, 412);
                        picmn11.Show();

                    }
                    else if (DialogResult.No == lose)
                    {
                        MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                piccarec.Top += num;
                textBox1.Location = new Point(-3, 460);
                textBox1.Clear();
                if (joon == 0)
                {

                    loser += 1;
                    DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == lose)
                    {
                        nottry = 0;
                        joon = 4;
                        score = 0;
                        piccarec.Location = new Point(64, 412);
                        txts.Text = "59";
                        txtsecend.Text = "60";
                        txtmin.Text = "0";
                        piccarec.Location = new Point(64, 412);
                        picmn3.Location = new Point(308, 412);
                        picmn3.Show();
                        picmn4.Location = new Point(735, 361);
                        picmn4.Show();
                        picmany.Location = new Point(186, 259);
                        picmany.Show();
                        picmany2.Location = new Point(125, 310);
                        picmany2.Show();
                        picmn1.Location = new Point(64, 259);
                        picmn1.Show();
                        picmn5.Location = new Point(674, 208);
                        picmn5.Show();
                        picmn8.Location = new Point(552, 208);
                        picmn8.Show();
                        picmn9.Location = new Point(430, 208);
                        picmn9.Show();
                        picmn6.Location = new Point(735, 4);
                        picmn6.Show();

                        picmn10.Location = new Point(552, 4);
                        picmn10.Show();
                        picmn11.Location = new Point(491, 412);
                        picmn11.Show();
                    }
                    else if (DialogResult.No == lose)
                    {
                        MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                        this.Close();
                    }
                }
                if (txtscore.Text == "65")
                {
                    if (sco == 0)
                    {
                        MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sco += 1;
                    }
                }
                if (piccarec.Location.Equals(pictureBox3.Location))
                {
                    piccarec.Location = new Point(125, 361);
                    joon -= 1;
                }

                if (piccarec.Location.Equals(picfr41.Location))
                {
                    piccarec.Location = new Point(186, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(186, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox15.Location))
                {
                    piccarec.Location = new Point(308, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr34.Location))
                {
                    piccarec.Location = new Point(430, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr40.Location))
                {
                    piccarec.Location = new Point(552, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox6.Location))
                {
                    piccarec.Location = new Point(247, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr14.Location))
                {
                    piccarec.Location = new Point(675, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr13.Location))
                {
                    piccarec.Location = new Point(613, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox14.Location))
                {
                    piccarec.Location = new Point(552, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr19.Location))
                {
                    piccarec.Location = new Point(369, 157);
                    joon -= 1;
                }
                if (nottry == 0)
                {
                    if (txtjon.Text == "2")
                    {
                        MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                        nottry += 1;
                    }
                }
                if (piccarec.Location.Equals(pictureBox22.Location))
                {
                    piccarec.Location = new Point(491, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox27.Location))
                {
                    piccarec.Location = new Point(125, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(186, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr15.Location))
                {
                    piccarec.Location = new Point(308, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr13.Location))
                {
                    piccarec.Location = new Point(125, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr16.Location))
                {
                    piccarec.Location = new Point(186, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr17.Location))
                {
                    piccarec.Location = new Point(247, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr11.Location))
                {
                    piccarec.Location = new Point(308, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr19.Location))
                {
                    piccarec.Location = new Point(369, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox24.Location))
                {
                    piccarec.Location = new Point(369, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox23.Location))
                {
                    piccarec.Location = new Point(430, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr33.Location))
                {
                    piccarec.Location = new Point(430, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox10.Location))
                {
                    piccarec.Location = new Point(552, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox16.Location))
                {
                    piccarec.Location = new Point(552, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox11.Location))
                {
                    piccarec.Location = new Point(675, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr14.Location))
                {
                    piccarec.Location = new Point(674, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox30.Location))
                {
                    piccarec.Location = new Point(735, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr20.Location))
                {
                    piccarec.Location = new Point(675, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr20.Location))
                {
                    piccarec.Location = new Point();
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr30.Location))
                {
                    piccarec.Location = new Point(613, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr28.Location))
                {
                    piccarec.Location = new Point(552, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr27.Location))
                {
                    piccarec.Location = new Point(403, 412);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr35.Location))
                {
                    piccarec.Location = new Point(308, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr9.Location))
                {
                    piccarec.Location = new Point(247, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr25.Location))
                {
                    piccarec.Location = new Point(186, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox4.Location))
                {
                    piccarec.Location = new Point(186, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr3.Location))
                {
                    piccarec.Location = new Point(64, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox3))
                {
                    piccarec.Location = new Point(125, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr23.Location))
                {
                    piccarec.Location = new Point(491, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picmn1.Location))
                {
                    score += 5;
                    picmn1.Hide();
                    picmn1.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(picmany2.Location))
                {
                    score += 15;
                    picmany2.Hide();
                    picmany2.Location = new Point(3, 463);
                }

                if (piccarec.Location.Equals(picmn11.Location))
                {
                    score += 5;
                    picmn11.Hide();
                    picmn11.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(pictureBox4.Location))
                {
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picmn3.Location))
                {
                    score += 5;
                    picmn3.Hide();
                    picmn3.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(picmn4.Location))
                {
                    score += 5;
                    picmn4.Hide();
                    picmn4.Location = new Point(3, 463);
                }

                if (piccarec.Location.Equals(pictureBox2.Location))
                {
                    piccarec.Location = new Point(369, 361);
                    joon -= 1;
                }
            }
            else
            {
                MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                piccarec.Left -= num2;
                textBox1.Location = new Point(-3, 460);
                textBox1.Clear();
                if (joon == 0)
                {

                    loser += 1;
                    DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == lose)
                    {
                        nottry = 0;
                        joon = 4;
                        score = 0;
                        piccarec.Location = new Point(64, 412);
                        txts.Text = "59";
                        txtsecend.Text = "60";
                        txtmin.Text = "0";
                        piccarec.Location = new Point(64, 412);
                        picmn3.Location = new Point(308, 412);
                        picmn3.Show();
                        picmn4.Location = new Point(735, 361);
                        picmn4.Show();
                        picmany.Location = new Point(186, 259);
                        picmany.Show();
                        picmany2.Location = new Point(125, 310);
                        picmany2.Show();
                        picmn1.Location = new Point(64, 259);
                        picmn1.Show();
                        picmn5.Location = new Point(674, 208);
                        picmn5.Show();
                        picmn8.Location = new Point(552, 208);
                        picmn8.Show();
                        picmn9.Location = new Point(430, 208);
                        picmn9.Show();
                        picmn6.Location = new Point(735, 4);
                        picmn6.Show();

                        picmn10.Location = new Point(552, 4);
                        picmn10.Show();
                        picmn11.Location = new Point(491, 412);
                        picmn11.Show();
                    }
                    else if (DialogResult.No == lose)
                    {
                        MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                        this.Close();
                    }
                }
                if (txtscore.Text == "65")
                {
                    if (sco == 0)
                    {
                        MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sco += 1;
                    }
                }
                if (piccarec.Location.Equals(pictureBox1.Location))
                {
                    piccarec.Location = new Point(186, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr3.Location))
                {
                    piccarec.Location = new Point(125, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr38.Location))
                {
                    piccarec.Location = new Point(674, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(247, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox15.Location))
                {
                    piccarec.Location = new Point(369, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr19.Location))
                {
                    piccarec.Location = new Point(430, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr1.Location))
                {
                    piccarec.Location = new Point(64, 412);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox6.Location))
                {
                    piccarec.Location = new Point(308, 412);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr14.Location))
                {
                    piccarec.Location = new Point(735, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr33.Location))
                {
                    piccarec.Location = new Point(491, 157);
                    joon -= 1;
                }
                if (nottry == 0)
                {
                    if (txtjon.Text == "2")
                    {
                        MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                        nottry += 1;
                    }

                }
                if (piccarec.Location.Equals(pictureBox28.Location))
                {
                    piccarec.Location = new Point(64, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr32.Location))
                {
                    piccarec.Location = new Point(64, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr12.Location))
                {
                    piccarec.Location = new Point(64, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr31.Location))
                {
                    piccarec.Location = new Point(64, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox29.Location))
                {
                    piccarec.Location = new Point(64, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox8.Location))
                {
                    piccarec.Location = new Point(64, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(247, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr15.Location))
                {
                    piccarec.Location = new Point(735, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr33.Location))
                {
                    piccarec.Location = new Point(430, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox14.Location))
                {
                    piccarec.Location = new Point(491, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox11.Location))
                {
                    piccarec.Location = new Point(735, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox12.Location))
                {
                    piccarec.Location = new Point(735, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr40.Location))
                {
                    piccarec.Location = new Point(613, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr20.Location))
                {
                    piccarec.Location = new Point(735, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr39.Location))
                {
                    piccarec.Location = new Point(613, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr15.Location))
                {
                    piccarec.Location = new Point(735, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr32.Location))
                {
                    piccarec.Location = new Point(613, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr27.Location))
                {
                    piccarec.Location = new Point(491, 412);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr35.Location))
                {
                    piccarec.Location = new Point(491, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr35.Location))
                {
                    piccarec.Location = new Point(369, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox1.Location))
                {
                    piccarec.Location = new Point(125, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr2.Location))
                {
                    piccarec.Location = new Point(64, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picmn9.Location))
                {
                    score += 5;
                    picmn9.Hide();
                    picmn9.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(picmn5.Location))
                {
                    score += 5;
                    picmn5.Hide();
                    picmn5.Location = new Point(3, 463);

                }
                if (piccarec.Location.Equals(picfr1.Location))
                {
                    joon -= 1;

                }
                if (piccarec.Location.Equals(picfr2.Location))
                {
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picmany.Location))
                {
                    score += 15;
                    picmany.Hide();
                    picmany.Location = new Point(3, 463);
                }
            }
            else
            {
                MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void oneproject_Load(object sender, EventArgs e)
        {
            //form
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //many 
        }

        private void picfr3_Click(object sender, EventArgs e)
        {
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" خب سناریو اینه : تا میتونی پول جمع کن و برو خونه (: از دکمه ها برای حرکت استفاده کن سعی کن 70 سکه جمع کنی و حواست باشه که  نسوزی تو کلا سه تا جون داری پس ازش درست استفاده کن  ", "راهنمایی ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textt txt = new textt();
            timer1.Enabled = false;
            txt.ShowDialog();
        }

        private void btntop_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Up || e.KeyData == Keys.W)
            {
                MessageBox.Show("dasdasdsad");

            }
        }

        private void oneproject_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtwin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                timer1.Enabled = true;
            }
            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = false;
            }
            if (e.KeyData == Keys.Escape)
            {
                DialogResult exit = MessageBox.Show("آیا از خروج اطمینان دارید؟","خروج",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DialogResult.Yes == exit)
                {
                    this.Close();
                }
            }
            if(e.KeyData==Keys.W|| e.KeyData == Keys.Up)
            {

                if (timer1.Enabled == true)
                {
                    piccarec.Top -= num;
                    textBox1.Location = new Point(74, 551);
                    if (nottry == 0)
                    {
                        if (txtjon.Text == "2")
                        {
                            MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                            nottry += 1;
                        }
                    }
                    if (txtscore.Text == "65")
                    {
                        if (sco == 0)
                        {
                            MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sco += 1;
                        }
                    }
                    if (piccarec.Location.Equals(picfr16.Location))
                    {
                        piccarec.Location = new Point(186, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr17.Location))
                    {
                        piccarec.Location = new Point(247, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox1.Location))
                    {
                        piccarec.Location = new Point(125, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr41.Location))
                    {
                        piccarec.Location = new Point(186, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr33.Location))
                    {
                        piccarec.Location = new Point(430, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox14.Location))
                    {
                        piccarec.Location = new Point(552, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr39.Location))
                    {
                        piccarec.Location = new Point(552, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox27.Location))
                    {
                        piccarec.Location = new Point(125, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(186, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox25.Location))
                    {
                        piccarec.Location = new Point(247, 106);
                        joon -= 1;
                    }

                    if (piccarec.Location.Equals(pictureBox25.Location))
                    {
                        piccarec.Location = new Point(247, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr17.Location))
                    {
                        piccarec.Location = new Point(186, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox15.Location))
                    {
                        piccarec.Location = new Point(308, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr17.Location))
                    {
                        piccarec.Location = new Point(186, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr17.Location))
                    {
                        piccarec.Location = new Point(247, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr11.Location))
                    {
                        piccarec.Location = new Point(308, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr19.Location))
                    {
                        piccarec.Location = new Point(369, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox24.Location))
                    {
                        piccarec.Location = new Point(369, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox23.Location))
                    {
                        piccarec.Location = new Point(430, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox22.Location))
                    {
                        piccarec.Location = new Point(491, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox22.Location))
                    {
                        piccarec.Location = new Point(491, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox10.Location))
                    {
                        piccarec.Location = new Point(7552, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox14.Location))
                    {
                        piccarec.Location = new Point(552, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox13.Location))
                    {
                        piccarec.Location = new Point(613, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox16.Location))
                    {
                        piccarec.Location = new Point(613, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr14.Location))
                    {
                        piccarec.Location = new Point(674, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr38.Location))
                    {
                        piccarec.Location = new Point(613, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr32.Location))
                    {
                        piccarec.Location = new Point(552, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr23.Location))
                    {
                        piccarec.Location = new Point(491, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr21.Location))
                    {
                        piccarec.Location = new Point(403, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr35.Location))
                    {
                        piccarec.Location = new Point(308, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr9.Location))
                    {
                        piccarec.Location = new Point(247, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr25.Location))
                    {
                        piccarec.Location = new Point(186, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picmany2.Location))
                    {
                        picmany2.Location = new Point(3, 463);
                        score += 15;
                        picmany2.Hide();

                    }
                    if (piccarec.Location.Equals(picfr3.Location))
                    {
                        piccarec.Location = new Point(64, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr2.Location))
                    {
                        joon -= 1;

                    }
                    if (piccarec.Location.Equals(picmn5.Location))
                    {
                        score += 5;
                        picmn5.Hide();
                        picmn5.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(picmn6.Location))
                    {
                        score += 5;
                        picmn6.Hide();
                        picmn6.Location = new Point(3, 463);
                    }

                    if (joon == 0)
                    {
                        loser += 1;
                        DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == lose)
                        {
                            nottry = 0;
                            joon = 4;
                            score = 0;
                            piccarec.Location = new Point(64, 412);
                            txts.Text = "59";
                            txtsecend.Text = "60";
                            txtmin.Text = "0";
                            piccarec.Location = new Point(64, 412);
                            picmn3.Location = new Point(308, 412);
                            picmn3.Show();
                            picmany2.Location = new Point(125, 310);
                            picmany2.Show();
                            picmn4.Location = new Point(735, 361);
                            picmn4.Show();
                            picmany.Location = new Point(186, 259);
                            picmany.Show();

                            picmn1.Location = new Point(64, 259);
                            picmn1.Show();
                            picmn5.Location = new Point(674, 208);
                            picmn5.Show();
                            picmn8.Location = new Point(552, 208);
                            picmn8.Show();
                            picmn9.Location = new Point(430, 208);
                            picmn9.Show();
                            picmn6.Location = new Point(735, 4);
                            picmn6.Show();

                            picmn10.Location = new Point(552, 4);
                            picmn10.Show();
                            picmn11.Location = new Point(491, 412);
                            picmn11.Show();

                        }
                        else if (DialogResult.No == lose)
                        {
                            MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (e.KeyData == Keys.S || e.KeyData == Keys.Down)
            {
                if (timer1.Enabled == true)
                {
                    piccarec.Top += num;
                    textBox1.Location = new Point(74, 551);
                    if (joon == 0)
                    {

                        loser += 1;
                        DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == lose)
                        {
                            nottry = 0;
                            joon = 4;
                            score = 0;
                            piccarec.Location = new Point(64, 412);
                            txts.Text = "59";
                            txtsecend.Text = "60";
                            txtmin.Text = "0";
                            piccarec.Location = new Point(64, 412);
                            picmn3.Location = new Point(308, 412);
                            picmn3.Show();
                            picmn4.Location = new Point(735, 361);
                            picmn4.Show();
                            picmany.Location = new Point(186, 259);
                            picmany.Show();
                            picmany2.Location = new Point(125, 310);
                            picmany2.Show();
                            picmn1.Location = new Point(64, 259);
                            picmn1.Show();
                            picmn5.Location = new Point(674, 208);
                            picmn5.Show();
                            picmn8.Location = new Point(552, 208);
                            picmn8.Show();
                            picmn9.Location = new Point(430, 208);
                            picmn9.Show();
                            picmn6.Location = new Point(735, 4);
                            picmn6.Show();

                            picmn10.Location = new Point(552, 4);
                            picmn10.Show();
                            picmn11.Location = new Point(491, 412);
                            picmn11.Show();
                        }
                        else if (DialogResult.No == lose)
                        {
                            MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                            this.Close();
                        }
                    }
                    if (txtscore.Text == "65")
                    {
                        if (sco == 0)
                        {
                            MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sco += 1;
                        }
                    }
                    if (piccarec.Location.Equals(pictureBox3.Location))
                    {
                        piccarec.Location = new Point(125, 361);
                        joon -= 1;
                    }

                    if (piccarec.Location.Equals(picfr41.Location))
                    {
                        piccarec.Location = new Point(186, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(186, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox15.Location))
                    {
                        piccarec.Location = new Point(308, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr34.Location))
                    {
                        piccarec.Location = new Point(430, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr40.Location))
                    {
                        piccarec.Location = new Point(552, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox6.Location))
                    {
                        piccarec.Location = new Point(247, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr14.Location))
                    {
                        piccarec.Location = new Point(675, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr13.Location))
                    {
                        piccarec.Location = new Point(613, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox14.Location))
                    {
                        piccarec.Location = new Point(552, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr19.Location))
                    {
                        piccarec.Location = new Point(369, 157);
                        joon -= 1;
                    }
                    if (nottry == 0)
                    {
                        if (txtjon.Text == "2")
                        {
                            MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                            nottry += 1;
                        }
                    }
                    if (piccarec.Location.Equals(pictureBox22.Location))
                    {
                        piccarec.Location = new Point(491, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox27.Location))
                    {
                        piccarec.Location = new Point(125, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(186, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr15.Location))
                    {
                        piccarec.Location = new Point(308, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr13.Location))
                    {
                        piccarec.Location = new Point(125, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr16.Location))
                    {
                        piccarec.Location = new Point(186, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr17.Location))
                    {
                        piccarec.Location = new Point(247, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr11.Location))
                    {
                        piccarec.Location = new Point(308, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr19.Location))
                    {
                        piccarec.Location = new Point(369, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox24.Location))
                    {
                        piccarec.Location = new Point(369, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox23.Location))
                    {
                        piccarec.Location = new Point(430, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr33.Location))
                    {
                        piccarec.Location = new Point(430, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox10.Location))
                    {
                        piccarec.Location = new Point(552, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox16.Location))
                    {
                        piccarec.Location = new Point(552, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox11.Location))
                    {
                        piccarec.Location = new Point(675, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr14.Location))
                    {
                        piccarec.Location = new Point(674, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox30.Location))
                    {
                        piccarec.Location = new Point(735, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr20.Location))
                    {
                        piccarec.Location = new Point(675, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr20.Location))
                    {
                        piccarec.Location = new Point();
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr30.Location))
                    {
                        piccarec.Location = new Point(613, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr28.Location))
                    {
                        piccarec.Location = new Point(552, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr27.Location))
                    {
                        piccarec.Location = new Point(403, 412);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr35.Location))
                    {
                        piccarec.Location = new Point(308, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr9.Location))
                    {
                        piccarec.Location = new Point(247, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr25.Location))
                    {
                        piccarec.Location = new Point(186, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox4.Location))
                    {
                        piccarec.Location = new Point(186, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr3.Location))
                    {
                        piccarec.Location = new Point(64, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox3))
                    {
                        piccarec.Location = new Point(125, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr23.Location))
                    {
                        piccarec.Location = new Point(491, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picmn1.Location))
                    {
                        score += 5;
                        picmn1.Hide();
                        picmn1.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(picmany2.Location))
                    {
                        score += 15;
                        picmany2.Hide();
                        picmany2.Location = new Point(3, 463);
                    }

                    if (piccarec.Location.Equals(picmn11.Location))
                    {
                        score += 5;
                        picmn11.Hide();
                        picmn11.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(pictureBox4.Location))
                    {
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picmn3.Location))
                    {
                        score += 5;
                        picmn3.Hide();
                        picmn3.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(picmn4.Location))
                    {
                        score += 5;
                        picmn4.Hide();
                        picmn4.Location = new Point(3, 463);
                    }

                    if (piccarec.Location.Equals(pictureBox2.Location))
                    {
                        piccarec.Location = new Point(369, 361);
                        joon -= 1;
                    }
                }
                else
                {
                    MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
            {

                if (timer1.Enabled == true)
                {
                    piccarec.Left -= num2;
                    textBox1.Location = new Point(74, 551);
                    if (joon == 0)
                    {

                        loser += 1;
                        DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == lose)
                        {
                            nottry = 0;
                            joon = 4;
                            score = 0;
                            piccarec.Location = new Point(64, 412);
                            txts.Text = "59";
                            txtsecend.Text = "60";
                            txtmin.Text = "0";
                            piccarec.Location = new Point(64, 412);
                            picmn3.Location = new Point(308, 412);
                            picmn3.Show();
                            picmn4.Location = new Point(735, 361);
                            picmn4.Show();
                            picmany.Location = new Point(186, 259);
                            picmany.Show();
                            picmany2.Location = new Point(125, 310);
                            picmany2.Show();
                            picmn1.Location = new Point(64, 259);
                            picmn1.Show();
                            picmn5.Location = new Point(674, 208);
                            picmn5.Show();
                            picmn8.Location = new Point(552, 208);
                            picmn8.Show();
                            picmn9.Location = new Point(430, 208);
                            picmn9.Show();
                            picmn6.Location = new Point(735, 4);
                            picmn6.Show();

                            picmn10.Location = new Point(552, 4);
                            picmn10.Show();
                            picmn11.Location = new Point(491, 412);
                            picmn11.Show();
                        }
                        else if (DialogResult.No == lose)
                        {
                            MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                            this.Close();
                        }
                    }
                    if (txtscore.Text == "65")
                    {
                        if (sco == 0)
                        {
                            MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sco += 1;
                        }
                    }
                    if (piccarec.Location.Equals(pictureBox1.Location))
                    {
                        piccarec.Location = new Point(186, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr3.Location))
                    {
                        piccarec.Location = new Point(125, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr38.Location))
                    {
                        piccarec.Location = new Point(674, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(247, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox15.Location))
                    {
                        piccarec.Location = new Point(369, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr19.Location))
                    {
                        piccarec.Location = new Point(430, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr1.Location))
                    {
                        piccarec.Location = new Point(64, 412);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox6.Location))
                    {
                        piccarec.Location = new Point(308, 412);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr14.Location))
                    {
                        piccarec.Location = new Point(735, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr33.Location))
                    {
                        piccarec.Location = new Point(491, 157);
                        joon -= 1;
                    }
                    if (nottry == 0)
                    {
                        if (txtjon.Text == "2")
                        {
                            MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                            nottry += 1;
                        }

                    }
                    if (piccarec.Location.Equals(pictureBox28.Location))
                    {
                        piccarec.Location = new Point(64, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr32.Location))
                    {
                        piccarec.Location = new Point(64, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr12.Location))
                    {
                        piccarec.Location = new Point(64, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr31.Location))
                    {
                        piccarec.Location = new Point(64, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox29.Location))
                    {
                        piccarec.Location = new Point(64, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox8.Location))
                    {
                        piccarec.Location = new Point(64, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(247, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr15.Location))
                    {
                        piccarec.Location = new Point(735, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr33.Location))
                    {
                        piccarec.Location = new Point(430, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox14.Location))
                    {
                        piccarec.Location = new Point(491, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox11.Location))
                    {
                        piccarec.Location = new Point(735, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox12.Location))
                    {
                        piccarec.Location = new Point(735, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr40.Location))
                    {
                        piccarec.Location = new Point(613, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr20.Location))
                    {
                        piccarec.Location = new Point(735, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr39.Location))
                    {
                        piccarec.Location = new Point(613, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr15.Location))
                    {
                        piccarec.Location = new Point(735, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr32.Location))
                    {
                        piccarec.Location = new Point(613, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr27.Location))
                    {
                        piccarec.Location = new Point(491, 412);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr35.Location))
                    {
                        piccarec.Location = new Point(491, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr35.Location))
                    {
                        piccarec.Location = new Point(369, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox1.Location))
                    {
                        piccarec.Location = new Point(125, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr2.Location))
                    {
                        piccarec.Location = new Point(64, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picmn9.Location))
                    {
                        score += 5;
                        picmn9.Hide();
                        picmn9.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(picmn5.Location))
                    {
                        score += 5;
                        picmn5.Hide();
                        picmn5.Location = new Point(3, 463);

                    }
                    if (piccarec.Location.Equals(picfr1.Location))
                    {
                        joon -= 1;

                    }
                    if (piccarec.Location.Equals(picfr2.Location))
                    {
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picmany.Location))
                    {
                        score += 15;
                        picmany.Hide();
                        picmany.Location = new Point(3, 463);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
            {
                if (timer1.Enabled == true)
                {
                    piccarec.Left += num2;
                    textBox1.Location = new Point(74, 551);
                    if (joon == 0)
                    {
                        loser += 1;

                        DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == lose)
                        {
                            nottry = 0;
                            joon = 4;
                            score = 0;
                            piccarec.Location = new Point(64, 412);
                            txts.Text = "59";
                            txtsecend.Text = "60";
                            txtmin.Text = "0";
                            piccarec.Location = new Point(64, 412);
                            picmn3.Location = new Point(308, 412);
                            picmn3.Show();
                            picmn4.Location = new Point(735, 361);
                            picmn4.Show();
                            picmany.Location = new Point(186, 259);
                            picmany.Show();
                            picmany2.Location = new Point(125, 310);
                            picmany2.Show();
                            picmn1.Location = new Point(64, 259);
                            picmn1.Show();
                            picmn5.Location = new Point(674, 208);
                            picmn5.Show();
                            picmn8.Location = new Point(552, 208);
                            picmn8.Show();
                            picmn9.Location = new Point(430, 208);
                            picmn9.Show();
                            picmn6.Location = new Point(735, 4);
                            picmn6.Show();
                            picmn10.Location = new Point(552, 4);
                            picmn10.Show();
                            picmn11.Location = new Point(491, 412);
                            picmn11.Show();
                        }
                        else if (DialogResult.No == lose)
                        {
                            MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                            this.Close();
                        }
                    }
                    if (txtscore.Text == "65")
                    {
                        if (sco == 0)
                        {
                            MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sco += 1;
                        }
                    }
                    if (piccarec.Location.Equals(picfr25.Location))
                    {
                        piccarec.Location = new Point(125, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(125, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pichome.Location))
                    {
                        if (score < 70)
                        {
                            MessageBox.Show("دقت کن سکه هات هنوز به 70 نرسیده", "---", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            piccarec.Location = new Point(552, 4);
                        }
                    }

                    if (piccarec.Location.Equals(picfr38.Location))
                    {
                        piccarec.Location = new Point(552, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr14.Location))
                    {
                        piccarec.Location = new Point(491, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox25.Location))
                    {
                        piccarec.Location = new Point(186, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr13.Location))
                    {
                        piccarec.Location = new Point(64, 208);
                        joon -= 1;
                    }
                    if (nottry == 0)
                    {
                        if (txtjon.Text == "2")
                        {
                            MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                            nottry += 1;
                        }
                    }
                    if (piccarec.Location.Equals(pictureBox27.Location))
                    {
                        piccarec.Location = new Point(64, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr42.Location))
                    {
                        piccarec.Location = new Point(125, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox15.Location))
                    {
                        piccarec.Location = new Point(247, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr13.Location))
                    {
                        piccarec.Location = new Point(125, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr33.Location))
                    {
                        piccarec.Location = new Point(369, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox12.Location))
                    {
                        piccarec.Location = new Point(552, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox21.Location))
                    {
                        piccarec.Location = new Point(735, 4);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox20.Location))
                    {
                        piccarec.Location = new Point(769, 55);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox19.Location))
                    {
                        piccarec.Location = new Point(735, 106);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr14.Location))
                    {
                        piccarec.Location = new Point(675, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr18.Location))
                    {
                        piccarec.Location = new Point(735, 157);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox9.Location))
                    {
                        piccarec.Location = new Point(735, 208);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox7.Location))
                    {
                        piccarec.Location = new Point(735, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox31.Location))
                    {
                        piccarec.Location = new Point(735, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr36.Location))
                    {
                        piccarec.Location = new Point(735, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr40.Location))
                    {
                        piccarec.Location = new Point(552, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr20.Location))
                    {
                        piccarec.Location = new Point(613, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr15.Location))
                    {
                        piccarec.Location = new Point(613, 361);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr28.Location))
                    {
                        piccarec.Location = new Point(552, 412);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr34.Location))
                    {
                        piccarec.Location = new Point(369, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picfr21.Location))
                    {
                        piccarec.Location = new Point(369, 310);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox1.Location))
                    {
                        piccarec.Location = new Point(64, 259);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(pictureBox3.Location))
                    {
                        piccarec.Location = new Point(64, 412);
                        joon -= 1;
                    }
                    if (piccarec.Location.Equals(picmn10.Location))
                    {
                        score += 5;
                        picmn10.Hide();
                        picmn10.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(picmn8.Location))
                    {
                        score += 5;
                        picmn8.Hide();
                        picmn8.Location = new Point(3, 463);
                    }
                    if (piccarec.Location.Equals(pictureBox2.Location))
                    {
                        pictureBox2.Location = new Point(308, 412);
                        joon -= 1;

                    }
                    if (piccarec.Location.Equals(pictureBox3.Location))
                    {
                        joon -= 1;

                    }
                    if (score >= 70)
                    {
                        if (piccarec.Location.Equals(pichome.Location))
                        {
                            piccarec.Hide();
                            win += 1;
                            MessageBox.Show("افرین شما با موفقیت مرحله اول رو به پایان رسوندی!  ء", "برنده شدی ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult next = MessageBox.Show("میخوای به مرحله بعدی بری؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult.Yes == next)
                            {
                                timer1.Enabled = false;
                                DialogResult emtyaz = MessageBox.Show("میخوای به ما امتیاز بدی؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DialogResult.Yes == emtyaz)
                                {
                                    textt nm = new textt();
                                    nm.ShowDialog();
                                }
                                this.Hide();
                                Next_Level st = new Next_Level();
                                st.ShowDialog();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("کارت خوب بود!  ء");
                                this.Close();
                            }
                        }

                    }

                    /* if ( num2 < 61)
                     {
                         num2 += 1;
                     }
                     else if (num2 > 60)
                     {
                         num2 -= 1;
                     }*/

                }
                else
                {
                    MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        

    }
        }

        private void picfr16_Click(object sender, EventArgs e)
        {

        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtscore.Text = score + "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                piccarec.Left += num2;
                textBox1.Location = new Point(-3, 460);
                textBox1.Clear();

                if (joon == 0)
                {
                    loser += 1;

                    DialogResult lose = MessageBox.Show("اوه متاسفم شما تمام فرصتتو از دست دادی  میخوای دوباره تلاش کنی؟", " باختی:( ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == lose)
                    {
                        nottry = 0;
                        joon = 4;
                        score = 0;
                        piccarec.Location = new Point(64, 412);
                        txts.Text = "59";
                        txtsecend.Text = "60";
                        txtmin.Text = "0";
                        piccarec.Location = new Point(64, 412);
                        picmn3.Location = new Point(308, 412);
                        picmn3.Show();
                        picmn4.Location = new Point(735, 361);
                        picmn4.Show();
                        picmany.Location = new Point(186, 259);
                        picmany.Show();
                        picmany2.Location = new Point(125, 310);
                        picmany2.Show();
                        picmn1.Location = new Point(64, 259);
                        picmn1.Show();
                        picmn5.Location = new Point(674, 208);
                        picmn5.Show();
                        picmn8.Location = new Point(552, 208);
                        picmn8.Show();
                        picmn9.Location = new Point(430, 208);
                        picmn9.Show();
                        picmn6.Location = new Point(735, 4);
                        picmn6.Show();
                        picmn10.Location = new Point(552, 4);
                        picmn10.Show();
                        picmn11.Location = new Point(491, 412);
                        picmn11.Show();
                    }
                    else if (DialogResult.No == lose)
                    {
                        MessageBox.Show("از حسن انتخاب شما متشکریم# 87# ");
                        this.Close();
                    }
                }
                if (txtscore.Text == "65")
                {
                    if (sco == 0)
                    {
                        MessageBox.Show("فقط 5 امتیاز نیاز داری عجله کن", "امتیاز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sco += 1;
                    }
                }
                if (piccarec.Location.Equals(picfr25.Location))
                {
                    piccarec.Location = new Point(125, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(125, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pichome.Location))
                {
                    if (score < 70)
                    {
                        MessageBox.Show("دقت کن سکه هات هنوز به 70 نرسیده", "---", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        piccarec.Location = new Point(552, 4);
                    }
                }

                if (piccarec.Location.Equals(picfr38.Location))
                {
                    piccarec.Location = new Point(552, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr14.Location))
                {
                    piccarec.Location = new Point(491, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox25.Location))
                {
                    piccarec.Location = new Point(186, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr13.Location))
                {
                    piccarec.Location = new Point(64, 208);
                    joon -= 1;
                }
                if (nottry == 0)
                {
                    if (txtjon.Text == "2")
                    {
                        MessageBox.Show("شما یک فرصت دیگه دارید!! با دقت بیشتری ادامه بده");
                        nottry += 1;
                    }
                }
                if (piccarec.Location.Equals(pictureBox27.Location))
                {
                    piccarec.Location = new Point(64, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr42.Location))
                {
                    piccarec.Location = new Point(125, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox15.Location))
                {
                    piccarec.Location = new Point(247, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr13.Location))
                {
                    piccarec.Location = new Point(125, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr33.Location))
                {
                    piccarec.Location = new Point(369, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox12.Location))
                {
                    piccarec.Location = new Point(552, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox21.Location))
                {
                    piccarec.Location = new Point(735, 4);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox20.Location))
                {
                    piccarec.Location = new Point(769, 55);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox19.Location))
                {
                    piccarec.Location = new Point(735, 106);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr14.Location))
                {
                    piccarec.Location = new Point(675, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr18.Location))
                {
                    piccarec.Location = new Point(735, 157);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox9.Location))
                {
                    piccarec.Location = new Point(735, 208);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox7.Location))
                {
                    piccarec.Location = new Point(735, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox31.Location))
                {
                    piccarec.Location = new Point(735, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr36.Location))
                {
                    piccarec.Location = new Point(735, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr40.Location))
                {
                    piccarec.Location = new Point(552, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr20.Location))
                {
                    piccarec.Location = new Point(613, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr15.Location))
                {
                    piccarec.Location = new Point(613, 361);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr28.Location))
                {
                    piccarec.Location = new Point(552, 412);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr34.Location))
                {
                    piccarec.Location = new Point(369, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picfr21.Location))
                {
                    piccarec.Location = new Point(369, 310);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox1.Location))
                {
                    piccarec.Location = new Point(64, 259);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(pictureBox3.Location))
                {
                    piccarec.Location = new Point(64, 412);
                    joon -= 1;
                }
                if (piccarec.Location.Equals(picmn10.Location))
                {
                    score += 5;
                    picmn10.Hide();
                    picmn10.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(picmn8.Location))
                {
                    score += 5;
                    picmn8.Hide();
                    picmn8.Location = new Point(3, 463);
                }
                if (piccarec.Location.Equals(pictureBox2.Location))
                {
                    pictureBox2.Location = new Point(308, 412);
                    joon -= 1;

                }
                if (piccarec.Location.Equals(pictureBox3.Location))
                {
                    joon -= 1;

                }
                if (score >= 70)
                {
                    if (piccarec.Location.Equals(pichome.Location))
                    {
                        piccarec.Hide();
                        win += 1;
                        MessageBox.Show("افرین شما با موفقیت مرحله اول رو به پایان رسوندی!  ء", "برنده شدی ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult next = MessageBox.Show("میخوای به مرحله بعدی بری؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == next)
                        {
                            timer1.Enabled = false;
                            DialogResult emtyaz = MessageBox.Show("میخوای به ما امتیاز بدی؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult.Yes == emtyaz)
                            {
                                textt nm = new textt();
                                nm.ShowDialog();
                            }
                            this.Hide();
                            Next_Level st = new Next_Level();
                            st.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("کارت خوب بود!  ء");
                            this.Close();
                        }
                    }

                }

                /* if ( num2 < 61)
                 
                     num2 += 1;*/
               

            }
            else
            {
                MessageBox.Show("لطفا روی شروع کلیک کن", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }

}
