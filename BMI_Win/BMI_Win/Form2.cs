using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BMI_Win
{
    public partial class Form2 : Form
    {
        public Form2(string name, int age, string gender, string info, double bmi)
        {
            InitializeComponent();
            txt_name1.Text = "Name: " + name;
            txt_age1.Text = "Age: " + age;
            txt_male1.Text = "Gender: " + gender;
            txt_bmi1.Text = "" + bmi;
            richtxt_info.Text = info;

            if (bmi < 18.5)
            {
                richtxt_info.Text = "You are considered UnderWeight \n\r\nIf you are receiving treatment for an eating disorder then this tool is NOT to be used.\r\n\r\nThere may be an underlying medical cause for your weight, or your diet may not be providing you with enough calories. We suggest you discuss this with your GP.";
            }
            else if (bmi <= 24.9)
            {
                richtxt_info.Text = "Your result suggests you are a HEALTHY WEIGHT \n\r\nWe suggest you maintain your weight. We've got lots of workouts and activity ideas to help you stay active.";
            }
            else if (bmi <= 29.9)
            {
                richtxt_info.Text = "Your result suggests you are OVERWEIGHT \n\r\nExcess weight can put you at increased risk of health issues such as type 2 diabetes, heart disease, stroke.\r\n\r\nWorking towards a healthier weight and keeping the weight off can help reduce your risk of health problems in the longer term.\r\n\r\nYour health could benefit from losing 5% of your weight.";
            }
            else if (bmi > 30)
            {
                richtxt_info.Text = "Your result suggests you are OBESE \n\r\nLosing and keeping off 5% of your weight can have health benefits, such as lowering your blood pressure and reducing your risk of developing type 2 diabetes.\nOver time you should work towards achieving a healthier weight.\r\n\r\nIf you're concerned about your weight speak to your GP.\r\n\r\nAim to lose 5.1kg";
            }
            else
            {
                richtxt_info.Text = "Nothing to display";
            }
            return;

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.ShowDialog();
            

        }
    }
}
