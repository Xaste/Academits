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
            this.inputDegree = new System.Windows.Forms.NumericUpDown();
            this.inputDegreeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SecondResult = new System.Windows.Forms.NumericUpDown();
            this.firstResult = new System.Windows.Forms.NumericUpDown();
            this.secondTemeratureLabel = new System.Windows.Forms.Label();
            this.firstTemeratureLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDegree)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstResult)).BeginInit();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(90, 135);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(99, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Конвертировать";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputDegree);
            this.groupBox1.Controls.Add(this.inputDegreeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите и введите температуру";
            // 
            // inputDegree
            // 
            this.inputDegree.DecimalPlaces = 2;
            this.inputDegree.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputDegree.Location = new System.Drawing.Point(145, 42);
            this.inputDegree.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.inputDegree.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.inputDegree.Name = "inputDegree";
            this.inputDegree.Size = new System.Drawing.Size(100, 20);
            this.inputDegree.TabIndex = 2;
            this.inputDegree.ValueChanged += new System.EventHandler(this.InputDegree_ValueChanged);
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
            this.inputDegreeComboBox.SelectedIndexChanged += new System.EventHandler(this.InputDegreeComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SecondResult);
            this.groupBox2.Controls.Add(this.firstResult);
            this.groupBox2.Controls.Add(this.secondTemeratureLabel);
            this.groupBox2.Controls.Add(this.firstTemeratureLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Температура";
            // 
            // SecondResult
            // 
            this.SecondResult.DecimalPlaces = 2;
            this.SecondResult.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SecondResult.Location = new System.Drawing.Point(145, 36);
            this.SecondResult.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.SecondResult.Minimum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            -2147483648});
            this.SecondResult.Name = "SecondResult";
            this.SecondResult.ReadOnly = true;
            this.SecondResult.Size = new System.Drawing.Size(100, 20);
            this.SecondResult.TabIndex = 5;
            // 
            // firstResult
            // 
            this.firstResult.DecimalPlaces = 2;
            this.firstResult.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.firstResult.Location = new System.Drawing.Point(7, 36);
            this.firstResult.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.firstResult.Minimum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            -2147483648});
            this.firstResult.Name = "firstResult";
            this.firstResult.ReadOnly = true;
            this.firstResult.Size = new System.Drawing.Size(100, 20);
            this.firstResult.TabIndex = 4;
            // 
            // secondTemeratureLabel
            // 
            this.secondTemeratureLabel.AutoSize = true;
            this.secondTemeratureLabel.Location = new System.Drawing.Point(142, 20);
            this.secondTemeratureLabel.Name = "secondTemeratureLabel";
            this.secondTemeratureLabel.Size = new System.Drawing.Size(35, 13);
            this.secondTemeratureLabel.TabIndex = 4;
            this.secondTemeratureLabel.Text = "label2";
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
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(275, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertButton);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертация Температур";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDegree)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox inputDegreeComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label secondTemeratureLabel;
        private System.Windows.Forms.Label firstTemeratureLabel;
        private System.Windows.Forms.NumericUpDown inputDegree;
        private System.Windows.Forms.NumericUpDown SecondResult;
        private System.Windows.Forms.NumericUpDown firstResult;
    }
}

