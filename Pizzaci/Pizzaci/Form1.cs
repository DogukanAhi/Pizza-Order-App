namespace Pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1="",s2="",s3="",s4="",s5="";
            listBox1.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox2.Items.Add(comboBox1.Text);
            listBox4.Items.Add(comboBox2.Text);
            if (checkBox1.Checked)
                s1 = checkBox1.Text + ", ";
            if (checkBox2.Checked)
               s2 = checkBox2.Text + ", ";
            if (checkBox3.Checked)
                s3= checkBox3.Text + ", "; 
            if (checkBox4.Checked)
               s4= checkBox4.Text +", ";
            if (checkBox5.Checked)
                s5= checkBox5.Text+"";
           listBox5.Items.Add(s1+s2+s3+s4+s5);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = checkBox1.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox5.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox4.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text=checkBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 && listBox2.Items.Count == 0 && listBox3.Items.Count == 0 && listBox4.Items.Count == 0 && listBox5.Items.Count == 0 && listBox6.Items.Count == 0)
            {
                MessageBox.Show("There is/are no order(s) to clear!!");
            }
            else
            {
                while (listBox1.Items.Count != 0 && listBox2.Items.Count != 0 && listBox3.Items.Count != 0 && listBox4.Items.Count != 0 && listBox5.Items.Count != 0 && listBox6.Items.Count != 0)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    listBox4.Items.Clear();
                    listBox5.Items.Clear();
                    listBox6.Items.Clear();
                }
                MessageBox.Show("All orders cleared!");
            }       
            }
    }
}