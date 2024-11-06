namespace BMI_Win
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name1 = new TextBox();
            txt_male1 = new TextBox();
            txt_age1 = new TextBox();
            richtxt_info = new RichTextBox();
            BMI_labelresults = new Label();
            txt_bmi1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_name1
            // 
            txt_name1.BackColor = SystemColors.GradientActiveCaption;
            txt_name1.BorderStyle = BorderStyle.None;
            txt_name1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name1.Location = new Point(12, 74);
            txt_name1.Name = "txt_name1";
            txt_name1.ReadOnly = true;
            txt_name1.Size = new Size(337, 31);
            txt_name1.TabIndex = 0;
            txt_name1.TextChanged += textBox1_TextChanged;
            // 
            // txt_male1
            // 
            txt_male1.BackColor = SystemColors.GradientActiveCaption;
            txt_male1.BorderStyle = BorderStyle.None;
            txt_male1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_male1.Location = new Point(554, 74);
            txt_male1.Name = "txt_male1";
            txt_male1.ReadOnly = true;
            txt_male1.Size = new Size(150, 31);
            txt_male1.TabIndex = 1;
            // 
            // txt_age1
            // 
            txt_age1.BackColor = SystemColors.GradientActiveCaption;
            txt_age1.BorderStyle = BorderStyle.None;
            txt_age1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_age1.Location = new Point(392, 79);
            txt_age1.Name = "txt_age1";
            txt_age1.ReadOnly = true;
            txt_age1.Size = new Size(91, 31);
            txt_age1.TabIndex = 3;
            // 
            // richtxt_info
            // 
            richtxt_info.BackColor = SystemColors.GradientActiveCaption;
            richtxt_info.BorderStyle = BorderStyle.None;
            richtxt_info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richtxt_info.Location = new Point(12, 168);
            richtxt_info.Name = "richtxt_info";
            richtxt_info.ReadOnly = true;
            richtxt_info.Size = new Size(776, 220);
            richtxt_info.TabIndex = 4;
            richtxt_info.Text = "";
            // 
            // BMI_labelresults
            // 
            BMI_labelresults.AutoSize = true;
            BMI_labelresults.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BMI_labelresults.ForeColor = Color.Fuchsia;
            BMI_labelresults.Location = new Point(392, 124);
            BMI_labelresults.Name = "BMI_labelresults";
            BMI_labelresults.Size = new Size(125, 31);
            BMI_labelresults.TabIndex = 5;
            BMI_labelresults.Text = "Your BMI: ";
            // 
            // txt_bmi1
            // 
            txt_bmi1.BackColor = SystemColors.GradientActiveCaption;
            txt_bmi1.BorderStyle = BorderStyle.None;
            txt_bmi1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_bmi1.Location = new Point(511, 124);
            txt_bmi1.Name = "txt_bmi1";
            txt_bmi1.ReadOnly = true;
            txt_bmi1.Size = new Size(277, 31);
            txt_bmi1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 71);
            label1.Name = "label1";
            label1.Size = new Size(31, 41);
            label1.TabIndex = 7;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(496, 69);
            label2.Name = "label2";
            label2.Size = new Size(31, 41);
            label2.TabIndex = 8;
            label2.Text = "/";
            // 
            // button1
            // 
            button1.Location = new Point(666, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Start again";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_bmi1);
            Controls.Add(BMI_labelresults);
            Controls.Add(richtxt_info);
            Controls.Add(txt_age1);
            Controls.Add(txt_male1);
            Controls.Add(txt_name1);
            Name = "Form2";
            Text = "BMI Results";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name1;
        private TextBox txt_male1;
        private TextBox txt_age1;
        private RichTextBox richtxt_info;
        private Label BMI_labelresults;
        private TextBox txt_bmi1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}