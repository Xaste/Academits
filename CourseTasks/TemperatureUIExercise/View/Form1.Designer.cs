namespace TemperatureUIExercise
{
    partial class FormView
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
            this.convertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputDegreeTextBox = new System.Windows.Forms.TextBox();
            this.inputDegreeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.firstTemperaturetextBox = new System.Windows.Forms.TextBox();
            this.secondTemperaturetextBox = new System.Windows.Forms.TextBox();
            this.firstTemeratureLabel = new System.Windows.Forms.Label();
            this.secondTemeratureLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(104, 136);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(99, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Конвертировать";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputDegreeTextBox);
            this.groupBox1.Controls.Add(this.inputDegreeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите и введите температуру";
            // 
            // inputDegreeTextBox
            // 
            this.inputDegreeTextBox.Location = new System.Drawing.Point(135, 42);
            this.inputDegreeTextBox.Name = "inputDegreeTextBox";
            this.inputDegreeTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputDegreeTextBox.TabIndex = 1;
            this.inputDegreeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputDegreeComboBox
            // 
            this.inputDegreeComboBox.FormattingEnabled = true;
            this.inputDegreeComboBox.Items.AddRange(new object[] {
            "Цельсий",
            "Кельвин",
            "Фаренгейт"});
            this.inputDegreeComboBox.Location = new System.Drawing.Point(7, 42);
            this.inputDegreeComboBox.Name = "inputDegreeComboBox";
            this.inputDegreeComboBox.Size = new System.Drawing.Size(121, 21);
            this.inputDegreeComboBox.TabIndex = 0;
            this.inputDegreeComboBox.SelectedIndexChanged += new System.EventHandler(this.inputDegreeComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondTemeratureLabel);
            this.groupBox2.Controls.Add(this.firstTemeratureLabel);
            this.groupBox2.Controls.Add(this.secondTemperaturetextBox);
            this.groupBox2.Controls.Add(this.firstTemperaturetextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Температура";
            // 
            // firstTemperaturetextBox
            // 
            this.firstTemperaturetextBox.Location = new System.Drawing.Point(7, 42);
            this.firstTemperaturetextBox.Name = "firstTemperaturetextBox";
            this.firstTemperaturetextBox.Size = new System.Drawing.Size(100, 20);
            this.firstTemperaturetextBox.TabIndex = 1;
            this.firstTemperaturetextBox.TextChanged += new System.EventHandler(this.firstTemperaturetextBox_TextChanged);
            // 
            // secondTemperaturetextBox
            // 
            this.secondTemperaturetextBox.Location = new System.Drawing.Point(135, 42);
            this.secondTemperaturetextBox.Name = "secondTemperaturetextBox";
            this.secondTemperaturetextBox.Size = new System.Drawing.Size(100, 20);
            this.secondTemperaturetextBox.TabIndex = 2;
            this.secondTemperaturetextBox.TextChanged += new System.EventHandler(this.secondTemperaturetextBox_TextChanged);
            // 
            // firstTemeratureLabel
            // 
            this.firstTemeratureLabel.AutoSize = true;
            this.firstTemeratureLabel.Location = new System.Drawing.Point(7, 20);
            this.firstTemeratureLabel.Name = "firstTemeratureLabel";
            this.firstTemeratureLabel.Size = new System.Drawing.Size(35, 13);
            this.firstTemeratureLabel.TabIndex = 3;
            this.firstTemeratureLabel.Text = "label1";
            // 
            // secondTemeratureLabel
            // 
            this.secondTemeratureLabel.AutoSize = true;
            this.secondTemeratureLabel.Location = new System.Drawing.Point(132, 20);
            this.secondTemeratureLabel.Name = "secondTemeratureLabel";
            this.secondTemeratureLabel.Size = new System.Drawing.Size(35, 13);
            this.secondTemeratureLabel.TabIndex = 4;
            this.secondTemeratureLabel.Text = "label2";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(361, 293);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertButton);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертация Температур";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputDegreeTextBox;
        private System.Windows.Forms.ComboBox inputDegreeComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label secondTemeratureLabel;
        private System.Windows.Forms.Label firstTemeratureLabel;
        private System.Windows.Forms.TextBox secondTemperaturetextBox;
        private System.Windows.Forms.TextBox firstTemperaturetextBox;
    }
}

