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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temperatureTypeComboBox2 = new System.Windows.Forms.ComboBox();
            this.temperatureDegree2 = new System.Windows.Forms.NumericUpDown();
            this.temperatureDegree1 = new System.Windows.Forms.NumericUpDown();
            this.temperatureTypeComboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDegree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDegree1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temperatureTypeComboBox2);
            this.groupBox1.Controls.Add(this.temperatureDegree2);
            this.groupBox1.Controls.Add(this.temperatureDegree1);
            this.groupBox1.Controls.Add(this.temperatureTypeComboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите и введите температуру";
            // 
            // temperatureTypeComboBox2
            // 
            this.temperatureTypeComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temperatureTypeComboBox2.FormattingEnabled = true;
            this.temperatureTypeComboBox2.Location = new System.Drawing.Point(164, 70);
            this.temperatureTypeComboBox2.Name = "temperatureTypeComboBox2";
            this.temperatureTypeComboBox2.Size = new System.Drawing.Size(121, 21);
            this.temperatureTypeComboBox2.TabIndex = 4;
            this.temperatureTypeComboBox2.SelectedValueChanged += new System.EventHandler(this.temperatureTypeComboBox2_SelectedValueChanged);
            // 
            // temperatureDegree2
            // 
            this.temperatureDegree2.DecimalPlaces = 2;
            this.temperatureDegree2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.temperatureDegree2.Location = new System.Drawing.Point(164, 44);
            this.temperatureDegree2.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.temperatureDegree2.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.temperatureDegree2.Name = "temperatureDegree2";
            this.temperatureDegree2.Size = new System.Drawing.Size(121, 20);
            this.temperatureDegree2.TabIndex = 3;
            this.temperatureDegree2.ValueChanged += new System.EventHandler(this.temperatureDegree2_ValueChanged);
            // 
            // temperatureDegree1
            // 
            this.temperatureDegree1.DecimalPlaces = 2;
            this.temperatureDegree1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.temperatureDegree1.Location = new System.Drawing.Point(6, 44);
            this.temperatureDegree1.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.temperatureDegree1.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.temperatureDegree1.Name = "temperatureDegree1";
            this.temperatureDegree1.Size = new System.Drawing.Size(121, 20);
            this.temperatureDegree1.TabIndex = 2;
            this.temperatureDegree1.ValueChanged += new System.EventHandler(this.TemperatureDegree1_ValueChanged);
            // 
            // temperatureTypeComboBox1
            // 
            this.temperatureTypeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temperatureTypeComboBox1.FormattingEnabled = true;
            this.temperatureTypeComboBox1.Location = new System.Drawing.Point(6, 70);
            this.temperatureTypeComboBox1.Name = "temperatureTypeComboBox1";
            this.temperatureTypeComboBox1.Size = new System.Drawing.Size(121, 21);
            this.temperatureTypeComboBox1.TabIndex = 0;
            this.temperatureTypeComboBox1.SelectedValueChanged += new System.EventHandler(this.temperatureTypeComboBox1_SelectedValueChanged);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(314, 127);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертация Температур";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDegree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureDegree1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox temperatureTypeComboBox1;
        private System.Windows.Forms.NumericUpDown temperatureDegree1;
        private System.Windows.Forms.ComboBox temperatureTypeComboBox2;
        private System.Windows.Forms.NumericUpDown temperatureDegree2;
    }
}

