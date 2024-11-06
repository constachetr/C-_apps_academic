namespace BMI_Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            txt_height = new TextBox();
            txt_age = new TextBox();
            name_label = new Label();
            height_label = new Label();
            Age_Label = new Label();
            txt_weight = new TextBox();
            weight_label = new Label();
            gender_label = new Label();
            label1 = new Label();
            btn_calculate = new Button();
            btn_reset = new Button();
            comboB_gender = new ComboBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_name.Location = new Point(400, 80);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(338, 38);
            txt_name.TabIndex = 0;
            // 
            // txt_height
            // 
            txt_height.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_height.Location = new Point(400, 196);
            txt_height.Name = "txt_height";
            txt_height.Size = new Size(113, 38);
            txt_height.TabIndex = 1;
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_age.Location = new Point(400, 137);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(113, 38);
            txt_age.TabIndex = 3;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            name_label.Location = new Point(68, 80);
            name_label.Name = "name_label";
            name_label.Size = new Size(162, 38);
            name_label.TabIndex = 4;
            name_label.Text = "Your Name";
            name_label.Click += label1_Click;
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            height_label.Location = new Point(68, 196);
            height_label.Name = "height_label";
            height_label.Size = new Size(283, 38);
            height_label.TabIndex = 5;
            height_label.Text = "What's your Height?";
            // 
            // Age_Label
            // 
            Age_Label.AutoSize = true;
            Age_Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Age_Label.Location = new Point(68, 135);
            Age_Label.Name = "Age_Label";
            Age_Label.Size = new Size(136, 38);
            Age_Label.TabIndex = 6;
            Age_Label.Text = "Your Age";
            // 
            // txt_weight
            // 
            txt_weight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_weight.Location = new Point(400, 258);
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new Size(113, 38);
            txt_weight.TabIndex = 7;
            // 
            // weight_label
            // 
            weight_label.AutoSize = true;
            weight_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            weight_label.Location = new Point(68, 258);
            weight_label.Name = "weight_label";
            weight_label.Size = new Size(289, 38);
            weight_label.TabIndex = 8;
            weight_label.Text = "What's your Weight?";
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            gender_label.Location = new Point(68, 316);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(188, 38);
            gender_label.TabIndex = 9;
            gender_label.Text = "Your Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 40);
            label1.TabIndex = 11;
            label1.Text = "BMI calculator";
            label1.Click += label1_Click_1;
            // 
            // btn_calculate
            // 
            btn_calculate.BackColor = Color.FromArgb(0, 192, 0);
            btn_calculate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_calculate.ForeColor = Color.White;
            btn_calculate.Location = new Point(603, 379);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(149, 49);
            btn_calculate.TabIndex = 12;
            btn_calculate.Text = "Calculate";
            btn_calculate.UseVisualStyleBackColor = false;
            btn_calculate.Click += btn_calculate_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(42, 409);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 13;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // comboB_gender
            // 
            comboB_gender.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboB_gender.FormattingEnabled = true;
            comboB_gender.Items.AddRange(new object[] { "MALE", "FEMALE" });
            comboB_gender.Location = new Point(400, 327);
            comboB_gender.Name = "comboB_gender";
            comboB_gender.Size = new Size(151, 39);
            comboB_gender.TabIndex = 14;
            comboB_gender.Text = "Select";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.GradientActiveCaption;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(310, 406);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 22);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(comboB_gender);
            Controls.Add(btn_reset);
            Controls.Add(btn_calculate);
            Controls.Add(label1);
            Controls.Add(gender_label);
            Controls.Add(weight_label);
            Controls.Add(txt_weight);
            Controls.Add(Age_Label);
            Controls.Add(height_label);
            Controls.Add(name_label);
            Controls.Add(txt_age);
            Controls.Add(txt_height);
            Controls.Add(txt_name);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "BMI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_height;
        private TextBox txt_age;
        private Label name_label;
        private Label height_label;
        private Label Age_Label;
        private TextBox txt_weight;
        private Label weight_label;
        private Label gender_label;
        private Label label1;
        private Button btn_calculate;
        private Button btn_reset;
        private ComboBox comboB_gender;
        private RichTextBox richTextBox1;
    }
}