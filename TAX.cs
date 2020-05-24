using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX_Calculator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void คาลดหยอนสวนตวและครอบครวToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void รายไดคาใชจายToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void รายไดคาใชจายToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel3.Show();
            panel5.Hide();
            panel1.Hide();
            panel8.Hide();
            panel10.Hide();
            panel12.Hide();
            panel14.Hide();
        }

        private void คาลดหยอนสวนตวและครอบครวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cal1_Click(object sender, EventArgs e)
        {
            //คำนวณรายได้
            int s1 = int.Parse(salary1.Text);
            int s2 = int.Parse(salary2.Text);
            int salarysum;
            salarysum = (s1 * 12 + s2);
            salary3.Text = salarysum.ToString();

            //คำนวณค่าใช้จ่าย
            int s = int.Parse(salary3.Text);
            int p = s * 50 / 100;//ค่าใช้จ่ายแบบเหมา
            if (p <= 100000)
                p = s * 50 / 100;
            else
                p = 100000;
            textBox2.Text = p.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
            panel1.Hide();
            panel8.Hide();
            panel10.Hide();
            panel12.Hide();
            panel14.Hide();
        }

        private void คาลดหยอนสวนตวและครอบครวToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            panel5.Show();
            panel3.Hide();
            panel1.Hide();
            panel8.Hide();
            panel10.Hide();
            panel12.Hide();
            panel14.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                insurance2.Enabled = false;
                groupBox4.Enabled = false;
                b5.Enabled = false;
            }
            else
            {
                groupBox4.Enabled = true;
                b5.Enabled = true;
            }
            int couple = 0;
            insurance2.Text = couple.ToString();
            int b = 0;
            b5.Text = b.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox4.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                insurance2.Enabled = false;
                groupBox4.Enabled = false;
            }
            else
            {
                groupBox4.Enabled = true;
            }

            int couple = 0;
            insurance2.Text = couple.ToString();
            int b = 0;
            b5.Text = b.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int couple = 60000;
            insurance2.Text = couple.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                insurance2.Enabled = false;
                b5.Enabled = false;
            }

            int couple = 0;
            insurance2.Text = couple.ToString();
            int b = 0;
            b5.Text = b.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int couple = 60000;
            insurance2.Text = couple.ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                insurance3.Enabled = false;
                box1.Enabled = false;
                box2.Enabled = false;
            }
            else
            {
                box1.Enabled = true;
                box2.Enabled = true;
            }
            int son = 0;
            insurance3.Text = son.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = int.Parse(box1.Text);
            int i = int.Parse(box2.Text);
            int n = k - i;
            int son1 = 30000 * n;
            int son2 = 60000 * i;

            if (k == 1 && i == 1)
            {
                int all_son = 30000;
                insurance3.Text = all_son.ToString();
            }
            else
            {
                int all_son = son1 + son2;
                insurance3.Text = all_son.ToString();
            }
        }

        private void box3_Leave(object sender, EventArgs e)
        {
            int m = int.Parse(box3.Text);
            insurance4.Text = m.ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                box4.Enabled = false;
                insurance5.Enabled = false;
            }
            else
            {
                box4.Enabled = true;
            }
            int b4 = 0;
            insurance5.Text = b4.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                box4.Enabled = true;
            }
            else
            {
                insurance5.Enabled = false;
            }
            int b4 = int.Parse(box4.Text);
            int t = 30000 * b4;
            insurance5.Text = t.ToString();
        }

        private void box4_Leave(object sender, EventArgs e)
        {
            int b4 = int.Parse(box4.Text);
            int t = 30000 * b4;
            insurance5.Text = t.ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                insurance6.Enabled = false;
                box5.Enabled = false;
            }
            else
            {
                box5.Enabled = true;
            }
            int unable = 0;
            insurance6.Text = unable.ToString();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box5_Leave(object sender, EventArgs e)
        {
            int b5 = int.Parse(box5.Text);
            int m = 60000 * b5;
            insurance6.Text = m.ToString();
        }

        private void cal2_Click(object sender, EventArgs e)
        {
            int i1 = int.Parse(insurance1.Text);
            int i2 = int.Parse(insurance2.Text);
            int i3 = int.Parse(insurance3.Text);
            int i4 = int.Parse(insurance4.Text);
            int i5 = int.Parse(insurance5.Text);
            int i6 = int.Parse(insurance6.Text);
            int insurancesum;
            insurancesum = (i1 + i2 + i3 + i4 + i5 + i6);
            total1.Text = insurancesum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(salary1.Text);
            int s2 = int.Parse(salary2.Text);
            int salarysum;
            salarysum = (s1 * 12 + s2);
            int i1 = int.Parse(b1.Text);
            int i2 = int.Parse(b2.Text);
            int i3 = int.Parse(b3.Text);
            int i4 = int.Parse(b4.Text);
            int i5 = int.Parse(b5.Text);
            int i6 = int.Parse(b6.Text);
            int i7 = int.Parse(b6.Text);
            int sum2_3 = i2 + i3;
            if (i1 <= 9000)
            {}
            else 
            {
                i1 = 9000;
            }

            if (sum2_3 <= 100000)
            {}
            else 
            {
                sum2_3 = 100000;
            }

            if (i4 <= 15000)
            {}
            else 
            {
                i4 = 15000;
            }

            if (i5 <= 10000)
            {}
            else 
            {
                i5 = 10000;
            }

            if (i6 <= 10000)
            {}
            else if ((i6 > 10000) && (i6 <= (salarysum * 15 / 100)) && (i6 <= 490000))
            {}
            else if ((i6 > 10000) && (i6 > (salarysum * 15 / 100)) && (i6 > 490000))
            {
                i6 = 490000;
            }

            if ((i7 <= 500000) || (i7 <= (salarysum * 15 / 100)))
            {}
            else if ((i7 > 500000) || (i7 > (salarysum * 15 / 100)))
            {
                i7 = 500000;
            }
            int insurancesum;
            insurancesum = (i1 + i2 + i3 + i4 + i5 + i6 +i7);
            total2.Text = insurancesum.ToString();

        }

        private void คาลดหยอนกลมประกนเงนออมและการลงทนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel3.Hide();
            panel1.Show();
            panel8.Hide();
            panel10.Hide();
            panel12.Hide();
            panel14.Hide();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
            int home62 = 0;
            numericUpDown4.Text = home62.ToString();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
            }
            int home58 = 0;
            numericUpDown3.Text = home58.ToString();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                groupBox3.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox1.Enabled = true;
            }
            int home58 = 0;
            numericUpDown3.Text = home58.ToString();
            int home62 = 0;
            numericUpDown4.Text = home62.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(c1.Text);
            int c = int.Parse(numericUpDown1.Text);
            if (a <= 3000000 && c <= 5)
            {
                int b = a * 4 / 100;
                numericUpDown3.Text = b.ToString();
            }
            else
            {
                int b = 0;
                numericUpDown3.Text = b.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(c2.Text);
            if (a <= 200000)
            {
                int b = a;
                numericUpDown4.Text = b.ToString();
            }
            else if (200000 < a && a <= 5000000)
            {
                int b = 200000;
                numericUpDown4.Text = b.ToString();
            }
            else if (a > 5000000)
            {
                int b = 0;
                numericUpDown4.Text = b.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i1 = int.Parse(numericUpDown2.Text);
            int i2 = int.Parse(numericUpDown3.Text);
            int i3 = int.Parse(numericUpDown4.Text);
            int insurancesum;
            insurancesum = (i1 + i2 + i3);
            total3.Text = insurancesum.ToString();
        }

        private void คาลดหยอนอสงหารมทรพยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
            panel1.Hide();
            panel8.Show();
            panel10.Hide();
            panel12.Hide();
            panel14.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ค่าลดหย่อนมาตรการกระตุ้นเศรษฐกิจ
            int i1 = int.Parse(d1.Text);
            int i2 = int.Parse(d2.Text);
            int i3 = int.Parse(d3.Text);
            int i4 = int.Parse(d4.Text);
            int i5 = int.Parse(d5.Text);
            int i6 = int.Parse(d6.Text);
            int i7 = int.Parse(d7.Text);
            int i8 = int.Parse(d8.Text);
            int i9 = int.Parse(d9.Text);
            int sum4_5 = i4 + i5;
            if (sum4_5 <= 20000)
            {}
            else
            {
                sum4_5 = 20000;
            }
            int insurancesum;
            insurancesum = (i1 + i2 + i3 + sum4_5 + i6 + i7 + i8 + i9);
            total4.Text = insurancesum.ToString();
        }

        private void คาลดหยอนตามมาตรการกระตนเศรษฐกจของรฐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
            panel1.Hide();
            panel8.Hide();
            panel10.Show();
            panel12.Hide();
            panel14.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ค่าลดหย่อนกลุ่มเงินบริจาค
            int i1 = int.Parse(e1.Text);//การศึกษา
            int a = i1 * 2;
            int i2 = int.Parse(e2.Text);//พยาบาล
            int b = i2 * 2;
            int i3 = int.Parse(e3.Text);//กีฬา
            int c = i3 * 2;
            int i4 = int.Parse(e4.Text);//ประโยชน์
            int d = i4 * 2;
            int abcd = a + b + c + d;//รวมการศึกษา พยาบาล กีฬา ประโยชน์

            int s1 = int.Parse(salary3.Text);//รายได้
            int s2 = int.Parse(textBox2.Text);//ค่าใช้จ่าย
            int t1 = int.Parse(total1.Text);
            int t2 = int.Parse(total2.Text);
            int t3 = int.Parse(total3.Text);
            int t4 = int.Parse(total4.Text);
            int all = s1-(s2+t1+t2+t3+t4);
            int all_sum = all * 10 / 100;
            if (abcd <= all_sum)
            {
            
            }
            else
            {
                abcd = all_sum;
            }

            int i5 = int.Parse(e5.Text);//ปาบึก
            int i6 = int.Parse(e6.Text);//ทั่วไป
            if (i6 <= all_sum)
            {

            }
            else
            {
                i6 = all_sum;
            }
            int i7 = int.Parse(e7.Text);//การเมือง
            int insurancesum;
            insurancesum = (abcd + i5 + i6 + i7);
            total5.Text = insurancesum.ToString();
        }

        private void คาลดหยอนกลมเงนบรจาคToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Hide();
            panel1.Hide();
            panel8.Hide();
            panel10.Hide();
            panel12.Show();
            panel14.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void คำนวณภาษToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ปุ่มไปหน้าคำนวณภาษี
            int s1 = int.Parse(salary3.Text);//รายได้
            int s2 = int.Parse(textBox2.Text);//ค่าใช้จ่าย
            int t1 = int.Parse(total1.Text);
            int t2 = int.Parse(total2.Text);
            int t3 = int.Parse(total3.Text);
            int t4 = int.Parse(total4.Text);
            int t5 = int.Parse(total5.Text);

            int totalsum = t1 + t2 + t3 + t4 + t5;//รวมค่าลดหย่อน
            total_all.Text = totalsum.ToString();

            int salarysum = s1 - (s2 + totalsum);//รายได้สุทธิ
            s_all.Text = salarysum.ToString();

            s11.Text = s1.ToString();
            s22.Text = s2.ToString();
            total11.Text = t1.ToString();
            total22.Text = t2.ToString();
            total33.Text = t3.ToString();
            total44.Text = t4.ToString();
            total55.Text = t5.ToString();

            panel3.Hide();
            panel5.Hide();
            panel1.Hide();
            panel8.Hide();
            panel10.Hide();
            panel12.Hide();
            panel14.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ปุ่มคำนวณภาษี
            int s1 = int.Parse(salary3.Text);//รายได้
            int s2 = int.Parse(textBox2.Text);//ค่าใช้จ่าย
            int t1 = int.Parse(total1.Text);
            int t2 = int.Parse(total2.Text);
            int t3 = int.Parse(total3.Text);
            int t4 = int.Parse(total4.Text);
            int t5 = int.Parse(total5.Text);
            int totalsum = t1 + t2 + t3 + t4 + t5;
            int salarysum = s1 - (s2 + totalsum);

            double caltax;
            if (salarysum <= 150000)
            {
                caltax = 0;
                tax.Text = caltax.ToString();
            }
            else if (salarysum <= 300000)
            {
                caltax = salarysum * 5 / 100;
                tax.Text = caltax.ToString();
            }
            else if (salarysum <= 500000)
            {
                caltax = salarysum * 10 / 100;
                tax.Text = caltax.ToString();
            }
            else if (salarysum <= 750000)
            {
                caltax = salarysum * 15 / 100;
                tax.Text = caltax.ToString();
            }
            else if (salarysum <= 1000000)
            {
                caltax = salarysum * 20 / 100;
                tax.Text = caltax.ToString();
            }
            else if (salarysum <= 2000000)
            {
                caltax = salarysum * 25 / 100;
                tax.Text = caltax.ToString();
            }
            else if (salarysum <= 5000000)
            {
                caltax = salarysum * 30 / 100;
                tax.Text = caltax.ToString();
            }
            else if (salarysum >= 5000000)
            {
                caltax = salarysum * 35 / 100;
                tax.Text = caltax.ToString();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }
    }
}
