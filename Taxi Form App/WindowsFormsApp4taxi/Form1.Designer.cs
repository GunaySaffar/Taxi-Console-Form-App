namespace WindowsFormsApp4taxi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Taxiler = new System.Windows.Forms.Button();
            this.Musteriler = new System.Windows.Forms.Button();
            this.AddTaxi = new System.Windows.Forms.Button();
            this.AddMusteri = new System.Windows.Forms.Button();
            this.CallTaxi = new System.Windows.Forms.Button();
            this.TaxiX = new System.Windows.Forms.TextBox();
            this.TaxiY = new System.Windows.Forms.TextBox();
            this.TaxiNum = new System.Windows.Forms.TextBox();
            this.ClientX = new System.Windows.Forms.TextBox();
            this.ClientY = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Taxiler
            // 
            this.Taxiler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Taxiler.Location = new System.Drawing.Point(48, 12);
            this.Taxiler.Name = "Taxiler";
            this.Taxiler.Size = new System.Drawing.Size(109, 34);
            this.Taxiler.TabIndex = 0;
            this.Taxiler.Text = "Taxiler";
            this.Taxiler.UseVisualStyleBackColor = false;
            this.Taxiler.Click += new System.EventHandler(this.button1_Click);
            // 
            // Musteriler
            // 
            this.Musteriler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Musteriler.Location = new System.Drawing.Point(562, 12);
            this.Musteriler.Name = "Musteriler";
            this.Musteriler.Size = new System.Drawing.Size(109, 34);
            this.Musteriler.TabIndex = 1;
            this.Musteriler.Text = "Musteriler";
            this.Musteriler.UseVisualStyleBackColor = false;
            // 
            // AddTaxi
            // 
            this.AddTaxi.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddTaxi.Location = new System.Drawing.Point(4, 69);
            this.AddTaxi.Name = "AddTaxi";
            this.AddTaxi.Size = new System.Drawing.Size(152, 22);
            this.AddTaxi.TabIndex = 2;
            this.AddTaxi.Text = "Elave Et";
            this.AddTaxi.UseVisualStyleBackColor = false;
            this.AddTaxi.Click += new System.EventHandler(this.AddTaxi_Click);
            // 
            // AddMusteri
            // 
            this.AddMusteri.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddMusteri.Location = new System.Drawing.Point(562, 69);
            this.AddMusteri.Name = "AddMusteri";
            this.AddMusteri.Size = new System.Drawing.Size(145, 22);
            this.AddMusteri.TabIndex = 3;
            this.AddMusteri.Text = "Elave Et";
            this.AddMusteri.UseVisualStyleBackColor = false;
            this.AddMusteri.Click += new System.EventHandler(this.AddMusteri_Click);
            // 
            // CallTaxi
            // 
            this.CallTaxi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CallTaxi.Location = new System.Drawing.Point(296, 111);
            this.CallTaxi.Name = "CallTaxi";
            this.CallTaxi.Size = new System.Drawing.Size(135, 40);
            this.CallTaxi.TabIndex = 4;
            this.CallTaxi.Text = "Taxi Chaghir";
            this.CallTaxi.UseVisualStyleBackColor = false;
            this.CallTaxi.Click += new System.EventHandler(this.CallTaxi_Click);
            // 
            // TaxiX
            // 
            this.TaxiX.Location = new System.Drawing.Point(36, 111);
            this.TaxiX.Name = "TaxiX";
            this.TaxiX.Size = new System.Drawing.Size(119, 20);
            this.TaxiX.TabIndex = 5;
            this.TaxiX.TextChanged += new System.EventHandler(this.TaxiX_TextChanged);
            // 
            // TaxiY
            // 
            this.TaxiY.Location = new System.Drawing.Point(36, 145);
            this.TaxiY.Name = "TaxiY";
            this.TaxiY.Size = new System.Drawing.Size(118, 20);
            this.TaxiY.TabIndex = 6;
            this.TaxiY.TextChanged += new System.EventHandler(this.TaxiY_TextChanged);
            // 
            // TaxiNum
            // 
            this.TaxiNum.Location = new System.Drawing.Point(36, 182);
            this.TaxiNum.Name = "TaxiNum";
            this.TaxiNum.Size = new System.Drawing.Size(117, 20);
            this.TaxiNum.TabIndex = 7;
            // 
            // ClientX
            // 
            this.ClientX.Location = new System.Drawing.Point(562, 111);
            this.ClientX.Name = "ClientX";
            this.ClientX.Size = new System.Drawing.Size(119, 20);
            this.ClientX.TabIndex = 8;
            // 
            // ClientY
            // 
            this.ClientY.Location = new System.Drawing.Point(562, 145);
            this.ClientY.Name = "ClientY";
            this.ClientY.Size = new System.Drawing.Size(119, 20);
            this.ClientY.TabIndex = 9;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(562, 182);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(119, 20);
            this.ClientName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ad";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(153, 306);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(409, 20);
            this.result.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Taxi01",
            "Taxi02",
            "Taxi03",
            "Taxi04",
            "Taxi05"});
            this.comboBox1.Location = new System.Drawing.Point(297, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Taxiler";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Client01",
            "Client02",
            "Client03",
            "Client04",
            "Client05"});
            this.comboBox2.Location = new System.Drawing.Point(296, 206);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "Musteriler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 363);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientY);
            this.Controls.Add(this.ClientX);
            this.Controls.Add(this.TaxiNum);
            this.Controls.Add(this.TaxiY);
            this.Controls.Add(this.TaxiX);
            this.Controls.Add(this.CallTaxi);
            this.Controls.Add(this.AddMusteri);
            this.Controls.Add(this.AddTaxi);
            this.Controls.Add(this.Musteriler);
            this.Controls.Add(this.Taxiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Taxiler;
        private System.Windows.Forms.Button Musteriler;
        private System.Windows.Forms.Button AddTaxi;
        private System.Windows.Forms.Button AddMusteri;
        private System.Windows.Forms.Button CallTaxi;
        private System.Windows.Forms.TextBox TaxiX;
        private System.Windows.Forms.TextBox TaxiY;
        private System.Windows.Forms.TextBox TaxiNum;
        private System.Windows.Forms.TextBox ClientX;
        private System.Windows.Forms.TextBox ClientY;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

