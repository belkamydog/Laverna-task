namespace WindowsFormsApp2
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
            this.startBtn = new System.Windows.Forms.Button();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(34, 178);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(121, 29);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Узнать погоду";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cityBox
            // 
            this.cityBox.DisplayMember = "Казань";
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Items.AddRange(new object[] {
            "Казань",
            "Москва",
            "Санкт-Петербург",
            "Сочи",
            "Владивосток",
            "Екатеринбург"});
            this.cityBox.Location = new System.Drawing.Point(34, 41);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 1;
            this.cityBox.Text = "Казань";
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете город :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Температура воздуха:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ветер :";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Location = new System.Drawing.Point(205, 88);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(64, 13);
            this.temperature.TabIndex = 6;
            this.temperature.Text = "нет данных";
            this.temperature.Click += new System.EventHandler(this.label5_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(205, 115);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(64, 13);
            this.description.TabIndex = 7;
            this.description.Text = "нет данных";
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.Location = new System.Drawing.Point(205, 140);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(64, 13);
            this.wind.TabIndex = 8;
            this.wind.Text = "нет данных";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 227);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.description);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Погода";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label wind;
    }
}

