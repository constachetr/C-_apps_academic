namespace BMI_Win
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txt_height.Text, out float height) && float.TryParse(txt_weight.Text, out float weight))
            {
                string name = txt_name.Text;
                int age = int.Parse(txt_age.Text);
                string gender = comboB_gender.Text;
                string info = richTextBox1.Text;


                double bmi = weight / (height * height);

                Form2 secondForm = new Form2(name, age, gender, info, bmi);
                secondForm.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Please enter valid height and weight.");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_age.Clear();
            txt_height.Clear();
            txt_weight.Clear();
        }
    }
}