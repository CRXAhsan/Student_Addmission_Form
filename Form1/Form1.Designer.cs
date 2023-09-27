namespace Form1
{
    partial class Form1
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_father_name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_country = new System.Windows.Forms.ComboBox();
            this.cb_city = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_province = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(108, 147);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(71, 24);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_title.Location = new System.Drawing.Point(118, 49);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(460, 33);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "STUDENT ADDMISSION FORM";
            // 
            // lbl_father_name
            // 
            this.lbl_father_name.AutoSize = true;
            this.lbl_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_father_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_father_name.Location = new System.Drawing.Point(493, 147);
            this.lbl_father_name.Name = "lbl_father_name";
            this.lbl_father_name.Size = new System.Drawing.Size(143, 24);
            this.lbl_father_name.TabIndex = 3;
            this.lbl_father_name.Text = "Father\'s Name: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(658, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_gender.Location = new System.Drawing.Point(96, 199);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(84, 24);
            this.lbl_gender.TabIndex = 5;
            this.lbl_gender.Text = "Gender: ";
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_adress.Location = new System.Drawing.Point(83, 295);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(90, 24);
            this.lbl_adress.TabIndex = 6;
            this.lbl_adress.Text = "Address: ";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contact.Location = new System.Drawing.Point(523, 246);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(113, 24);
            this.lbl_contact.TabIndex = 7;
            this.lbl_contact.Text = "Contact No: ";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dob.Location = new System.Drawing.Point(54, 244);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(119, 24);
            this.lbl_dob.TabIndex = 8;
            this.lbl_dob.Text = "Date Of Birth:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(658, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 20);
            this.textBox3.TabIndex = 9;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_male.Location = new System.Drawing.Point(221, 203);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(56, 20);
            this.rb_male.TabIndex = 10;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_female.Location = new System.Drawing.Point(317, 203);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(72, 20);
            this.rb_female.TabIndex = 11;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Location = new System.Drawing.Point(658, 208);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(116, 21);
            this.cb_year.TabIndex = 12;
            // 
            // cb_country
            // 
            this.cb_country.FormattingEnabled = true;
            this.cb_country.Location = new System.Drawing.Point(197, 300);
            this.cb_country.Name = "cb_country";
            this.cb_country.Size = new System.Drawing.Size(97, 21);
            this.cb_country.TabIndex = 13;
            this.cb_country.SelectedIndexChanged += new System.EventHandler(this.Cb_country_SelectedIndexChanged);
            // 
            // cb_city
            // 
            this.cb_city.FormattingEnabled = true;
            this.cb_city.Location = new System.Drawing.Point(300, 300);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(100, 21);
            this.cb_city.TabIndex = 14;
            this.cb_city.SelectedIndexChanged += new System.EventHandler(this.Cb_city_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_status.Location = new System.Drawing.Point(566, 203);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(70, 24);
            this.lbl_status.TabIndex = 15;
            this.lbl_status.Text = "Status: ";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Teal;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_submit.Location = new System.Drawing.Point(408, 436);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(104, 47);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Teal;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(767, 436);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 47);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Teal;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_help.Location = new System.Drawing.Point(796, 39);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 34);
            this.btn_help.TabIndex = 22;
            this.btn_help.Text = "Help ?";
            this.btn_help.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // cb_province
            // 
            this.cb_province.FormattingEnabled = true;
            this.cb_province.Location = new System.Drawing.Point(406, 300);
            this.cb_province.Name = "cb_province";
            this.cb_province.Size = new System.Drawing.Size(100, 21);
            this.cb_province.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(925, 510);
            this.Controls.Add(this.cb_province);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.cb_country);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_father_name);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_father_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ComboBox cb_country;
        private System.Windows.Forms.ComboBox cb_city;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_province;
    }
}

