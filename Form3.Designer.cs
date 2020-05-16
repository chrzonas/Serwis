namespace Serwis
{
    partial class Form3
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
            this.openFileDialog_database = new System.Windows.Forms.OpenFileDialog();
            this.label_serwis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.button_file = new System.Windows.Forms.Button();
            this.button_load_database = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_database
            // 
            this.openFileDialog_database.FileName = "openFileDialog_database";
            this.openFileDialog_database.Filter = "pliki bazy danych|*.mdf";
            // 
            // label_serwis
            // 
            this.label_serwis.AutoSize = true;
            this.label_serwis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_serwis.Location = new System.Drawing.Point(25, 19);
            this.label_serwis.Name = "label_serwis";
            this.label_serwis.Size = new System.Drawing.Size(270, 58);
            this.label_serwis.TabIndex = 1;
            this.label_serwis.Text = "Ustawienia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_load_database);
            this.groupBox1.Controls.Add(this.button_file);
            this.groupBox1.Controls.Add(this.textBox_file);
            this.groupBox1.Location = new System.Drawing.Point(35, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baza danych";
            // 
            // textBox_file
            // 
            this.textBox_file.Enabled = false;
            this.textBox_file.Location = new System.Drawing.Point(17, 34);
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.Size = new System.Drawing.Size(227, 22);
            this.textBox_file.TabIndex = 0;
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(17, 62);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(227, 33);
            this.button_file.TabIndex = 1;
            this.button_file.Text = "Wybierz plik";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.Button_file_Click);
            // 
            // button_load_database
            // 
            this.button_load_database.Location = new System.Drawing.Point(17, 126);
            this.button_load_database.Name = "button_load_database";
            this.button_load_database.Size = new System.Drawing.Size(227, 33);
            this.button_load_database.TabIndex = 2;
            this.button_load_database.Text = "Załaduj bazę";
            this.button_load_database.UseVisualStyleBackColor = true;
            this.button_load_database.Click += new System.EventHandler(this.Button_load_database_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_serwis);
            this.Name = "Form3";
            this.Text = "Ustawienia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_database;
        private System.Windows.Forms.Label label_serwis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_load_database;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.TextBox textBox_file;
    }
}