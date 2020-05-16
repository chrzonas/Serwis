namespace Serwis
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_serwis = new System.Windows.Forms.Label();
            this.label_ver = new System.Windows.Forms.Label();
            this.button_client_add = new System.Windows.Forms.Button();
            this.button_client_base = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_add_order = new System.Windows.Forms.Button();
            this.button_order_base = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_serwis
            // 
            this.label_serwis.AutoSize = true;
            this.label_serwis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_serwis.Location = new System.Drawing.Point(88, 16);
            this.label_serwis.Name = "label_serwis";
            this.label_serwis.Size = new System.Drawing.Size(175, 58);
            this.label_serwis.TabIndex = 0;
            this.label_serwis.Text = "Serwis";
            // 
            // label_ver
            // 
            this.label_ver.AutoSize = true;
            this.label_ver.Location = new System.Drawing.Point(178, 70);
            this.label_ver.Name = "label_ver";
            this.label_ver.Size = new System.Drawing.Size(72, 17);
            this.label_ver.TabIndex = 1;
            this.label_ver.Text = "wersja 0.1";
            // 
            // button_client_add
            // 
            this.button_client_add.Location = new System.Drawing.Point(12, 120);
            this.button_client_add.Name = "button_client_add";
            this.button_client_add.Size = new System.Drawing.Size(164, 47);
            this.button_client_add.TabIndex = 2;
            this.button_client_add.Text = "Dodaj klienta";
            this.button_client_add.UseVisualStyleBackColor = true;
            this.button_client_add.Click += new System.EventHandler(this.Button_client_add_Click);
            // 
            // button_client_base
            // 
            this.button_client_base.Location = new System.Drawing.Point(193, 120);
            this.button_client_base.Name = "button_client_base";
            this.button_client_base.Size = new System.Drawing.Size(164, 47);
            this.button_client_base.TabIndex = 3;
            this.button_client_base.Text = "Baza klientów";
            this.button_client_base.UseVisualStyleBackColor = true;
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(12, 252);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(345, 47);
            this.button_settings.TabIndex = 4;
            this.button_settings.Text = "Ustawienia";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.Button_settings_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(12, 316);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(345, 47);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Zamknij";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_add_order
            // 
            this.button_add_order.Location = new System.Drawing.Point(12, 188);
            this.button_add_order.Name = "button_add_order";
            this.button_add_order.Size = new System.Drawing.Size(164, 47);
            this.button_add_order.TabIndex = 6;
            this.button_add_order.Text = "Dodaj zlecenie";
            this.button_add_order.UseVisualStyleBackColor = true;
            // 
            // button_order_base
            // 
            this.button_order_base.Location = new System.Drawing.Point(193, 188);
            this.button_order_base.Name = "button_order_base";
            this.button_order_base.Size = new System.Drawing.Size(164, 47);
            this.button_order_base.TabIndex = 7;
            this.button_order_base.Text = "Baza zleceń";
            this.button_order_base.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 384);
            this.Controls.Add(this.button_order_base);
            this.Controls.Add(this.button_add_order);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_client_base);
            this.Controls.Add(this.button_client_add);
            this.Controls.Add(this.label_ver);
            this.Controls.Add(this.label_serwis);
            this.Name = "Form1";
            this.Text = "Serwis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_serwis;
        private System.Windows.Forms.Label label_ver;
        private System.Windows.Forms.Button button_client_add;
        private System.Windows.Forms.Button button_client_base;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_add_order;
        private System.Windows.Forms.Button button_order_base;
    }
}

