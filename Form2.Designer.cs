namespace Serwis
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
            this.label_add_client = new System.Windows.Forms.Label();
            this.button1_add = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox_house_number = new System.Windows.Forms.TextBox();
            this.textBox_apartment_number = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_zip_code = new System.Windows.Forms.TextBox();
            this.textBox_post_office = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_add_client
            // 
            this.label_add_client.AutoSize = true;
            this.label_add_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_add_client.Location = new System.Drawing.Point(28, 13);
            this.label_add_client.Name = "label_add_client";
            this.label_add_client.Size = new System.Drawing.Size(314, 58);
            this.label_add_client.TabIndex = 1;
            this.label_add_client.Text = "Dodaj klienta";
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(19, 366);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(323, 34);
            this.button1_add.TabIndex = 2;
            this.button1_add.Text = "Dodaj";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.Button1_add_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(19, 91);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(323, 22);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.Text = "Imię";
            this.textBox_name.Click += new System.EventHandler(this.textBox_name_add_Click);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(19, 119);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(323, 22);
            this.textBox_surname.TabIndex = 4;
            this.textBox_surname.Text = "Nazwisko";
            this.textBox_surname.Click += new System.EventHandler(this.textBox_surname_add_Click);
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(19, 147);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(323, 22);
            this.textBox_tel.TabIndex = 5;
            this.textBox_tel.Text = "Numer telefonu";
            this.textBox_tel.Click += new System.EventHandler(this.textBox_tel_add_Click);
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(19, 175);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(323, 22);
            this.textBox_street.TabIndex = 6;
            this.textBox_street.Text = "Ulica";
            this.textBox_street.Click += new System.EventHandler(this.textBox_street_add_Click);
            // 
            // textBox_house_number
            // 
            this.textBox_house_number.Location = new System.Drawing.Point(19, 203);
            this.textBox_house_number.Name = "textBox_house_number";
            this.textBox_house_number.Size = new System.Drawing.Size(323, 22);
            this.textBox_house_number.TabIndex = 7;
            this.textBox_house_number.Text = "Numer domu";
            this.textBox_house_number.Click += new System.EventHandler(this.textBox_house_number_add_Click);
            // 
            // textBox_apartment_number
            // 
            this.textBox_apartment_number.Location = new System.Drawing.Point(19, 231);
            this.textBox_apartment_number.Name = "textBox_apartment_number";
            this.textBox_apartment_number.Size = new System.Drawing.Size(323, 22);
            this.textBox_apartment_number.TabIndex = 8;
            this.textBox_apartment_number.Text = "Numer mieszkania";
            this.textBox_apartment_number.Click += new System.EventHandler(this.textBox_apartment_number_add_Click);
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(19, 259);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(323, 22);
            this.textBox_city.TabIndex = 9;
            this.textBox_city.Text = "Miejscowość";
            this.textBox_city.Click += new System.EventHandler(this.textBox_city_add_Click);
            // 
            // textBox_zip_code
            // 
            this.textBox_zip_code.Location = new System.Drawing.Point(19, 287);
            this.textBox_zip_code.Name = "textBox_zip_code";
            this.textBox_zip_code.Size = new System.Drawing.Size(323, 22);
            this.textBox_zip_code.TabIndex = 10;
            this.textBox_zip_code.Text = "Kod pocztowy";
            this.textBox_zip_code.Click += new System.EventHandler(this.textBox_zip_code_add_Click);
            // 
            // textBox_post_office
            // 
            this.textBox_post_office.Location = new System.Drawing.Point(19, 315);
            this.textBox_post_office.Name = "textBox_post_office";
            this.textBox_post_office.Size = new System.Drawing.Size(323, 22);
            this.textBox_post_office.TabIndex = 11;
            this.textBox_post_office.Text = "Poczta";
            this.textBox_post_office.Click += new System.EventHandler(this.textBox_post_office_add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 430);
            this.Controls.Add(this.textBox_post_office);
            this.Controls.Add(this.textBox_zip_code);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_apartment_number);
            this.Controls.Add(this.textBox_house_number);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.label_add_client);
            this.Name = "Form2";
            this.Text = "Dodaj klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add_client;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.TextBox textBox_house_number;
        private System.Windows.Forms.TextBox textBox_apartment_number;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.TextBox textBox_zip_code;
        private System.Windows.Forms.TextBox textBox_post_office;
    }
}